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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Berhasil");
            Form1 form1 = new Form1();
            form1.Show();
            return;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
          
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kamu sudah berada di halaman login!");
            return;
        }
    }
}
