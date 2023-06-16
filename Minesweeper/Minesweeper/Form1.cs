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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Form2").ToArray();
            foreach (Form openForm in formsList)
            {
                openForm.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Play(object sender, EventArgs e)
        {
            int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            if (easy.Checked)
            {
                row = col = 9;
                mines = 10;
                text = "Easy";
            }
            else if (medium.Checked)
            {
                row = col = 16;
                mines = 40;
                text = "Medium";
            }
            else if (expert.Checked)
            {
                row = 30;
                col = 16;
                mines = 99;
                text = "Expert";
            }
            else if (custom.Checked)
            {
                customDialog d = new customDialog();
                d.ShowDialog();
                return;
            }
            else
                return;
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size,mines);
            f.Show();


        }

        private void playANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 9, col = 9, mines = 10;
            String text = "Easy";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            Form2 f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 16, col = 16, mines = 40;
            String text = "Medium";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            Form2 f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 30, col = 16, mines = 99;
            String text = "Expert";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            Form2 f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeAllGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Form2").ToArray();
            foreach (Form openForm in formsList)
            {
                openForm.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = -1;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Visible == true)
                    count++;
            }
            textBox1.Text = count.ToString();
        }
    }
}
