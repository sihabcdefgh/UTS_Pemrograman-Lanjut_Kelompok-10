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
    public partial class Viewproduct : Form
    {
        public Viewproduct()
        {
            InitializeComponent();
        }

        private void viewproduct_Load(object sender, EventArgs e)
        {

        }

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SEMUA BARANG SUDAH DI TAMPILKAN");
            
        }
    }
}
