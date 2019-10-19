using Morse.Flyweight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMorse_Click(object sender, EventArgs e)
        {
            string document = txtMorse.Text;
            char[] chars = document.ToCharArray();
            var factory = new CharacterFactor();
            int pointsize = 10;
            foreach (char c in chars)
            {
                var character = factory[c];
                character.Display(pointsize,lbMorse);
            }
        }
    }
}
