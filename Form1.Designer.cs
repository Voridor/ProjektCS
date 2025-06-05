namespace ProjektC_
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
        /// <param name="disposing">true if managed resources should be disposed; otherwise false.</param>
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            imageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            dodajToolStripMenuItem = new ToolStripMenuItem();
            fIlmToolStripMenuItem = new ToolStripMenuItem();
            aktoraToolStripMenuItem = new ToolStripMenuItem();
            reżyseraToolStripMenuItem = new ToolStripMenuItem();
            odświeżToolStripMenuItem = new ToolStripMenuItem();
            usuńOstatnieToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(2, 1);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(0, 0);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.375F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.625F));
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Controls.Add(listBox1, 1, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 30);
            tableLayoutPanel2.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.888889F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 91.1111145F));
            tableLayoutPanel2.Size = new Size(1222, 835);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(2, 3);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(990, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(996, 3);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.MinimumSize = new Size(0, 27);
            button1.Name = "button1";
            button1.Size = new Size(224, 30);
            button1.TabIndex = 1;
            button1.Text = "Szukaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Top;
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Nazwa", "Reżyser", "Aktor", "Data wydania", "Gatunek" });
            listBox1.Location = new Point(996, 77);
            listBox1.Margin = new Padding(2, 3, 2, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 104);
            listBox1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 77);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(990, 755);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dodajToolStripMenuItem, odświeżToolStripMenuItem, usuńOstatnieToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1222, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            dodajToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fIlmToolStripMenuItem, aktoraToolStripMenuItem, reżyseraToolStripMenuItem });
            dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            dodajToolStripMenuItem.Size = new Size(64, 24);
            dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // fIlmToolStripMenuItem
            // 
            fIlmToolStripMenuItem.Name = "fIlmToolStripMenuItem";
            fIlmToolStripMenuItem.Size = new Size(150, 26);
            fIlmToolStripMenuItem.Text = "FIlm";
            fIlmToolStripMenuItem.Click += fIlmToolStripMenuItem_Click;
            // 
            // aktoraToolStripMenuItem
            // 
            aktoraToolStripMenuItem.Name = "aktoraToolStripMenuItem";
            aktoraToolStripMenuItem.Size = new Size(150, 26);
            aktoraToolStripMenuItem.Text = "Aktora";
            aktoraToolStripMenuItem.Click += aktoraToolStripMenuItem_Click_1;
            // 
            // reżyseraToolStripMenuItem
            // 
            reżyseraToolStripMenuItem.Name = "reżyseraToolStripMenuItem";
            reżyseraToolStripMenuItem.Size = new Size(150, 26);
            reżyseraToolStripMenuItem.Text = "Reżysera";
            reżyseraToolStripMenuItem.Click += reżyseraToolStripMenuItem_Click;
            // 
            // odświeżToolStripMenuItem
            // 
            odświeżToolStripMenuItem.Name = "odświeżToolStripMenuItem";
            odświeżToolStripMenuItem.Size = new Size(79, 24);
            odświeżToolStripMenuItem.Text = "Odśwież";
            odświeżToolStripMenuItem.Click += odświeżToolStripMenuItem_Click;
            // 
            // usuńOstatnieToolStripMenuItem
            // 
            usuńOstatnieToolStripMenuItem.Name = "usuńOstatnieToolStripMenuItem";
            usuńOstatnieToolStripMenuItem.Size = new Size(112, 24);
            usuńOstatnieToolStripMenuItem.Text = "Usuń ostatnie";
            usuńOstatnieToolStripMenuItem.Click += usuńOstatnieToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 865);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripMenuItem aktoraToolStripMenuItem;
        private ToolStripMenuItem reżyseraToolStripMenuItem;
        private ToolStripMenuItem fIlmToolStripMenuItem;
        private ToolStripMenuItem odświeżToolStripMenuItem;
        private ToolStripMenuItem usuńOstatnieToolStripMenuItem;
    }
}