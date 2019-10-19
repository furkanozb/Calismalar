using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma","Cumartesi","Pazar" };
            listBox1.Items.Clear();
            foreach(string gun in gunler)
            {
                listBox1.Items.Add(gun);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma","Cumartesi","Pazar" };
            label1.Text = gunler.Length.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            listBox1.Items.Clear();
            Array.Clear(gunler, 2, 2);
            foreach (string gun in gunler)
            {
                if (gun != null) listBox1.Items.Add(gun);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string[] yenigunler;
            yenigunler = (string[])gunler.Clone();
            listBox1.Items.Clear();
            foreach (string gun in yenigunler)
            {
                listBox1.Items.Add(gun);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string[] yenigunler = new string[7];
            Array.Copy(gunler, yenigunler, 5);
            listBox1.Items.Clear();
            foreach (string gun in yenigunler)
            {
                if (gun != null) listBox1.Items.Add(gun);
            }
        }
    }
}
