using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidApp
{
   
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void vaccineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg_Hospital rh = new Reg_Hospital();
            rh.Closed += (s, args) => this.Close();
            rh.Show();
            

        }

        private void regSupplierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ro = new Form1();
            ro.Closed += (s, args) => this.Close();
            ro.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();

        }
    }
}
