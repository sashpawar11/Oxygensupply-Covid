namespace CovidApp
{
    partial class Form1
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
            this.username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hosp_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hosp_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hosp_addr = new System.Windows.Forms.TextBox();
            this.inc_name = new System.Windows.Forms.TextBox();
            this.hospitalDetailbox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.hospitalDetailbox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(99, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username :";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial", 9F);
            this.username.ForeColor = System.Drawing.Color.Orange;
            this.username.Location = new System.Drawing.Point(223, 54);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(239, 25);
            this.username.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(99, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(501, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(544, 204);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial", 9F);
            this.password.ForeColor = System.Drawing.Color.Orange;
            this.password.Location = new System.Drawing.Point(223, 126);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PromptChar = '-';
            this.password.Size = new System.Drawing.Size(239, 25);
            this.password.TabIndex = 20;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Black;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(501, 569);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(544, 59);
            this.registerBtn.TabIndex = 23;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(91, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name :";
            // 
            // hosp_name
            // 
            this.hosp_name.Font = new System.Drawing.Font("Arial", 9F);
            this.hosp_name.ForeColor = System.Drawing.Color.Orange;
            this.hosp_name.Location = new System.Drawing.Point(162, 69);
            this.hosp_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hosp_name.Name = "hosp_name";
            this.hosp_name.Size = new System.Drawing.Size(239, 25);
            this.hosp_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(26, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Number :";
            // 
            // hosp_no
            // 
            this.hosp_no.Font = new System.Drawing.Font("Arial", 9F);
            this.hosp_no.ForeColor = System.Drawing.Color.Orange;
            this.hosp_no.Location = new System.Drawing.Point(162, 127);
            this.hosp_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hosp_no.Name = "hosp_no";
            this.hosp_no.Size = new System.Drawing.Size(239, 25);
            this.hosp_no.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(75, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address :";
            // 
            // hosp_addr
            // 
            this.hosp_addr.Font = new System.Drawing.Font("Arial", 9F);
            this.hosp_addr.ForeColor = System.Drawing.Color.Orange;
            this.hosp_addr.Location = new System.Drawing.Point(161, 179);
            this.hosp_addr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hosp_addr.Multiline = true;
            this.hosp_addr.Name = "hosp_addr";
            this.hosp_addr.Size = new System.Drawing.Size(239, 54);
            this.hosp_addr.TabIndex = 10;
            // 
            // inc_name
            // 
            this.inc_name.Font = new System.Drawing.Font("Arial", 9F);
            this.inc_name.ForeColor = System.Drawing.Color.Orange;
            this.inc_name.Location = new System.Drawing.Point(161, 321);
            this.inc_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inc_name.Name = "inc_name";
            this.inc_name.Size = new System.Drawing.Size(239, 25);
            this.inc_name.TabIndex = 12;
            // 
            // hospitalDetailbox
            // 
            this.hospitalDetailbox.BackColor = System.Drawing.Color.White;
            this.hospitalDetailbox.Controls.Add(this.pictureBox1);
            this.hospitalDetailbox.Controls.Add(this.comboBox1);
            this.hospitalDetailbox.Controls.Add(this.label8);
            this.hospitalDetailbox.Controls.Add(this.button1);
            this.hospitalDetailbox.Controls.Add(this.inc_name);
            this.hospitalDetailbox.Controls.Add(this.label5);
            this.hospitalDetailbox.Controls.Add(this.hosp_addr);
            this.hospitalDetailbox.Controls.Add(this.label4);
            this.hospitalDetailbox.Controls.Add(this.hosp_no);
            this.hospitalDetailbox.Controls.Add(this.label3);
            this.hospitalDetailbox.Controls.Add(this.hosp_name);
            this.hospitalDetailbox.Controls.Add(this.label2);
            this.hospitalDetailbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hospitalDetailbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalDetailbox.ForeColor = System.Drawing.Color.Orange;
            this.hospitalDetailbox.Location = new System.Drawing.Point(19, 146);
            this.hospitalDetailbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hospitalDetailbox.Name = "hospitalDetailbox";
            this.hospitalDetailbox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hospitalDetailbox.Size = new System.Drawing.Size(476, 482);
            this.hospitalDetailbox.TabIndex = 21;
            this.hospitalDetailbox.TabStop = false;
            this.hospitalDetailbox.Text = "Oxygen Supplier Details";
            this.hospitalDetailbox.Enter += new System.EventHandler(this.hospitalDetailbox_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.comboBox1.ForeColor = System.Drawing.Color.Orange;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttarakhand",
            "Uttar Pradesh",
            "West Bengal",
            "Andaman and Nicobar Islands",
            "Chandigarh",
            "Dadra and Nagar Haveli",
            "Daman and Diu",
            "Delhi",
            "Lakshadweep",
            "Puducherry"});
            this.comboBox1.Location = new System.Drawing.Point(162, 266);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 25);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(95, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "State :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(27, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Company Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-6, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 110);
            this.panel1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(606, 40);
            this.label9.TabIndex = 17;
            this.label9.Text = "OXYGEN SUPPLIER REGISTRATION";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Ivory;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(969, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 36);
            this.button4.TabIndex = 26;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(1021, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 36);
            this.button2.TabIndex = 25;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(158, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "LOCATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CovidApp.Properties.Resources.regicon;
            this.pictureBox2.Location = new System.Drawing.Point(724, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CovidApp.Properties.Resources.location;
            this.pictureBox1.Location = new System.Drawing.Point(85, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 666);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hospitalDetailbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oxygen Supplier Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.hospitalDetailbox.ResumeLayout(false);
            this.hospitalDetailbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hosp_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hosp_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hosp_addr;
        private System.Windows.Forms.TextBox inc_name;
        private System.Windows.Forms.GroupBox hospitalDetailbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}