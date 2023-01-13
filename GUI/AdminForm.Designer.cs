namespace WalmartDesktopAPP.GUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminNametext = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomerViewButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddProductButton = new Guna.UI2.WinForms.Guna2Button();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.ViewProductButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateProducts1 = new WalmartDesktopAPP.GUI.UpdateProducts();
            this.addProducts1 = new WalmartDesktopAPP.GUI.AddProducts();
            this.viewProducts1 = new WalmartDesktopAPP.GUI.ViewProducts();
            this.viewCustomers1 = new WalmartDesktopAPP.GUI.ViewCustomers();
            this.adminMainPage1 = new WalmartDesktopAPP.GUI.AdminMainPage();
            this.deleteProducts1 = new WalmartDesktopAPP.GUI.DeleteProducts();
            this.changeAdminAccount1 = new WalmartDesktopAPP.GUI.ChangeAdminAccount();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.changeAccountToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1738, 78);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dataToolStripMenuItem.Image")));
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(95, 74);
            this.dataToolStripMenuItem.Text = "Help";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // changeAccountToolStripMenuItem
            // 
            this.changeAccountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.changeAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeAccountToolStripMenuItem.Image")));
            this.changeAccountToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Size = new System.Drawing.Size(201, 74);
            this.changeAccountToolStripMenuItem.Text = "Change Account";
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changeAccountToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(117, 74);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 866);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.SlidePanel);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.CustomerViewButton);
            this.panel2.Controls.Add(this.AddProductButton);
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Controls.Add(this.ViewProductButton);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 860);
            this.panel2.TabIndex = 8;
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.SlidePanel.Location = new System.Drawing.Point(3, 243);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(16, 70);
            this.SlidePanel.TabIndex = 16;
            this.SlidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidePanel_Paint_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(291, 202);
            this.tableLayoutPanel2.TabIndex = 17;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.AdminNametext);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 189);
            this.panel1.TabIndex = 0;
            // 
            // AdminNametext
            // 
            this.AdminNametext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AdminNametext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminNametext.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminNametext.ForeColor = System.Drawing.Color.White;
            this.AdminNametext.Location = new System.Drawing.Point(26, 143);
            this.AdminNametext.Multiline = true;
            this.AdminNametext.Name = "AdminNametext";
            this.AdminNametext.Size = new System.Drawing.Size(256, 46);
            this.AdminNametext.TabIndex = 1;
            this.AdminNametext.Text = "Muhammad Danish";
            this.AdminNametext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CustomerViewButton
            // 
            this.CustomerViewButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CustomerViewButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomerViewButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomerViewButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomerViewButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomerViewButton.FillColor = System.Drawing.Color.White;
            this.CustomerViewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerViewButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CustomerViewButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomerViewButton.Image")));
            this.CustomerViewButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerViewButton.ImageSize = new System.Drawing.Size(40, 40);
            this.CustomerViewButton.Location = new System.Drawing.Point(25, 748);
            this.CustomerViewButton.Name = "CustomerViewButton";
            this.CustomerViewButton.Size = new System.Drawing.Size(303, 68);
            this.CustomerViewButton.TabIndex = 10;
            this.CustomerViewButton.Text = "Manage Customers";
            this.CustomerViewButton.Click += new System.EventHandler(this.CustomerViewButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddProductButton.FillColor = System.Drawing.Color.White;
            this.AddProductButton.FocusedColor = System.Drawing.Color.Transparent;
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AddProductButton.Image = ((System.Drawing.Image)(resources.GetObject("AddProductButton.Image")));
            this.AddProductButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddProductButton.ImageSize = new System.Drawing.Size(60, 55);
            this.AddProductButton.Location = new System.Drawing.Point(22, 344);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.PressedColor = System.Drawing.Color.White;
            this.AddProductButton.Size = new System.Drawing.Size(266, 68);
            this.AddProductButton.TabIndex = 9;
            this.AddProductButton.Text = "Add Products";
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.FillColor = System.Drawing.Color.White;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeButton.ImageSize = new System.Drawing.Size(40, 40);
            this.HomeButton.Location = new System.Drawing.Point(22, 243);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(266, 68);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeButton.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // ViewProductButton
            // 
            this.ViewProductButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewProductButton.FillColor = System.Drawing.Color.White;
            this.ViewProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewProductButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewProductButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewProductButton.Image")));
            this.ViewProductButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewProductButton.ImageSize = new System.Drawing.Size(40, 40);
            this.ViewProductButton.Location = new System.Drawing.Point(22, 445);
            this.ViewProductButton.Name = "ViewProductButton";
            this.ViewProductButton.Size = new System.Drawing.Size(266, 68);
            this.ViewProductButton.TabIndex = 14;
            this.ViewProductButton.Text = "View Products";
            this.ViewProductButton.Click += new System.EventHandler(this.ViewProductButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateButton.FillColor = System.Drawing.Color.White;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UpdateButton.ImageSize = new System.Drawing.Size(40, 40);
            this.UpdateButton.Location = new System.Drawing.Point(22, 546);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(266, 68);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Update Products";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeleteButton.ImageSize = new System.Drawing.Size(40, 40);
            this.DeleteButton.Location = new System.Drawing.Point(25, 647);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(263, 68);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete Products";
            this.DeleteButton.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // updateProducts1
            // 
            this.updateProducts1.BackColor = System.Drawing.Color.White;
            this.updateProducts1.Location = new System.Drawing.Point(306, 87);
            this.updateProducts1.Name = "updateProducts1";
            this.updateProducts1.Size = new System.Drawing.Size(1872, 1189);
            this.updateProducts1.TabIndex = 10;
            this.updateProducts1.Load += new System.EventHandler(this.updateProducts1_Load);
            // 
            // addProducts1
            // 
            this.addProducts1.BackColor = System.Drawing.Color.White;
            this.addProducts1.Location = new System.Drawing.Point(317, 87);
            this.addProducts1.Name = "addProducts1";
            this.addProducts1.Size = new System.Drawing.Size(1851, 1134);
            this.addProducts1.TabIndex = 11;
            // 
            // viewProducts1
            // 
            this.viewProducts1.BackColor = System.Drawing.Color.White;
            this.viewProducts1.Location = new System.Drawing.Point(306, 90);
            this.viewProducts1.Name = "viewProducts1";
            this.viewProducts1.Size = new System.Drawing.Size(1851, 1134);
            this.viewProducts1.TabIndex = 12;
            // 
            // viewCustomers1
            // 
            this.viewCustomers1.BackColor = System.Drawing.Color.White;
            this.viewCustomers1.Location = new System.Drawing.Point(306, 100);
            this.viewCustomers1.Name = "viewCustomers1";
            this.viewCustomers1.Size = new System.Drawing.Size(1842, 1134);
            this.viewCustomers1.TabIndex = 13;
            this.viewCustomers1.Load += new System.EventHandler(this.viewCustomers1_Load);
            // 
            // adminMainPage1
            // 
            this.adminMainPage1.BackColor = System.Drawing.Color.White;
            this.adminMainPage1.Location = new System.Drawing.Point(306, 90);
            this.adminMainPage1.Name = "adminMainPage1";
            this.adminMainPage1.Size = new System.Drawing.Size(1842, 1134);
            this.adminMainPage1.TabIndex = 14;
            // 
            // deleteProducts1
            // 
            this.deleteProducts1.BackColor = System.Drawing.Color.White;
            this.deleteProducts1.Location = new System.Drawing.Point(306, 90);
            this.deleteProducts1.Name = "deleteProducts1";
            this.deleteProducts1.Size = new System.Drawing.Size(1842, 1134);
            this.deleteProducts1.TabIndex = 15;
            this.deleteProducts1.Load += new System.EventHandler(this.deleteProducts1_Load);
            // 
            // changeAdminAccount1
            // 
            this.changeAdminAccount1.BackColor = System.Drawing.Color.White;
            this.changeAdminAccount1.Location = new System.Drawing.Point(306, 90);
            this.changeAdminAccount1.Name = "changeAdminAccount1";
            this.changeAdminAccount1.Size = new System.Drawing.Size(1842, 1128);
            this.changeAdminAccount1.TabIndex = 16;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1734, 944);
            this.Controls.Add(this.changeAdminAccount1);
            this.Controls.Add(this.deleteProducts1);
            this.Controls.Add(this.adminMainPage1);
            this.Controls.Add(this.viewCustomers1);
            this.Controls.Add(this.viewProducts1);
            this.Controls.Add(this.addProducts1);
            this.Controls.Add(this.updateProducts1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem changeAccountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button CustomerViewButton;
        private Guna.UI2.WinForms.Guna2Button AddProductButton;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private Guna.UI2.WinForms.Guna2Button ViewProductButton;
        private Guna.UI2.WinForms.Guna2Button UpdateButton;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private UpdateProducts updateProducts1;
        private AddProducts addProducts1;
        private ViewProducts viewProducts1;
        private ViewCustomers viewCustomers1;
        private AdminMainPage adminMainPage1;
        private DeleteProducts deleteProducts1;
        private Panel SlidePanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox AdminNametext;
        private ChangeAdminAccount changeAdminAccount1;
    }
}