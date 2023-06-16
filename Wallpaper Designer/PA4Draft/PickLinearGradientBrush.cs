using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class PickLinearGradientBrush : Form
    {
        public PickLinearGradientBrush()
        {
            InitializeComponent();
            pickedColor = SystemColors.ButtonFace;
            pickedColor1 = SystemColors.ButtonFace;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                pickedColor = colorDialog1.Color;
            button1.BackColor = pickedColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog2.ShowDialog();
            if (d == DialogResult.OK)
                pickedColor1 = colorDialog2.Color;
            button2.BackColor = pickedColor1;
        }

        private void startX_ValueChanged(object sender, EventArgs e)
        {
                sval1 = Convert.ToInt32(startX.Value);
        }

        private void startY_ValueChanged(object sender, EventArgs e)
        {
                sval2 = Convert.ToInt32(startY.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void length_ValueChanged(object sender, EventArgs e)
        {
            eval1 = Convert.ToInt32(length.Value);
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
            eval2 = Convert.ToInt32(width.Value);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            rect = new Rectangle(sval1, sval2, eval2, eval1);
            if (radioButton1.Checked)
                linMode = LinearGradientMode.Horizontal;
            if (radioButton2.Checked)
                linMode = LinearGradientMode.Vertical;
            if (radioButton3.Checked)
                linMode = LinearGradientMode.BackwardDiagonal;
            if (radioButton4.Checked) 
                linMode = LinearGradientMode.ForwardDiagonal;
    }
}
}
