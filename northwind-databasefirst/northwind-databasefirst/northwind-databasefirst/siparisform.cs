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
    public partial class siparisform : Form
    {
        public siparisform()
        {
            InitializeComponent();
        }

        NorthwindEntities ne = new NorthwindEntities();

        private void addbutton_Click(object sender, EventArgs e)
        {
            Orders yenisiparis = new Orders();

            yenisiparis.CustomerID = customertextBox.Text;
            yenisiparis.EmployeeID = int.Parse(employeetextBox.Text);
            yenisiparis.ShipVia = int.Parse(viatextBox.Text);
            yenisiparis.ShipName = nametextBox.Text;
            yenisiparis.ShipAddress = addresstextBox.Text;
            yenisiparis.ShipCity = citytextBox.Text;

            ne.Orders.Add(yenisiparis);

            if (ne.SaveChanges() == 1)
            {
                MessageBox.Show("Eklendi.");
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtextBox.Text);
            Orders silinecek = ne.Orders.Where(x => x.OrderID == id).FirstOrDefault();

            ne.Orders.Remove(silinecek);

            if(ne.SaveChanges() == 1)
            {
                MessageBox.Show("Silindi.");
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtextBox.Text);
            Orders guncellenecek = ne.Orders.Where(x => x.OrderID == id).FirstOrDefault();

            guncellenecek.CustomerID = customertextBox.Text;
            guncellenecek.EmployeeID = int.Parse(employeetextBox.Text);
            guncellenecek.ShipVia = int.Parse(viatextBox.Text);
            guncellenecek.ShipName = nametextBox.Text;
            guncellenecek.ShipAddress = addresstextBox.Text;
            guncellenecek.ShipCity = citytextBox.Text;

            if (ne.SaveChanges() == 1)
            {
                MessageBox.Show("Güncellendi.");
            }
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ne.Orders.ToList();
        }
    }
}
