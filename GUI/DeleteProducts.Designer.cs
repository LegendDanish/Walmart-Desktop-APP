namespace WalmartDesktopAPP.GUI
{
    partial class DeleteProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SearchDelBox = new System.Windows.Forms.TextBox();
            this.DeleteGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ProductDeletebutton = new System.Windows.Forms.Button();
            this.LoadUpdateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(1087, 110);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(247, 40);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.64479F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.35521F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SearchDelBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(543, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(769, 63);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(676, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // SearchDelBox
            // 
            this.SearchDelBox.Location = new System.Drawing.Point(3, 3);
            this.SearchDelBox.Multiline = true;
            this.SearchDelBox.Name = "SearchDelBox";
            this.SearchDelBox.PlaceholderText = "I am Looking For Catagory...";
            this.SearchDelBox.Size = new System.Drawing.Size(663, 57);
            this.SearchDelBox.TabIndex = 0;
            // 
            // DeleteGrid
            // 
            this.DeleteGrid.AllowUserToAddRows = false;
            this.DeleteGrid.AllowUserToDeleteRows = false;
            this.DeleteGrid.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteGrid.GridColor = System.Drawing.Color.White;
            this.DeleteGrid.Location = new System.Drawing.Point(520, 157);
            this.DeleteGrid.Name = "DeleteGrid";
            this.DeleteGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DeleteGrid.RowHeadersWidth = 62;
            this.DeleteGrid.RowTemplate.Height = 33;
            this.DeleteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeleteGrid.Size = new System.Drawing.Size(814, 572);
            this.DeleteGrid.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(92, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 186);
            this.panel1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(27, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 38);
            this.label9.TabIndex = 2;
            this.label9.Text = "Supercenter";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Happy Online Shopping";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ProductDeletebutton
            // 
            this.ProductDeletebutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProductDeletebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductDeletebutton.ForeColor = System.Drawing.Color.White;
            this.ProductDeletebutton.Location = new System.Drawing.Point(807, 735);
            this.ProductDeletebutton.Name = "ProductDeletebutton";
            this.ProductDeletebutton.Size = new System.Drawing.Size(247, 40);
            this.ProductDeletebutton.TabIndex = 23;
            this.ProductDeletebutton.Text = "Delete";
            this.ProductDeletebutton.UseVisualStyleBackColor = false;
            this.ProductDeletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // LoadUpdateButton
            // 
            this.LoadUpdateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoadUpdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadUpdateButton.ForeColor = System.Drawing.Color.White;
            this.LoadUpdateButton.Location = new System.Drawing.Point(520, 111);
            this.LoadUpdateButton.Name = "LoadUpdateButton";
            this.LoadUpdateButton.Size = new System.Drawing.Size(267, 40);
            this.LoadUpdateButton.TabIndex = 34;
            this.LoadUpdateButton.Text = "Load Page";
            this.LoadUpdateButton.UseVisualStyleBackColor = false;
            this.LoadUpdateButton.Click += new System.EventHandler(this.LoadUpdateButton_Click);
            // 
            // DeleteProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LoadUpdateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.DeleteGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductDeletebutton);
            this.Name = "DeleteProducts";
            this.Size = new System.Drawing.Size(1432, 812);
            this.Load += new System.EventHandler(this.DeleteProducts_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button searchButton;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox3;
        private TextBox SearchDelBox;
        private DataGridView DeleteGrid;
        private Panel panel1;
        private Label label9;
        private Label label2;
        private PictureBox pictureBox2;
        private Button ProductDeletebutton;
        private Button LoadUpdateButton;
    }
}
