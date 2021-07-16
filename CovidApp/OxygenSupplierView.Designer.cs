
namespace CovidApp
{
    partial class OxygenSupplierView
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
            this.oxy_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oxy_stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.personalDetailsView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.personalDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // oxy_price
            // 
            this.oxy_price.Location = new System.Drawing.Point(78, 218);
            this.oxy_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oxy_price.Name = "oxy_price";
            this.oxy_price.Size = new System.Drawing.Size(239, 22);
            this.oxy_price.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // oxy_stock
            // 
            this.oxy_stock.Location = new System.Drawing.Point(78, 287);
            this.oxy_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oxy_stock.Name = "oxy_stock";
            this.oxy_stock.Size = new System.Drawing.Size(239, 22);
            this.oxy_stock.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Stock :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Available",
            "Unavailable",
            "Out of Stock"});
            this.comboBox1.Location = new System.Drawing.Point(78, 355);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // personalDetailsView
            // 
            this.personalDetailsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personalDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalDetailsView.Location = new System.Drawing.Point(333, 39);
            this.personalDetailsView.Name = "personalDetailsView";
            this.personalDetailsView.RowHeadersWidth = 51;
            this.personalDetailsView.RowTemplate.Height = 24;
            this.personalDetailsView.Size = new System.Drawing.Size(821, 497);
            this.personalDetailsView.TabIndex = 16;
            this.personalDetailsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 396);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Your Details";
            // 
            // OxygenSupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 554);
            this.Controls.Add(this.personalDetailsView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oxy_stock);
            this.Controls.Add(this.oxy_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OxygenSupplierView";
            this.Text = "OxygenSupplierView";
            this.Load += new System.EventHandler(this.OxygenSupplierView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oxy_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oxy_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView personalDetailsView;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}