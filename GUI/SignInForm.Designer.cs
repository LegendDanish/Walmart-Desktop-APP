namespace WalmartDesktopAPP.GUI
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visibleeyebutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.invisibleeyebtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserPasswordTex1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.UserNameTex1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.lblSignUP = new System.Windows.Forms.LinkLabel();
            this.signinButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.ExitButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(451, 634);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(177, 27);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Create New Account";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1097, 778);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.signUp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.visibleeyebutton);
            this.panel1.Controls.Add(this.invisibleeyebtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.UserPasswordTex1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.UserNameTex1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.MessageText);
            this.panel1.Controls.Add(this.lblSignUP);
            this.panel1.Controls.Add(this.signinButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 618);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // visibleeyebutton
            // 
            this.visibleeyebutton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.visibleeyebutton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.visibleeyebutton.Image = ((System.Drawing.Image)(resources.GetObject("visibleeyebutton.Image")));
            this.visibleeyebutton.ImageOffset = new System.Drawing.Point(0, 0);
            this.visibleeyebutton.ImageRotate = 0F;
            this.visibleeyebutton.Location = new System.Drawing.Point(770, 300);
            this.visibleeyebutton.Name = "visibleeyebutton";
            this.visibleeyebutton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.visibleeyebutton.Size = new System.Drawing.Size(62, 45);
            this.visibleeyebutton.TabIndex = 31;
            this.visibleeyebutton.Click += new System.EventHandler(this.visibleeyebutton_Click);
            // 
            // invisibleeyebtn
            // 
            this.invisibleeyebtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.invisibleeyebtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.invisibleeyebtn.Image = ((System.Drawing.Image)(resources.GetObject("invisibleeyebtn.Image")));
            this.invisibleeyebtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.invisibleeyebtn.ImageRotate = 0F;
            this.invisibleeyebtn.Location = new System.Drawing.Point(770, 300);
            this.invisibleeyebtn.Name = "invisibleeyebtn";
            this.invisibleeyebtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.invisibleeyebtn.Size = new System.Drawing.Size(62, 45);
            this.invisibleeyebtn.TabIndex = 31;
            this.invisibleeyebtn.Click += new System.EventHandler(this.invisibleeyebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // UserPasswordTex1
            // 
            this.UserPasswordTex1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPasswordTex1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordTex1.Location = new System.Drawing.Point(375, 307);
            this.UserPasswordTex1.Multiline = true;
            this.UserPasswordTex1.Name = "UserPasswordTex1";
            this.UserPasswordTex1.PasswordChar = '*';
            this.UserPasswordTex1.PlaceholderText = "Password";
            this.UserPasswordTex1.Size = new System.Drawing.Size(457, 42);
            this.UserPasswordTex1.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(332, 351);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 1);
            this.panel5.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(332, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Location = new System.Drawing.Point(332, 279);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(500, 1);
            this.panel8.TabIndex = 26;
            // 
            // UserNameTex1
            // 
            this.UserNameTex1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameTex1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTex1.Location = new System.Drawing.Point(378, 237);
            this.UserNameTex1.Multiline = true;
            this.UserNameTex1.Name = "UserNameTex1";
            this.UserNameTex1.PlaceholderText = "User Name";
            this.UserNameTex1.Size = new System.Drawing.Size(454, 31);
            this.UserNameTex1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(430, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 1);
            this.panel2.TabIndex = 24;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(451, 634);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(177, 27);
            this.guna2HtmlLabel2.TabIndex = 23;
            this.guna2HtmlLabel2.Text = "Create New Account";
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageText.ForeColor = System.Drawing.Color.Red;
            this.MessageText.Location = new System.Drawing.Point(430, 364);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(309, 24);
            this.MessageText.TabIndex = 20;
            // 
            // lblSignUP
            // 
            this.lblSignUP.AutoSize = true;
            this.lblSignUP.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSignUP.Location = new System.Drawing.Point(634, 634);
            this.lblSignUP.Name = "lblSignUP";
            this.lblSignUP.Size = new System.Drawing.Size(75, 25);
            this.lblSignUP.TabIndex = 19;
            this.lblSignUP.TabStop = true;
            this.lblSignUP.Text = "Sign Up";
            this.lblSignUP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignUP_LinkClicked);
            // 
            // signinButton
            // 
            this.signinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signinButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signinButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signinButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signinButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signinButton.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.signinButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signinButton.ForeColor = System.Drawing.Color.White;
            this.signinButton.Location = new System.Drawing.Point(430, 401);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(296, 42);
            this.signinButton.TabIndex = 16;
            this.signinButton.Text = "Sign In";
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButton.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(430, 467);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(296, 42);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(430, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 1);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(422, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(413, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Create New Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.LinkColor = System.Drawing.Color.DodgerBlue;
            this.signUp.Location = new System.Drawing.Point(625, 581);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(75, 25);
            this.signUp.TabIndex = 33;
            this.signUp.TabStop = true;
            this.signUp.Text = "Sign Up";
            this.signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUp_LinkClicked);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignInForm_FormClosing);
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private TextBox MessageText;
        private LinkLabel lblSignUP;
        private Guna.UI2.WinForms.Guna2TileButton signinButton;
        private Guna.UI2.WinForms.Guna2TileButton ExitButton;
        private Panel panel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox UserPasswordTex1;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Panel panel8;
        private TextBox UserNameTex1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton visibleeyebutton;
        private Guna.UI2.WinForms.Guna2ImageButton invisibleeyebtn;
        private Label label1;
        private LinkLabel signUp;
    }
}