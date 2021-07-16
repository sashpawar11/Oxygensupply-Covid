namespace CovidApp
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.hosp_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hosp_box = new System.Windows.Forms.CheckBox();
            this.supp_box = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // hosp_name
            // 
            this.hosp_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hosp_name.Location = new System.Drawing.Point(152, 153);
            this.hosp_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hosp_name.Name = "hosp_name";
            this.hosp_name.Size = new System.Drawing.Size(239, 22);
            this.hosp_name.TabIndex = 8;
            this.hosp_name.TextChanged += new System.EventHandler(this.Hosp_name_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password :";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.Location = new System.Drawing.Point(152, 226);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(239, 22);
            this.password.TabIndex = 11;
            this.password.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(117, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // hosp_box
            // 
            this.hosp_box.AutoSize = true;
            this.hosp_box.Location = new System.Drawing.Point(117, 279);
            this.hosp_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hosp_box.Name = "hosp_box";
            this.hosp_box.Size = new System.Drawing.Size(81, 21);
            this.hosp_box.TabIndex = 13;
            this.hosp_box.Text = "Hospital";
            this.hosp_box.UseVisualStyleBackColor = true;
            this.hosp_box.CheckedChanged += new System.EventHandler(this.Hospital_CheckedChanged);
            // 
            // supp_box
            // 
            this.supp_box.AutoSize = true;
            this.supp_box.Location = new System.Drawing.Point(281, 279);
            this.supp_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supp_box.Name = "supp_box";
            this.supp_box.Size = new System.Drawing.Size(82, 21);
            this.supp_box.TabIndex = 14;
            this.supp_box.Text = "Supplier";
            this.supp_box.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 454);
            this.Controls.Add(this.supp_box);
            this.Controls.Add(this.hosp_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hosp_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hosp_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox hosp_box;
        private System.Windows.Forms.CheckBox supp_box;
    }
}