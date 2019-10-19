using CRMDBSolution;
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
    public partial class Login : Form
    {
        CRMDBEntities db = new CRMDBEntities();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string KullanıcıAdı = txtUserName.Text;
            string Sifre = txtUserPas.Text;
            var KlncAdı = from x in db.Users where x.UserName == KullanıcıAdı select x;
            var KlncSifre = from x in db.Users where x.Password == Sifre select x;

            if (KlncAdı.Any() && KlncSifre.Any())
            {
                ProdCote frm2 = new ProdCote();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Giriş Hatalı!");
            }
        }
    }         
}
