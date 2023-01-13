namespace WalmartDesktopAPP.GUI
{
    partial class UpdateProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProducts));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateCatagorytext = new System.Windows.Forms.TextBox();
            this.UpdateQuantityText = new System.Windows.Forms.TextBox();
            this.UpdateProductText = new System.Windows.Forms.TextBox();
            this.UpdatePriceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateDiscountText = new System.Windows.Forms.TextBox();
            this.LoadUpdateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.UpdateGridView, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(500, 233);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(808, 565);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // UpdateGridView
            // 
            this.UpdateGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateGridView.GridColor = System.Drawing.Color.White;
            this.UpdateGridView.Location = new System.Drawing.Point(3, 3);
            this.UpdateGridView.Name = "UpdateGridView";
            this.UpdateGridView.ReadOnly = true;
            this.UpdateGridView.RowHeadersWidth = 62;
            this.UpdateGridView.RowTemplate.Height = 33;
            this.UpdateGridView.Size = new System.Drawing.Size(802, 559);
            this.UpdateGridView.TabIndex = 13;
            this.UpdateGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UpdateGridView_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(38, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 186);
            this.panel1.TabIndex = 19;
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
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(24, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 38);
            this.label7.TabIndex = 2;
            this.label7.Text = "Happy Online Shopping";
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
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(1032, 190);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(273, 40);
            this.UpdateButton.TabIndex = 21;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.21705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.59303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.37597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.81395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpdateCatagorytext, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateQuantityText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpdateProductText, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdatePriceText, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UpdateDiscountText, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(381, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.45763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.54237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 107);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Catagory Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(528, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateCatagorytext
            // 
            this.UpdateCatagorytext.Location = new System.Drawing.Point(184, 3);
            this.UpdateCatagorytext.Name = "UpdateCatagorytext";
            this.UpdateCatagorytext.Size = new System.Drawing.Size(337, 31);
            this.UpdateCatagorytext.TabIndex = 7;
            // 
            // UpdateQuantityText
            // 
            this.UpdateQuantityText.Location = new System.Drawing.Point(184, 36);
            this.UpdateQuantityText.Name = "UpdateQuantityText";
            this.UpdateQuantityText.Size = new System.Drawing.Size(337, 31);
            this.UpdateQuantityText.TabIndex = 7;
            // 
            // UpdateProductText
            // 
            this.UpdateProductText.Location = new System.Drawing.Point(689, 3);
            this.UpdateProductText.Name = "UpdateProductText";
            this.UpdateProductText.Size = new System.Drawing.Size(300, 31);
            this.UpdateProductText.TabIndex = 7;
            // 
            // UpdatePriceText
            // 
            this.UpdatePriceText.Location = new System.Drawing.Point(689, 36);
            this.UpdatePriceText.Name = "UpdatePriceText";
            this.UpdatePriceText.Size = new System.Drawing.Size(300, 31);
            this.UpdatePriceText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(528, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Discount :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateDiscountText
            // 
            this.UpdateDiscountText.Location = new System.Drawing.Point(184, 72);
            this.UpdateDiscountText.Name = "UpdateDiscountText";
            this.UpdateDiscountText.Size = new System.Drawing.Size(337, 31);
            this.UpdateDiscountText.TabIndex = 7;
            // 
            // LoadUpdateButton
            // 
            this.LoadUpdateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoadUpdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadUpdateButton.ForeColor = System.Drawing.Color.White;
            this.LoadUpdateButton.Location = new System.Drawing.Point(500, 187);
            this.LoadUpdateButton.Name = "LoadUpdateButton";
            this.LoadUpdateButton.Size = new System.Drawing.Size(267, 40);
            this.LoadUpdateButton.TabIndex = 33;
            this.LoadUpdateButton.Text = "Load Page";
            this.LoadUpdateButton.UseVisualStyleBackColor = false;
            this.LoadUpdateButton.Click += new System.EventHandler(this.LoadViewButton_Click);
            // 
            // UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LoadUpdateButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpdateProducts";
            this.Size = new System.Drawing.Size(1432, 812);
            this.Load += new System.EventHandler(this.UpdateProducts_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView UpdateGridView;
        private Panel panel1;
        private Label label9;
        private Label label7;
        private PictureBox pictureBox2;
        private Button UpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label5;
        private Label label3;
        private TextBox UpdateCatagorytext;
        private TextBox UpdateQuantityText;
        private TextBox UpdateProductText;
        private TextBox UpdatePriceText;
        private Label label4;
        private Label label6;
        private TextBox UpdateDiscountText;
        private Button LoadUpdateButton;
    }
}
