using System;
using System.Windows.Forms;

namespace Cukrászda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int osszeg = 0;

                richTextBox1.Clear();
                richTextBox1.AppendText("***** SZÁMLA *****\n\n");

                if (checkBox1.Checked)
                {
                    int db = (int)numericUpDown1.Value;
                    int ar = db * 300;

                    richTextBox1.AppendText(
                        "Somlói galuska " + db + " db = " + ar + " Ft\n");

                    osszeg += ar;
                }

                if (checkBox2.Checked)
                {
                    int db = (int)numericUpDown2.Value;
                    int ar = db * 250;

                    richTextBox1.AppendText(
                        "Piskótatekercs " + db + " db = " + ar + " Ft\n");

                    osszeg += ar;
                }

                if (checkBox3.Checked)
                {
                    int db = (int)numericUpDown3.Value;
                    int ar = db * 350;

                    richTextBox1.AppendText(
                        "Csoki torta " + db + " db = " + ar + " Ft\n");

                    osszeg += ar;
                }

                if (checkBox4.Checked)
                {
                    int db = (int)numericUpDown4.Value;
                    int ar = db * 400;

                    richTextBox1.AppendText(
                        "Marcipános szelet " + db + " db = " + ar + " Ft\n");

                    osszeg += ar;
                }

                if (checkBox5.Checked)
                {
                    int db = (int)numericUpDown5.Value;
                    int ar = db * 500;

                    richTextBox1.AppendText(
                        "Eszterházy szelet " + db + " db = " + ar + " Ft\n");

                    osszeg += ar;
                }

                if (osszeg == 0)
                {
                    MessageBox.Show("Nincs kiválasztott termék!");
                    return;
                }

                richTextBox1.AppendText("\n----------------------\n");
                richTextBox1.AppendText("Végösszeg: " + osszeg + " Ft");
            }
        }
    }
}

/*
Készítette:
Halász Tibor
Borók Flórián
Kis Balázs Tibor
*/