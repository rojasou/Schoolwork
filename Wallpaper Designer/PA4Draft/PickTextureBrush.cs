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
    public partial class PickTextureBrush : Form
    {
        public PickTextureBrush()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                file = ofd.FileName;
            }
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

        private void ok_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                tile = WrapMode.TileFlipX;
            if (radioButton2.Checked)
                tile = WrapMode.TileFlipY;
            if (radioButton3.Checked)
                tile = WrapMode.TileFlipXY;
            if (radioButton4.Checked)
                tile = WrapMode.Clamp;
        }
    }
}
