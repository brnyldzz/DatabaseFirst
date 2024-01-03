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
    public partial class calisanform : Form
    {
        public calisanform()
        {
            InitializeComponent();
        }

        NorthwindEntities ne = new NorthwindEntities();

        private void calisanform_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Employees yenicalisan = new Employees();

            yenicalisan.LastName = lastnametextBox.Text;
            yenicalisan.FirstName = firstnametextBox.Text;
            yenicalisan.Address = addresstextBox.Text;
            yenicalisan.City = citytextBox.Text;
            yenicalisan.Region = regiontextBox.Text;
            yenicalisan.PostalCode = postalcodetextBox.Text;
            yenicalisan.Country = countrytextBox.Text;
            yenicalisan.HomePhone = phonetextBox.Text;

            ne.Employees.Add(yenicalisan);

            if (ne.SaveChanges() == 1)
            {
                MessageBox.Show("Eklendi.");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtextBox.Text);
            Employees silinecek = ne.Employees.Where(x => x.EmployeeID == id).FirstOrDefault();

            ne.Employees.Remove(silinecek);

            if (ne.SaveChanges() == 1)
            {
                MessageBox.Show("Silindi.");
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtextBox.Text);
            Employees guncellenecek = ne.Employees.Where(x => x.EmployeeID == id).FirstOrDefault();

            guncellenecek.LastName = lastnametextBox.Text;
            guncellenecek.FirstName = firstnametextBox.Text;
            guncellenecek.Address = addresstextBox.Text;
            guncellenecek.City = citytextBox.Text;
            guncellenecek.Region = regiontextBox.Text;
            guncellenecek.PostalCode = postalcodetextBox.Text;
            guncellenecek.Country = countrytextBox.Text;
            guncellenecek.HomePhone = phonetextBox.Text;

            if (ne.SaveChanges() == 1)
            {
                MessageBox.Show("Güncellendi.");
            }
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ne.Employees.ToList();
        }
    }
}
