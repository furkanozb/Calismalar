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
    public partial class Category : Form
    {
        CRMDBEntities db = new CRMDBEntities();
        public Category()
        {
            InitializeComponent();
        }
        private void textboxClear()
        {
            txtId.Clear();
            txtCatName.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dgwCategory.DataSource = db.Category.ToList();
        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            var silme = db.Category.Where(w => w.CategoryId == Id).FirstOrDefault();
            db.Category.Remove(silme);
            db.SaveChanges();
            dgwCategory.DataSource = db.Products.ToList();
            textboxClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Guncelle = Convert.ToInt32(txtId.Text);
            var guncelle = db.Category.Where(w => w.CategoryId == Guncelle).FirstOrDefault();
            guncelle.CategoryName = txtCatName.Text;
            db.Entry(guncelle).State = EntityState.Modified;
            db.SaveChanges();
            dgwCategory.DataSource = db.Category.ToList();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string ad = txtCatName.Text;
            var ekle = db.Category.Where(w => w.CategoryName == ad).FirstOrDefault();
            db.Category.Add(ekle);
            db.SaveChanges();
            dgwCategory.DataSource = db.Category.ToList();
        }
    }
}
