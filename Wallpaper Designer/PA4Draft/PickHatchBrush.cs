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
    public partial class PickHatchBrush : Form
    {
        public PickHatchBrush()
        {
            InitializeComponent();
            pickedColor = SystemColors.ButtonFace;
            pickedColor1 = SystemColors.ButtonFace;

            foreach (string styleName in Enum.GetNames(typeof(HatchStyle)))
            {
                this.listBox1.Items.Add(styleName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                hStyle = (HatchStyle)Enum.Parse(typeof(HatchStyle),
                         listBox1.SelectedItem.ToString(), true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                pickedColor = colorDialog1.Color;
            pickedColor = Color.FromArgb((byte)opacity1.Value, pickedColor.R, pickedColor.G, pickedColor.B);
            button1.BackColor = pickedColor;
        }
        private void Opacity_ValueChanged(object sender, EventArgs e)
        {
            pickedColor = Color.FromArgb((byte)opacity1.Value, pickedColor.R, pickedColor.G, pickedColor.B);
            button1.BackColor = pickedColor;
        }
        private void Opacity2_ValueChanged(object sender, EventArgs e)
        {
            pickedColor1 = Color.FromArgb((byte)opacity2.Value, pickedColor1.R, pickedColor1.G, pickedColor1.B);
            button2.BackColor = pickedColor1;
        }
        private void opacity1_Scroll(object sender, EventArgs e)
        {

        }

        private void opacity2_Scroll(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog2.ShowDialog();
            if (d == DialogResult.OK)
                pickedColor1 = colorDialog2.Color;
            pickedColor1 = Color.FromArgb((byte)opacity2.Value, pickedColor1.R, pickedColor1.G, pickedColor1.B);
            button2.BackColor = pickedColor1;
        }
    }
}
