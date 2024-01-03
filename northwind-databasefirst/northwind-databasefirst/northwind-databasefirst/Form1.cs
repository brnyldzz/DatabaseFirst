using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace northwind_databasefirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanicitextBox.Text == "admin" && sifretextBox.Text == "admin123")
            {
                northwindMDI frm = new northwindMDI();
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!!");
            }
            
        }
    }
}
