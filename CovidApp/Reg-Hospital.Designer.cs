namespace CovidApp
{
    partial class Reg_Hospital
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
            this.label2 = new System.Windows.Forms.Label();
            this.hosp_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hosp_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hosp_addr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inc_name = new System.Windows.Forms.TextBox();
            this.inc_no = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hospitalDetailbox = new System.Windows.Forms.GroupBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.hospitalDetailbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hospital Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hosp_name
            // 
            this.hosp_name.Location = new System.Drawing.Point(119, 50);
            this.hosp_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hosp_name.Name = "hosp_name";
            this.hosp_name.Size = new System.Drawing.Size(180, 20);
            this.hosp_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Number :";
            // 
            // hosp_no
            // 
            this.hosp_no.Location = new System.Drawing.Point(119, 111);
            this.hosp_no.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hosp_no.Name = "hosp_no";
            this.hosp_no.Size = new System.Drawing.Size(180, 20);
            this.hosp_no.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address :";
            // 
            // hosp_addr
            // 
            this.hosp_addr.Location = new System.Drawing.Point(119, 172);
            this.hosp_addr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hosp_addr.Multiline = true;
            this.hosp_addr.Name = "hosp_addr";
            this.hosp_addr.Size = new System.Drawing.Size(180, 45);
            this.hosp_addr.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Incharge Name :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // inc_name
            // 
            this.inc_name.Location = new System.Drawing.Point(119, 260);
            this.inc_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inc_name.Name = "inc_name";
            this.inc_name.Size = new System.Drawing.Size(180, 20);
            this.inc_name.TabIndex = 12;
            // 
            // inc_no
            // 
            this.inc_no.Location = new System.Drawing.Point(119, 321);
            this.inc_no.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inc_no.Name = "inc_no";
            this.inc_no.Size = new System.Drawing.Size(180, 20);
            this.inc_no.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Incharge\r\nContact No. :";
            // 
            // hospitalDetailbox
            // 
            this.hospitalDetailbox.Controls.Add(this.inc_no);
            this.hospitalDetailbox.Controls.Add(this.label6);
            this.hospitalDetailbox.Controls.Add(this.inc_name);
            this.hospitalDetailbox.Controls.Add(this.label5);
            this.hospitalDetailbox.Controls.Add(this.hosp_addr);
            this.hospitalDetailbox.Controls.Add(this.label4);
            this.hospitalDetailbox.Controls.Add(this.hosp_no);
            this.hospitalDetailbox.Controls.Add(this.label3);
            this.hospitalDetailbox.Controls.Add(this.hosp_name);
            this.hospitalDetailbox.Controls.Add(this.label2);
            this.hospitalDetailbox.Location = new System.Drawing.Point(12, 27);
            this.hospitalDetailbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hospitalDetailbox.Name = "hospitalDetailbox";
            this.hospitalDetailbox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hospitalDetailbox.Size = new System.Drawing.Size(357, 401);
            this.hospitalDetailbox.TabIndex = 15;
            this.hospitalDetailbox.TabStop = false;
            this.hospitalDetailbox.Text = "Hospital Details";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(167, 44);
            this.username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(180, 20);
            this.username.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(380, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(408, 166);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(167, 108);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.PromptChar = '-';
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 20);
            this.maskedTextBox1.TabIndex = 19;
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(436, 277);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(326, 71);
            this.registerBtn.TabIndex = 20;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // Reg_Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hospitalDetailbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reg_Hospital";
            this.Text = "Register As Hospital";
            this.hospitalDetailbox.ResumeLayout(false);
            this.hospitalDetailbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hosp_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hosp_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hosp_addr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inc_name;
        private System.Windows.Forms.TextBox inc_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox hospitalDetailbox;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}