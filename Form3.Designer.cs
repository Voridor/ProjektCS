namespace ProjektCS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            buttonBrowseImage = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            buttonBrowse = new Button();
            label7 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // comboBox6
            // 
            comboBox6.Dock = DockStyle.Fill;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(0, 0);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(254, 23);
            comboBox6.TabIndex = 15;
            // 
            // comboBox5
            // 
            comboBox5.Dock = DockStyle.Fill;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(0, 0);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(254, 23);
            comboBox5.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 13;
            label1.Text = "Tytuł";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 26);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 11;
            label6.Text = "Reżyser";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Data wydania";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 26);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Aktor";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 23);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 26);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Gatunki";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 26);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Ścieżka do obrazu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.334446F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311157F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 2);
            tableLayoutPanel2.Controls.Add(panel5, 0, 3);
            tableLayoutPanel2.Controls.Add(panel6, 0, 4);
            tableLayoutPanel2.Controls.Add(panel7, 0, 5);
            tableLayoutPanel2.Controls.Add(button1, 0, 7);
            tableLayoutPanel2.Controls.Add(panel1, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(269, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991779F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991732F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991732F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991732F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991732F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991693F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5016727F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5032816F));
            tableLayoutPanel2.Size = new Size(260, 444);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 49);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 49);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 49);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonBrowseImage);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 168);
            panel5.Name = "panel5";
            panel5.Size = new Size(254, 49);
            panel5.TabIndex = 3;
            // 
            // buttonBrowseImage
            // 
            buttonBrowseImage.Dock = DockStyle.Top;
            buttonBrowseImage.Location = new Point(0, 0);
            buttonBrowseImage.Name = "buttonBrowseImage";
            buttonBrowseImage.Size = new Size(254, 23);
            buttonBrowseImage.TabIndex = 8;
            buttonBrowseImage.Text = "Wybierz obraz";
            buttonBrowseImage.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(comboBox5);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 223);
            panel6.Name = "panel6";
            panel6.Size = new Size(254, 49);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBox6);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 278);
            panel7.Name = "panel7";
            panel7.Size = new Size(254, 49);
            panel7.TabIndex = 5;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 388);
            button1.Name = "button1";
            button1.Size = new Size(254, 53);
            button1.TabIndex = 14;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonBrowse);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 333);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 49);
            panel1.TabIndex = 15;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Dock = DockStyle.Top;
            buttonBrowse.Location = new Point(0, 0);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(254, 23);
            buttonBrowse.TabIndex = 2;
            buttonBrowse.Text = "Wybierz plik";
            buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 26);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 1;
            label7.Text = "Ścieżka do pliku";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form3";
            Text = "Form3";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label2;
        private Label label5;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button button1;
        private Panel panel1;
        private Label label7;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button buttonBrowse;
        private Button buttonBrowseImage;
    }
}