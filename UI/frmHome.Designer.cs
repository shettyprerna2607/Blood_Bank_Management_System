namespace Blood_Bank_Management_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lbnAppName = new System.Windows.Forms.Label();
            this.panelOPositive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOPositiveCount = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegativeCount = new System.Windows.Forms.Label();
            this.lblONegative = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnegativeCount = new System.Windows.Forms.Label();
            this.lblANegative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApositiveCount = new System.Windows.Forms.Label();
            this.lblApositive = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABNegativeCount = new System.Windows.Forms.Label();
            this.lblABNegative = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBNegativeCount = new System.Windows.Forms.Label();
            this.lblBNegative = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblABPositiveCount = new System.Windows.Forms.Label();
            this.lblABpositive = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBPostiveCount = new System.Windows.Forms.Label();
            this.lblBPositive = new System.Windows.Forms.Label();
            this.dgvDoners = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelOPositive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.donerToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(8, 12, 0, 12);
            this.menuStripTop.Size = new System.Drawing.Size(1510, 48);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.userToolStripMenuItem.Text = "Users";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // donerToolStripMenuItem
            // 
            this.donerToolStripMenuItem.Name = "donerToolStripMenuItem";
            this.donerToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.donerToolStripMenuItem.Text = "Doner";
            this.donerToolStripMenuItem.Click += new System.EventHandler(this.donerToolStripMenuItem_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.lbnAppName);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 712);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1510, 39);
            this.panelFooter.TabIndex = 2;
            // 
            // lbnAppName
            // 
            this.lbnAppName.AutoSize = true;
            this.lbnAppName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnAppName.ForeColor = System.Drawing.Color.DarkRed;
            this.lbnAppName.Location = new System.Drawing.Point(597, 7);
            this.lbnAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnAppName.Name = "lbnAppName";
            this.lbnAppName.Size = new System.Drawing.Size(324, 23);
            this.lbnAppName.TabIndex = 0;
            this.lbnAppName.Text = "Blood Bank Management System";
            // 
            // panelOPositive
            // 
            this.panelOPositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOPositive.Controls.Add(this.lblName);
            this.panelOPositive.Controls.Add(this.lblOPositiveCount);
            this.panelOPositive.Controls.Add(this.lblBloodGroup);
            this.panelOPositive.Location = new System.Drawing.Point(16, 105);
            this.panelOPositive.Margin = new System.Windows.Forms.Padding(4);
            this.panelOPositive.Name = "panelOPositive";
            this.panelOPositive.Size = new System.Drawing.Size(267, 123);
            this.panelOPositive.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblName.Location = new System.Drawing.Point(144, 68);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Doners";
            // 
            // lblOPositiveCount
            // 
            this.lblOPositiveCount.AutoSize = true;
            this.lblOPositiveCount.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPositiveCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOPositiveCount.Location = new System.Drawing.Point(135, 16);
            this.lblOPositiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPositiveCount.Name = "lblOPositiveCount";
            this.lblOPositiveCount.Size = new System.Drawing.Size(107, 53);
            this.lblOPositiveCount.TabIndex = 1;
            this.lblOPositiveCount.Text = "100";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBloodGroup.Location = new System.Drawing.Point(16, 34);
            this.lblBloodGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(106, 57);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "O+";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblOnegativeCount);
            this.panel1.Controls.Add(this.lblONegative);
            this.panel1.Location = new System.Drawing.Point(303, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(144, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doners";
            // 
            // lblOnegativeCount
            // 
            this.lblOnegativeCount.AutoSize = true;
            this.lblOnegativeCount.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegativeCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOnegativeCount.Location = new System.Drawing.Point(156, 16);
            this.lblOnegativeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnegativeCount.Name = "lblOnegativeCount";
            this.lblOnegativeCount.Size = new System.Drawing.Size(79, 53);
            this.lblOnegativeCount.TabIndex = 1;
            this.lblOnegativeCount.Text = "50";
            // 
            // lblONegative
            // 
            this.lblONegative.AutoSize = true;
            this.lblONegative.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblONegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblONegative.Location = new System.Drawing.Point(16, 34);
            this.lblONegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblONegative.Name = "lblONegative";
            this.lblONegative.Size = new System.Drawing.Size(88, 57);
            this.lblONegative.TabIndex = 0;
            this.lblONegative.Text = "O-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAnegativeCount);
            this.panel2.Controls.Add(this.lblANegative);
            this.panel2.Location = new System.Drawing.Point(303, 246);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 123);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(144, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doners";
            // 
            // lblAnegativeCount
            // 
            this.lblAnegativeCount.AutoSize = true;
            this.lblAnegativeCount.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegativeCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnegativeCount.Location = new System.Drawing.Point(156, 16);
            this.lblAnegativeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnegativeCount.Name = "lblAnegativeCount";
            this.lblAnegativeCount.Size = new System.Drawing.Size(79, 53);
            this.lblAnegativeCount.TabIndex = 1;
            this.lblAnegativeCount.Text = "36";
            // 
            // lblANegative
            // 
            this.lblANegative.AutoSize = true;
            this.lblANegative.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblANegative.Location = new System.Drawing.Point(16, 34);
            this.lblANegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblANegative.Name = "lblANegative";
            this.lblANegative.Size = new System.Drawing.Size(84, 57);
            this.lblANegative.TabIndex = 0;
            this.lblANegative.Text = "A-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblApositiveCount);
            this.panel3.Controls.Add(this.lblApositive);
            this.panel3.Location = new System.Drawing.Point(16, 246);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 123);
            this.panel3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(144, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Doners";
            // 
            // lblApositiveCount
            // 
            this.lblApositiveCount.AutoSize = true;
            this.lblApositiveCount.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositiveCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblApositiveCount.Location = new System.Drawing.Point(156, 16);
            this.lblApositiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApositiveCount.Name = "lblApositiveCount";
            this.lblApositiveCount.Size = new System.Drawing.Size(79, 53);
            this.lblApositiveCount.TabIndex = 1;
            this.lblApositiveCount.Text = "45";
            // 
            // lblApositive
            // 
            this.lblApositive.AutoSize = true;
            this.lblApositive.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblApositive.Location = new System.Drawing.Point(16, 34);
            this.lblApositive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApositive.Name = "lblApositive";
            this.lblApositive.Size = new System.Drawing.Size(102, 57);
            this.lblApositive.TabIndex = 0;
            this.lblApositive.Text = "A+";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblABNegativeCount);
            this.panel4.Controls.Add(this.lblABNegative);
            this.panel4.Location = new System.Drawing.Point(303, 533);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 123);
            this.panel4.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(144, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Doners";
            // 
            // lblABNegativeCount
            // 
            this.lblABNegativeCount.AutoSize = true;
            this.lblABNegativeCount.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABNegativeCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABNegativeCount.Location = new System.Drawing.Point(168, 16);
            this.lblABNegativeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABNegativeCount.Name = "lblABNegativeCount";
            this.lblABNegativeCount.Size = new System.Drawing.Size(51, 53);
            this.lblABNegativeCount.TabIndex = 1;
            this.lblABNegativeCount.Text = "3";
            // 
            // lblABNegative
            // 
            this.lblABNegative.AutoSize = true;
            this.lblABNegative.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABNegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABNegative.Location = new System.Drawing.Point(16, 34);
            this.lblABNegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABNegative.Name = "lblABNegative";
            this.lblABNegative.Size = new System.Drawing.Size(120, 57);
            this.lblABNegative.TabIndex = 0;
            this.lblABNegative.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblBNegativeCount);
            this.panel5.Controls.Add(this.lblBNegative);
            this.panel5.Location = new System.Drawing.Point(303, 391);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 123);
            this.panel5.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(144, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Doners";
            // 
            // lblBNegativeCount
            // 
            this.lblBNegativeCount.AutoSize = true;
            this.lblBNegativeCount.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNegativeCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBNegativeCount.Location = new System.Drawing.Point(156, 16);
            this.lblBNegativeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBNegativeCount.Name = "lblBNegativeCount";
            this.lblBNegativeCount.Size = new System.Drawing.Size(79, 53);
            this.lblBNegativeCount.TabIndex = 1;
            this.lblBNegativeCount.Text = "19";
            this.lblBNegativeCount.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblBNegative
            // 
            this.lblBNegative.AutoSize = true;
            this.lblBNegative.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBNegative.Location = new System.Drawing.Point(16, 34);
            this.lblBNegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBNegative.Name = "lblBNegative";
            this.lblBNegative.Size = new System.Drawing.Size(84, 57);
            this.lblBNegative.TabIndex = 0;
            this.lblBNegative.Text = "B-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.lblABPositiveCount);
            this.panel6.Controls.Add(this.lblABpositive);
            this.panel6.Location = new System.Drawing.Point(16, 533);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 123);
            this.panel6.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(144, 68);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Doners";
            // 
            // lblABPositiveCount
            // 
            this.lblABPositiveCount.AutoSize = true;
            this.lblABPositiveCount.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABPositiveCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABPositiveCount.Location = new System.Drawing.Point(156, 16);
            this.lblABPositiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABPositiveCount.Name = "lblABPositiveCount";
            this.lblABPositiveCount.Size = new System.Drawing.Size(79, 53);
            this.lblABPositiveCount.TabIndex = 1;
            this.lblABPositiveCount.Text = "10";
            // 
            // lblABpositive
            // 
            this.lblABpositive.AutoSize = true;
            this.lblABpositive.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABpositive.Location = new System.Drawing.Point(4, 34);
            this.lblABpositive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABpositive.Name = "lblABpositive";
            this.lblABpositive.Size = new System.Drawing.Size(138, 57);
            this.lblABpositive.TabIndex = 0;
            this.lblABpositive.Text = "AB+";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.lblBPostiveCount);
            this.panel7.Controls.Add(this.lblBPositive);
            this.panel7.Location = new System.Drawing.Point(16, 391);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 123);
            this.panel7.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(144, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "Doners";
            // 
            // lblBPostiveCount
            // 
            this.lblBPostiveCount.AutoSize = true;
            this.lblBPostiveCount.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPostiveCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBPostiveCount.Location = new System.Drawing.Point(156, 16);
            this.lblBPostiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBPostiveCount.Name = "lblBPostiveCount";
            this.lblBPostiveCount.Size = new System.Drawing.Size(79, 53);
            this.lblBPostiveCount.TabIndex = 1;
            this.lblBPostiveCount.Text = "23";
            // 
            // lblBPositive
            // 
            this.lblBPositive.AutoSize = true;
            this.lblBPositive.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBPositive.Location = new System.Drawing.Point(16, 34);
            this.lblBPositive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBPositive.Name = "lblBPositive";
            this.lblBPositive.Size = new System.Drawing.Size(102, 57);
            this.lblBPositive.TabIndex = 0;
            this.lblBPositive.Text = "B+";
            // 
            // dgvDoners
            // 
            this.dgvDoners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoners.Location = new System.Drawing.Point(601, 172);
            this.dgvDoners.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDoners.Name = "dgvDoners";
            this.dgvDoners.RowHeadersWidth = 51;
            this.dgvDoners.Size = new System.Drawing.Size(878, 484);
            this.dgvDoners.TabIndex = 11;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(596, 105);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(178, 25);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search Doner :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(782, 101);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(697, 32);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(1444, 13);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(35, 23);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitle.ForeColor = System.Drawing.Color.White;
            this.lblUserTitle.Location = new System.Drawing.Point(30, 62);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(128, 18);
            this.lblUserTitle.TabIndex = 15;
            this.lblUserTitle.Text = "Logged In As :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(181, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 18);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = ".";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1510, 751);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDoners);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelOPositive);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripTop;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMS Home Page";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelOPositive.ResumeLayout(false);
            this.panelOPositive.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donerToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lbnAppName;
        private System.Windows.Forms.Panel panelOPositive;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblOPositiveCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegativeCount;
        private System.Windows.Forms.Label lblONegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnegativeCount;
        private System.Windows.Forms.Label lblANegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApositiveCount;
        private System.Windows.Forms.Label lblApositive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABNegativeCount;
        private System.Windows.Forms.Label lblABNegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBNegativeCount;
        private System.Windows.Forms.Label lblBNegative;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblABPositiveCount;
        private System.Windows.Forms.Label lblABpositive;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBPostiveCount;
        private System.Windows.Forms.Label lblBPositive;
        private System.Windows.Forms.DataGridView dgvDoners;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUser;
    }
}

