namespace CovidApp
{
    partial class RegisterScreen
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.regHospitalBtn = new System.Windows.Forms.Button();
            this.regSupplierBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // regHospitalBtn
            // 
            this.regHospitalBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.regHospitalBtn.BackColor = System.Drawing.Color.Orange;
            this.regHospitalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regHospitalBtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regHospitalBtn.ForeColor = System.Drawing.Color.White;
            this.regHospitalBtn.Location = new System.Drawing.Point(766, 271);
            this.regHospitalBtn.Name = "regHospitalBtn";
            this.regHospitalBtn.Size = new System.Drawing.Size(265, 55);
            this.regHospitalBtn.TabIndex = 1;
            this.regHospitalBtn.Text = "AS HOSPITAL";
            this.regHospitalBtn.UseVisualStyleBackColor = false;
            this.regHospitalBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // regSupplierBtn
            // 
            this.regSupplierBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.regSupplierBtn.BackColor = System.Drawing.Color.Orange;
            this.regSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regSupplierBtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regSupplierBtn.ForeColor = System.Drawing.Color.White;
            this.regSupplierBtn.Location = new System.Drawing.Point(766, 386);
            this.regSupplierBtn.Name = "regSupplierBtn";
            this.regSupplierBtn.Size = new System.Drawing.Size(265, 55);
            this.regSupplierBtn.TabIndex = 2;
            this.regSupplierBtn.Text = "AS OXYGEN SUPPLIER";
            this.regSupplierBtn.UseVisualStyleBackColor = false;
            this.regSupplierBtn.Click += new System.EventHandler(this.regSupplierBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(757, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registeration";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(988, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 36);
            this.button4.TabIndex = 22;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(1040, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidApp.Properties.Resources.loginui_curve;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 634);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regSupplierBtn);
            this.Controls.Add(this.regHospitalBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register/Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button regHospitalBtn;
        private System.Windows.Forms.Button regSupplierBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}

