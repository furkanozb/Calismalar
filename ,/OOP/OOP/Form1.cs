using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        public Form1()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtId.Clear();
            txtPname.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }
        private void Row()
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
         private void ProductList()
        {
            dgwProduct.DataSource = db.ExecuteAdapter("SP_Select");
        }
        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgwProduct.CurrentRow.Cells[0].Value.ToString();
            txtPname.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            dgwProduct.DataSource = db.ExecuteAdapter("SP_Select");
        }
        
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPname.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Lütfen bilgileri doldurun!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Bilgiler kaydedilecek. Emin misiniz?", "KAYIT ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (r)
                {
                    case DialogResult.Yes:
                        db.ExecuteCommand("SP_Insert", new SqlParameter[] {
                            new SqlParameter("@PName", txtPname.Text),
                            new SqlParameter("@Price", txtPrice.Text),
                            new SqlParameter("@Stock",txtStock.Text)
                        });
                        ProductList();
                      Clear();
                        break;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Silme işlemini yapmak istediğinizden emini misiniz?", "SİLME ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch (r)
            {

                case DialogResult.Yes:
                    db.ExecuteCommand("SP_Delete", new SqlParameter[] {
                            new SqlParameter("@Id", txtId.Text)
                        });
                    ProductList();
                    Clear();
                    break;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Güncelleme işlemini yapmak istediğinizden emini misiniz?", "GÜNCELLEME ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch (r)
            {

                case DialogResult.Yes:
                    db.ExecuteCommand("SP_Update", new SqlParameter[] {
                            new SqlParameter("@Id", txtId.Text),
                            new SqlParameter("@PName", txtPname.Text),
                            new SqlParameter("@Price", txtPrice.Text),
                            new SqlParameter("@Stock", txtStock.Text)
                        });
                    ProductList();
                    break;

            }
        }
    }

}
