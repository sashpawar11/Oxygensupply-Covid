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
            this.pass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.hospitalDetailbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hospital Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hosp_name
            // 
            this.hosp_name.Location = new System.Drawing.Point(159, 62);
            this.hosp_name.Name = "hosp_name";
            this.hosp_name.Size = new System.Drawing.Size(239, 22);
            this.hosp_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Number :";
            // 
            // hosp_no
            // 
            this.hosp_no.Location = new System.Drawing.Point(159, 137);
            this.hosp_no.Name = "hosp_no";
            this.hosp_no.Size = new System.Drawing.Size(239, 22);
            this.hosp_no.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address :";
            // 
            // hosp_addr
            // 
            this.hosp_addr.Location = new System.Drawing.Point(159, 212);
            this.hosp_addr.Multiline = true;
            this.hosp_addr.Name = "hosp_addr";
            this.hosp_addr.Size = new System.Drawing.Size(239, 55);
            this.hosp_addr.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Incharge Name :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // inc_name
            // 
            this.inc_name.Location = new System.Drawing.Point(159, 320);
            this.inc_name.Name = "inc_name";
            this.inc_name.Size = new System.Drawing.Size(239, 22);
            this.inc_name.TabIndex = 12;
            // 
            // inc_no
            // 
            this.inc_no.Location = new System.Drawing.Point(159, 395);
            this.inc_no.Name = "inc_no";
            this.inc_no.Size = new System.Drawing.Size(239, 22);
            this.inc_no.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 34);
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
            this.hospitalDetailbox.Location = new System.Drawing.Point(16, 33);
            this.hospitalDetailbox.Name = "hospitalDetailbox";
            this.hospitalDetailbox.Size = new System.Drawing.Size(476, 493);
            this.hospitalDetailbox.TabIndex = 15;
            this.hospitalDetailbox.TabStop = false;
            this.hospitalDetailbox.Text = "Hospital Details";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(223, 54);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(239, 22);
            this.username.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username :";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(223, 128);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(239, 22);
            this.pass.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(507, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 204);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(582, 341);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(435, 87);
            this.registerBtn.TabIndex = 20;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // Reg_Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 543);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hospitalDetailbox);
            this.Name = "Reg_Hospital";
            this.Text = "Reg_Hospital";
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
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registerBtn;
    }
}