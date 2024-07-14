using SalesForcastApp.Models;
using System.Data;
using System.Globalization;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
namespace SalesForcastApp
{
    public partial class Form1 : Form
    {
        private string connectionString;
        public List<Orders> Orders { get; set; }
        public List<string> States { get; set; }
        public List<int> ShippingYears { get; set; }
        List<IncrementSales> StatesSalesIncrement { get; set; }
        public Form1()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadStates();
            LoadYear();

            // Set the first item as the selected value
            if (States.Any())
            {
                comboBoxState.DataSource = States;
                comboBoxState.SelectedItem = States.FirstOrDefault();
            }

            if (ShippingYears.Any())
            {
                comboBoxYear.DataSource = ShippingYears;
                comboBoxYear.SelectedItem = ShippingYears.FirstOrDefault();
            }
        }

        private void comboBoxState_DropDown(object sender, EventArgs e)
        {
            // Set the dropdown height to fit within the form's bounds
            int dropdownHeight = this.ClientSize.Height - comboBoxState.Location.Y - comboBoxState.Height;
            comboBoxState.DropDownHeight = Math.Max(100, dropdownHeight); // Minimum height
        }

        private void LoadYear()
        {
            Orders = new List<Orders>();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<string> shipDates = new List<string>();
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT  DISTINCT [ShipDate]  from Orders";  // Adjust your query as needed

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            shipDates.Add(reader["ShipDate"].ToString());
                        }
                    }
                }

                ShippingYears = shipDates
                 .Select(dateString => DateTime.ParseExact(dateString, "M/d/yy", CultureInfo.InvariantCulture).Year)
                 .Distinct()
                 .OrderBy(year => year)
                 .ToList();
            }
        }

        private void LoadStates()
        {
            States = new List<string>();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT [State] FROM Orders";

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            States.Add(reader["State"].ToString());
                        }
                    }
                }
            }

            // Sort the states alphabetically
            States = States.OrderBy(s => s).ToList();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            string selectedState = comboBoxState.SelectedItem.ToString();
            string selectedYear = comboBoxYear.SelectedItem.ToString();

            // Call the stored procedure
            double stateSales = double.Parse(CallStoredProcedure(selectedYear, "CalculateYearlySalesByState", state: selectedState).ToString());
            textBoxResult.ForeColor = Color.Black;
            textBoxResult.Text = $"State {selectedState} has total sales {stateSales} in Year {selectedYear}";
        }

        private object CallStoredProcedure(string year, string storedProdcedure, string state = "", double incrementValue = 0)
        {
            double stateSales = 0;
            List<IncrementSales> incrementSales = new List<IncrementSales>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(storedProdcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (!string.IsNullOrEmpty(state))
                    {


                        command.Parameters.AddWithValue("@State", state);
                        command.Parameters.AddWithValue("@Year", year);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Only read the first row
                            {
                                stateSales = Math.Round(double.Parse(reader["TotalSales"].ToString()), 2);
                            }
                        }
                        return stateSales;
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@SelectedYear", year);
                        command.Parameters.AddWithValue("@PercentageIncrement", incrementValue);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IncrementSales incSales = new IncrementSales
                                {
                                    State = reader["State"].ToString(),
                                    TotalSales = Math.Round(double.Parse(reader["TotalSales"].ToString()), 2),
                                    IncrementedSales = Math.Round(double.Parse(reader["IncrementedSales"].ToString()), 2),
                                    NewSales = Math.Round(double.Parse(reader["NewSales"].ToString()), 2)
                                };

                                incrementSales.Add(incSales);
                            }
                        }
                        return incrementSales;
                    }
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "Choose your operation to see the result...";
            textBoxResult.ForeColor = Color.Gray;
        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            string selectedYear = comboBoxYear.SelectedItem.ToString();
            double incrementPer = double.Parse(textBoxInc.Text);
            StatesSalesIncrement = new List<IncrementSales>();
            StatesSalesIncrement = CallStoredProcedure(selectedYear, "ApplyCommonSalesIncrementToState", incrementValue: incrementPer) as List<IncrementSales>;
            Form2 incrementTable = new Form2(StatesSalesIncrement);
            incrementTable.Show();
        }

        private void buttonStateIncrement_Click(object sender, EventArgs e)
        {
            string selectedYear = comboBoxYear.SelectedItem.ToString();
            double incrementPer = double.Parse(textBoxInc.Text);
            string selectedState = comboBoxState.SelectedItem.ToString();

            StatesSalesIncrement = new List<IncrementSales>();
            StatesSalesIncrement = CallStoredProcedure(selectedYear, "ApplyCommonSalesIncrementToState", incrementValue: incrementPer) as List<IncrementSales>;
            IncrementSales selectedStateSalesIncrement = StatesSalesIncrement.FirstOrDefault(s => s.State == selectedState);
            textBoxResult.ForeColor = Color.Black;
            // Display the result
            if (selectedStateSalesIncrement != null)
            {
                textBoxResult.Text = $"State: {selectedStateSalesIncrement.State}, Sales: {selectedStateSalesIncrement.TotalSales}, Incremented Sales: {selectedStateSalesIncrement.IncrementedSales}";
            }
            else
            {
                textBoxResult.Text = "No sales data found for the selected state and year.";
            }
        }

        private void buttonDownloadData_Click(object sender, EventArgs e)
        {
            string selectedYear = comboBoxYear.SelectedItem.ToString();
            double incrementPer = double.Parse(textBoxInc.Text);
            StatesSalesIncrement = new List<IncrementSales>();
            StatesSalesIncrement = CallStoredProcedure(selectedYear, "ApplyCommonSalesIncrementToState", incrementValue: incrementPer) as List<IncrementSales>;
            SaveListAsCsv(StatesSalesIncrement);
        }

        public void SaveListAsCsv(List<IncrementSales> list)
        {
            string csvContent = ConvertListToCsv(list);

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    string filePath = Path.Combine(folderPath, "IncrementSales.csv");

                    File.WriteAllText(filePath, csvContent);
                    MessageBox.Show($"CSV file saved successfully to {filePath}");
                }
                else
                {
                    MessageBox.Show("Folder selection was cancelled.");
                }
            }
        }

        public string ConvertListToCsv(List<IncrementSales> list)
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("State,Percentage Increase,IncrementedSales");

            foreach (var item in list)
            {
                csv.AppendLine($"{item.State},{textBoxInc.Text},{item.IncrementedSales}");
            }

            return csv.ToString();
        }
    }
}
