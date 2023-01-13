namespace WalmartDesktopAPP.GUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SlidePanel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BuyButton = new Guna.UI2.WinForms.Guna2Button();
            this.cutomerHomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.CurrentOfferButton = new Guna.UI2.WinForms.Guna2Button();
            this.GenerateBillButton = new Guna.UI2.WinForms.Guna2Button();
            this.customersViewProductButton = new Guna.UI2.WinForms.Guna2Button();
            this.customersCuurrentOffers1 = new WalmartDesktopAPP.GUI.CustomersCuurrentOffers();
            this.customerHomeForm1 = new WalmartDesktopAPP.GUI.customerHomeForm();
            this.viewProducts1 = new WalmartDesktopAPP.GUI.ViewProducts();
            this.generateBill1 = new WalmartDesktopAPP.GUI.GenerateBill();
            this.buyProduct1 = new WalmartDesktopAPP.GUI.BuyProduct();
            this.changeAdminAccount1 = new WalmartDesktopAPP.GUI.ChangeAdminAccount();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1736, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.changeAccountToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1736, 78);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip1";
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
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutUsToolStripMenuItem.Image")));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(149, 74);
            this.aboutUsToolStripMenuItem.Text = "About Us !";
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
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.contactUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactUsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.contactUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactUsToolStripMenuItem.Image")));
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(150, 74);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-1, 82);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 865);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.SlidePanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.BuyButton);
            this.panel2.Controls.Add(this.cutomerHomeButton);
            this.panel2.Controls.Add(this.CurrentOfferButton);
            this.panel2.Controls.Add(this.GenerateBillButton);
            this.panel2.Controls.Add(this.customersViewProductButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 859);
            this.panel2.TabIndex = 9;
            // 
            // SlidePanel2
            // 
            this.SlidePanel2.BackColor = System.Drawing.Color.DarkOrange;
            this.SlidePanel2.Location = new System.Drawing.Point(0, 250);
            this.SlidePanel2.Name = "SlidePanel2";
            this.SlidePanel2.Size = new System.Drawing.Size(16, 70);
            this.SlidePanel2.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(-3, -3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 197);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.CustomerNameText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 191);
            this.panel1.TabIndex = 0;
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CustomerNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNameText.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameText.ForeColor = System.Drawing.Color.White;
            this.CustomerNameText.Location = new System.Drawing.Point(28, 143);
            this.CustomerNameText.Multiline = true;
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.Size = new System.Drawing.Size(256, 46);
            this.CustomerNameText.TabIndex = 1;
            this.CustomerNameText.Text = "Muhammad Danish";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BuyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BuyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BuyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BuyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BuyButton.FillColor = System.Drawing.Color.White;
            this.BuyButton.FocusedColor = System.Drawing.Color.Transparent;
            this.BuyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BuyButton.Image = ((System.Drawing.Image)(resources.GetObject("BuyButton.Image")));
            this.BuyButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BuyButton.ImageSize = new System.Drawing.Size(60, 55);
            this.BuyButton.Location = new System.Drawing.Point(31, 363);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.PressedColor = System.Drawing.Color.White;
            this.BuyButton.Size = new System.Drawing.Size(266, 68);
            this.BuyButton.TabIndex = 9;
            this.BuyButton.Text = "Buy Products";
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // cutomerHomeButton
            // 
            this.cutomerHomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cutomerHomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cutomerHomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cutomerHomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cutomerHomeButton.FillColor = System.Drawing.Color.White;
            this.cutomerHomeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cutomerHomeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cutomerHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("cutomerHomeButton.Image")));
            this.cutomerHomeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cutomerHomeButton.ImageSize = new System.Drawing.Size(40, 40);
            this.cutomerHomeButton.Location = new System.Drawing.Point(28, 250);
            this.cutomerHomeButton.Name = "cutomerHomeButton";
            this.cutomerHomeButton.Size = new System.Drawing.Size(266, 68);
            this.cutomerHomeButton.TabIndex = 8;
            this.cutomerHomeButton.Text = "Home";
            this.cutomerHomeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cutomerHomeButton.Click += new System.EventHandler(this.cutomerHomeButton_Click);
            // 
            // CurrentOfferButton
            // 
            this.CurrentOfferButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CurrentOfferButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CurrentOfferButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CurrentOfferButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CurrentOfferButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CurrentOfferButton.FillColor = System.Drawing.Color.White;
            this.CurrentOfferButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentOfferButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CurrentOfferButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrentOfferButton.Image")));
            this.CurrentOfferButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CurrentOfferButton.ImageSize = new System.Drawing.Size(40, 40);
            this.CurrentOfferButton.Location = new System.Drawing.Point(31, 584);
            this.CurrentOfferButton.Name = "CurrentOfferButton";
            this.CurrentOfferButton.Size = new System.Drawing.Size(266, 68);
            this.CurrentOfferButton.TabIndex = 14;
            this.CurrentOfferButton.Text = "Current Offers";
            this.CurrentOfferButton.Click += new System.EventHandler(this.CurrentOfferButton_Click);
            // 
            // GenerateBillButton
            // 
            this.GenerateBillButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GenerateBillButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerateBillButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerateBillButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateBillButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerateBillButton.FillColor = System.Drawing.Color.White;
            this.GenerateBillButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateBillButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.GenerateBillButton.Image = ((System.Drawing.Image)(resources.GetObject("GenerateBillButton.Image")));
            this.GenerateBillButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GenerateBillButton.ImageSize = new System.Drawing.Size(40, 40);
            this.GenerateBillButton.Location = new System.Drawing.Point(31, 690);
            this.GenerateBillButton.Name = "GenerateBillButton";
            this.GenerateBillButton.Size = new System.Drawing.Size(266, 68);
            this.GenerateBillButton.TabIndex = 14;
            this.GenerateBillButton.Text = "Generate Bill";
            this.GenerateBillButton.Click += new System.EventHandler(this.GenerateBillButton_Click);
            // 
            // customersViewProductButton
            // 
            this.customersViewProductButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.customersViewProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customersViewProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customersViewProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customersViewProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customersViewProductButton.FillColor = System.Drawing.Color.White;
            this.customersViewProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customersViewProductButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.customersViewProductButton.Image = ((System.Drawing.Image)(resources.GetObject("customersViewProductButton.Image")));
            this.customersViewProductButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customersViewProductButton.ImageSize = new System.Drawing.Size(40, 40);
            this.customersViewProductButton.Location = new System.Drawing.Point(31, 475);
            this.customersViewProductButton.Name = "customersViewProductButton";
            this.customersViewProductButton.Size = new System.Drawing.Size(266, 68);
            this.customersViewProductButton.TabIndex = 14;
            this.customersViewProductButton.Text = "View Products";
            this.customersViewProductButton.Click += new System.EventHandler(this.customersViewProductButton_Click);
            // 
            // customersCuurrentOffers1
            // 
            this.customersCuurrentOffers1.BackColor = System.Drawing.Color.White;
            this.customersCuurrentOffers1.Location = new System.Drawing.Point(305, 90);
            this.customersCuurrentOffers1.Name = "customersCuurrentOffers1";
            this.customersCuurrentOffers1.Size = new System.Drawing.Size(2148, 1242);
            this.customersCuurrentOffers1.TabIndex = 2;
            // 
            // customerHomeForm1
            // 
            this.customerHomeForm1.BackColor = System.Drawing.Color.White;
            this.customerHomeForm1.Location = new System.Drawing.Point(302, 85);
            this.customerHomeForm1.Name = "customerHomeForm1";
            this.customerHomeForm1.Size = new System.Drawing.Size(1846, 1133);
            this.customerHomeForm1.TabIndex = 3;
            // 
            // viewProducts1
            // 
            this.viewProducts1.BackColor = System.Drawing.Color.White;
            this.viewProducts1.Location = new System.Drawing.Point(305, 90);
            this.viewProducts1.Name = "viewProducts1";
            this.viewProducts1.Size = new System.Drawing.Size(2148, 1218);
            this.viewProducts1.TabIndex = 18;
            // 
            // generateBill1
            // 
            this.generateBill1.BackColor = System.Drawing.Color.White;
            this.generateBill1.Location = new System.Drawing.Point(316, 90);
            this.generateBill1.Name = "generateBill1";
            this.generateBill1.Size = new System.Drawing.Size(2148, 1218);
            this.generateBill1.TabIndex = 18;
            // 
            // buyProduct1
            // 
            this.buyProduct1.BackColor = System.Drawing.Color.White;
            this.buyProduct1.Location = new System.Drawing.Point(305, 90);
            this.buyProduct1.Name = "buyProduct1";
            this.buyProduct1.Size = new System.Drawing.Size(2148, 1218);
            this.buyProduct1.TabIndex = 18;
            this.buyProduct1.Load += new System.EventHandler(this.buyProduct1_Load);
            // 
            // changeAdminAccount1
            // 
            this.changeAdminAccount1.BackColor = System.Drawing.Color.White;
            this.changeAdminAccount1.Location = new System.Drawing.Point(305, 85);
            this.changeAdminAccount1.Name = "changeAdminAccount1";
            this.changeAdminAccount1.Size = new System.Drawing.Size(2148, 1218);
            this.changeAdminAccount1.TabIndex = 19;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1734, 944);
            this.Controls.Add(this.changeAdminAccount1);
            this.Controls.Add(this.buyProduct1);
            this.Controls.Add(this.generateBill1);
            this.Controls.Add(this.viewProducts1);
            this.Controls.Add(this.customerHomeForm1);
            this.Controls.Add(this.customersCuurrentOffers1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem changeAccountToolStripMenuItem;
        private ToolStripMenuItem contactUsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel SlidePanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private TextBox CustomerNameText;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BuyButton;
        private Guna.UI2.WinForms.Guna2Button cutomerHomeButton;
        private Guna.UI2.WinForms.Guna2Button GenerateBillButton;
        private Guna.UI2.WinForms.Guna2Button customersViewProductButton;
        private Guna.UI2.WinForms.Guna2Button CurrentOfferButton;
        private CustomersCuurrentOffers customersCuurrentOffers1;
        private customerHomeForm customerHomeForm1;
        private ViewProducts viewProducts1;
        private GenerateBill generateBill1;
        private BuyProduct buyProduct1;
        private ChangeAdminAccount changeAdminAccount1;
    }
}