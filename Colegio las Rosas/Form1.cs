﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colegio_las_Rosas
{
    public partial class l : Form
    {
        public l()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("CLRlogo.png");
        }

        private void l_Load(object sender, EventArgs e)
        {

        }
    }
}
