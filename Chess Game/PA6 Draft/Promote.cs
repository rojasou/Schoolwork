using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6_Draft
{
    public partial class Promote : Form
    {
        
        public Promote()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                promOpt = 1;
            if (radioButton2.Checked)
                promOpt = 2;
            if (radioButton3.Checked)
                promOpt = 3;
            if (radioButton4.Checked)
                promOpt = 4;
        }
    }
}
