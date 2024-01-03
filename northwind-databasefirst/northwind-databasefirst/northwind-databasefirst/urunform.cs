using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace northwind_databasefirst
{
    public partial class urunform : Form
    {
        public urunform()
        {
            InitializeComponent();
        }
        
        NorthwindEntities ne = new NorthwindEntities();

        private void addbutton_Click(object sender, EventArgs e)
        {
            Products yeniurun = new Products();

            yeniurun.ProductName = productnametextBox.Text;
            yeniurun.SupplierID = int.Parse(suppliertextBox.Text);
            yeniurun.CategoryID = int.Parse(categorytextBox.Text);
            yeniurun.QuantityPerUnit = quantitytextBox.Text;
            yeniurun.UnitPrice = decimal.Parse(pricetextBox.Text);
            yeniurun.UnitsInStock = Int16.Parse(stocktextBox.Text);
            yeniurun.UnitsOnOrder = Int16.Parse(ordertextBox.Text);
            yeniurun.ReorderLevel = Int16.Parse(reordertextBox.Text);

            ne.Products.Add(yeniurun);

            if (ne.SaveChanges() == 1)
            {
                MessageBox.Show("Eklendi.");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtextBox.Text);
            Products silinecek = ne.Products.Where(x => x.ProductID == id).FirstOrDefault();

            ne.Products.Remove(silinecek);

            if (ne.SaveChanges() == 1)
            {
                MessageBox.Show("Silindi.");
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtextBox.Text);
            Products guncellenecek = ne.Products.Where(x => x.ProductID == id).FirstOrDefault();

            guncellenecek.ProductName = productnametextBox.Text;
            guncellenecek.SupplierID = int.Parse(suppliertextBox.Text);
            guncellenecek.CategoryID = int.Parse(categorytextBox.Text);
            guncellenecek.QuantityPerUnit = quantitytextBox.Text;
            guncellenecek.UnitPrice = decimal.Parse(pricetextBox.Text);
            guncellenecek.UnitsInStock = Int16.Parse(stocktextBox.Text);
            guncellenecek.UnitsOnOrder = Int16.Parse(ordertextBox.Text);
            guncellenecek.ReorderLevel = Int16.Parse(reordertextBox.Text);

            if (ne.SaveChanges() == 1)
            {
                MessageBox.Show("Güncellendi.");
            }
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ne.Products.ToList();
        }
    }
}
