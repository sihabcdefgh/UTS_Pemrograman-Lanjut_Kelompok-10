using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indiemart
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();
            Close();
            return;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrasi Berhasil, anda akan di arahkan ke Menu utama !");

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
