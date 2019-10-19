using CRMDBSolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PresentationLayer
{
    public partial class Product : Form
    {
        CRMDBEntities db = new CRMDBEntities();
        public Product()
        {
            InitializeComponent();
        }
        private void textboxClear()
        {
            txtStock.Clear();
            txtProName.Clear();
            txtPrice.Clear();
            txtId.Clear();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Products pd = new Products();
            pd.PName = Convert.ToString(txtProName.Text);
            pd.Price = Convert.ToInt32(txtPrice.Text);
            pd.stock = Convert.ToInt32(txtStock.Text);
            db.Products.Add(pd);
            db.SaveChanges();
            dgwProduct.DataSource = db.Products.ToList();
            textboxClear();
        }

        private void btnREad_Click(object sender, EventArgs e)
        {
            dgwProduct.DataSource = db.Products.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            var silme = db.Products.Where(w => w.Id == Id).FirstOrDefault();
            db.Products.Remove(silme);
            db.SaveChanges();
            dgwProduct.DataSource = db.Products.ToList();
            textboxClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Guncelle = Convert.ToInt32(txtId.Text);
            var guncelle = db.Products.Where(w => w.Id == Guncelle).FirstOrDefault();
            guncelle.PName = txtProName.Text;
            guncelle.Price =  Convert.ToDecimal(txtPrice.Text);
            guncelle.stock = Convert.ToInt32(txtStock.Text);
            db.Entry(guncelle).State = EntityState.Modified;
            db.SaveChanges();
            dgwProduct.DataSource = db.Products.ToList();
            txtId.Clear();
            txtPrice.Clear();
            txtProName.Clear();
            txtStock.Clear();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgwProduct.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
    }
}
