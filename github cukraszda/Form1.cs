using System;
using System.Windows.Forms;

namespace Cukrászda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void süteményekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 arlista = new Form2();
            arlista.ShowDialog();
        }
    }
}

/*
Készítette:
Halász Tibor
Borók Flórián
Kis Balázs Tibor
*/