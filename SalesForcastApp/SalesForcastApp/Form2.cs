using SalesForcastApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesForcastApp
{
    public partial class Form2 : Form
    {
        public Form2(List<IncrementSales> incrementSales)
        {
            InitializeComponent();
            dataGridView1.DataSource = incrementSales;
        }
    }
}
