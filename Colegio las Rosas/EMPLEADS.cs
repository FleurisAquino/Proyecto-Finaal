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
    public partial class frmEMPLEADS : Form
    {
        public frmEMPLEADS()
        {
            InitializeComponent();
            pbCemp.Image = Image.FromFile("CreEmp.png");
            pbVempleado.Image = Image.FromFile("MosEmp.png");
        }

        private void frmEMPLEADOS_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pBempleados_Click(object sender, EventArgs e)
        {
            Form frm = new frmEmpleados();
            frm.Show();
        }

        private void pbCemp_Click(object sender, EventArgs e)
        {
            Form frm = new frmCrEmpleado();
            frm.Show();
        }
    }
}
