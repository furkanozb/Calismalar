using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PresentationLayer
{
    public partial class ProdCote : Form
    {
        public ProdCote()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product pd = new Product();
            pd.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Show();
        }
    }
}
