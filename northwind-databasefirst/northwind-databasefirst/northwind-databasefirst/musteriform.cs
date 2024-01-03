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
    public partial class musteriform : Form
    {
        public musteriform()
        {
            InitializeComponent();
        }

        NorthwindEntities ne = new NorthwindEntities();

        private void addbutton_Click(object sender, EventArgs e)
        {
            Customers yenimusteri = new Customers();

            yenimusteri.CustomerID = idtextBox.Text;
            yenimusteri.CompanyName = comnametextBox.Text;
            yenimusteri.ContactName = connametextBox.Text;
            yenimusteri.ContactName = contitletextBox.Text;
            yenimusteri.Address = addresstextBox.Text;
            yenimusteri.City = citytextBox.Text;
            yenimusteri.Region = regiontextBox.Text;
            yenimusteri.PostalCode = postalcodetextBox.Text;
            yenimusteri.Country = countrytextBox.Text;
            yenimusteri.Phone = phonetextBox.Text;
            yenimusteri.Fax = faxtextBox.Text;

            ne.Customers.Add(yenimusteri);

            if (ne.SaveChanges()  == 1)
            {
                MessageBox.Show("Eklendi.");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string id = idtextBox.Text.ToString();
            Customers silinecek = ne.Customers.Where(x => x.CustomerID == id).FirstOrDefault();

            ne.Customers.Remove(silinecek);

            if(ne.SaveChanges() == 1)
            {
                MessageBox.Show("Silindi.");
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string id = idtextBox.Text.ToString();
            Customers guncellenecek = ne.Customers.Where(x => x.CustomerID == id).FirstOrDefault();

            guncellenecek.CompanyName = comnametextBox.Text;
            guncellenecek.ContactName = connametextBox.Text;
            guncellenecek.ContactName = contitletextBox.Text;
            guncellenecek.Address = addresstextBox.Text;
            guncellenecek.City = citytextBox.Text;
            guncellenecek.Region = regiontextBox.Text;
            guncellenecek.PostalCode = postalcodetextBox.Text;
            guncellenecek.Country = countrytextBox.Text;
            guncellenecek.Phone = phonetextBox.Text;
            guncellenecek.Fax = faxtextBox.Text;

            if(ne.SaveChanges() == 1)
            {
                MessageBox.Show("Güncellendi.");
            }
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ne.Customers.ToList();
        }
    }
}
