namespace SalesForcastApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            sidePanel = new Panel();
            buttonStateIncrement = new Button();
            buttonReset = new Button();
            buttonDownloadData = new Button();
            buttonIncrement = new Button();
            buttonSales = new Button();
            label1 = new Label();
            state = new Label();
            label2 = new Label();
            comboBoxState = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxYear = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBoxInc = new TextBox();
            textBoxResult = new TextBox();
            label7 = new Label();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(669, 46);
            title.TabIndex = 0;
            title.Text = "Welcome to Sales Forcasting Application";
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.LightSkyBlue;
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(buttonStateIncrement);
            sidePanel.Controls.Add(buttonReset);
            sidePanel.Controls.Add(buttonDownloadData);
            sidePanel.Controls.Add(buttonIncrement);
            sidePanel.Controls.Add(buttonSales);
            sidePanel.Controls.Add(label1);
            sidePanel.Location = new Point(10, 56);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(248, 432);
            sidePanel.TabIndex = 1;
            // 
            // buttonStateIncrement
            // 
            buttonStateIncrement.BackColor = Color.Cornsilk;
            buttonStateIncrement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStateIncrement.ForeColor = SystemColors.ActiveCaptionText;
            buttonStateIncrement.Location = new Point(20, 197);
            buttonStateIncrement.Name = "buttonStateIncrement";
            buttonStateIncrement.Size = new Size(188, 62);
            buttonStateIncrement.TabIndex = 6;
            buttonStateIncrement.Text = "Calculate Increment for State";
            buttonStateIncrement.UseVisualStyleBackColor = false;
            buttonStateIncrement.Click += buttonStateIncrement_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Cornsilk;
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.ForeColor = SystemColors.ActiveCaptionText;
            buttonReset.Location = new Point(20, 356);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(188, 46);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonDownloadData
            // 
            buttonDownloadData.BackColor = Color.Cornsilk;
            buttonDownloadData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDownloadData.ForeColor = SystemColors.ActiveCaptionText;
            buttonDownloadData.Location = new Point(20, 279);
            buttonDownloadData.Name = "buttonDownloadData";
            buttonDownloadData.Size = new Size(188, 46);
            buttonDownloadData.TabIndex = 3;
            buttonDownloadData.Text = "Download Data";
            buttonDownloadData.UseVisualStyleBackColor = false;
            buttonDownloadData.Click += buttonDownloadData_Click;
            // 
            // buttonIncrement
            // 
            buttonIncrement.BackColor = Color.Cornsilk;
            buttonIncrement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIncrement.ForeColor = SystemColors.ActiveCaptionText;
            buttonIncrement.Location = new Point(20, 129);
            buttonIncrement.Name = "buttonIncrement";
            buttonIncrement.Size = new Size(188, 46);
            buttonIncrement.TabIndex = 2;
            buttonIncrement.Text = "Calculate Increment";
            buttonIncrement.UseVisualStyleBackColor = false;
            buttonIncrement.Click += buttonIncrement_Click;
            // 
            // buttonSales
            // 
            buttonSales.BackColor = Color.Cornsilk;
            buttonSales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSales.ForeColor = SystemColors.ActiveCaptionText;
            buttonSales.Location = new Point(20, 59);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(188, 51);
            buttonSales.TabIndex = 1;
            buttonSales.Text = "Calculate Sales";
            buttonSales.UseVisualStyleBackColor = false;
            buttonSales.Click += buttonSales_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 0;
            label1.Text = "Choose your Operation";
            // 
            // state
            // 
            state.AutoSize = true;
            state.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            state.Location = new Point(360, 106);
            state.Name = "state";
            state.Size = new Size(53, 25);
            state.TabIndex = 2;
            state.Text = "State";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(301, 72);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 3;
            label2.Text = "Choose your state...";
            // 
            // comboBoxState
            // 
            comboBoxState.BackColor = SystemColors.Info;
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(471, 103);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(151, 28);
            comboBoxState.TabIndex = 4;
            comboBoxState.DropDown += comboBoxState_DropDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(301, 164);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 5;
            label3.Text = "Choose your year...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(360, 207);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 6;
            label4.Text = "Year";
            // 
            // comboBoxYear
            // 
            comboBoxYear.BackColor = SystemColors.Info;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(471, 204);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(151, 28);
            comboBoxYear.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(306, 254);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(322, 257);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 9;
            label6.Text = "Increment %";
            // 
            // textBoxInc
            // 
            textBoxInc.Location = new Point(471, 258);
            textBoxInc.Name = "textBoxInc";
            textBoxInc.Size = new Size(151, 27);
            textBoxInc.TabIndex = 10;
            textBoxInc.Text = "10";
            // 
            // textBoxResult
            // 
            textBoxResult.ForeColor = Color.Gray;
            textBoxResult.Location = new Point(306, 374);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(514, 27);
            textBoxResult.TabIndex = 11;
            textBoxResult.Text = "Choose your operation to see the result...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(308, 336);
            label7.Name = "label7";
            label7.Size = new Size(152, 25);
            label7.TabIndex = 12;
            label7.Text = "Operation Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(900, 500);
            Controls.Add(label7);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxInc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxYear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxState);
            Controls.Add(label2);
            Controls.Add(state);
            Controls.Add(sidePanel);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Sales Forcasting Application";
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label title;
        private Panel sidePanel;
        private Label label1;
        private Button buttonSales;
        private Label state;
        private Label label2;
        private ComboBox comboBoxState;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxYear;
        private Label label5;
        private Label label6;
        private Button buttonIncrement;
        private TextBox textBoxInc;
        private TextBox textBoxResult;
        private Label label7;
        private Button buttonDownloadData;
        private Button buttonReset;
        private Button buttonStateIncrement;
    }
}
