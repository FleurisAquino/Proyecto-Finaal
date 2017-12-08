using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colegio_las_Rosas
{
    public partial class frmgeneral : Form
    {
        public frmgeneral()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("CLRlogo.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
