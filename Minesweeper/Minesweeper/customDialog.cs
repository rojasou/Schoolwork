using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class customDialog : Form
    {
        public customDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = "Custom";
            int row = Int32.Parse(textBox1.Text);
            int col = Int32.Parse(textBox2.Text);
            int mines = Int32.Parse(textBox3.Text);

            if (row < 0)
            {
                customDialog d = new customDialog();
                d.ShowDialog();
                return;
            }

            else if (col < 0)
            {
                customDialog d = new customDialog();
                d.ShowDialog();
                return;
            }

            else if (mines < 0)
            {
                customDialog d = new customDialog();
                d.ShowDialog();
                return;
            }

            else if (row * col < 18)
            {
                customDialog d = new customDialog();
                d.ShowDialog();
                return;
            }

            else if (mines > row * col / 2)
            {
                customDialog d = new customDialog();
                d.ShowDialog();
                return;
            }
            else
            {
                int size = Math.Min(30, 1000 / Math.Max(row, col));
                Form2 f = new Form2(text, row, col, size, mines);
                f.Show();
            }
        }
    }
}
