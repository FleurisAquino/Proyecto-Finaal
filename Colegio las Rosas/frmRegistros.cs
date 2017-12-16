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
    public partial class frmRegistros : Form
    {
        public frmRegistros()
        {
            InitializeComponent();
            pbinscripcion.Image = Image.FromFile("Formulario_Inscripción.png");
            pbCali.Image = Image.FromFile("Cali.png");
            pictureBox1.Image = Image.FromFile("CLRlogo.png");
            pbRep.Image = Image.FromFile("Rep.png");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmRegistros_Load(object sender, EventArgs e)
        {

        }

        private void pbinscripcion_Click(object sender, EventArgs e)
        {
            Form frm = new frmInscrip();
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCalificaciones();
            frm.Show();
        }

        private void pbCali_Click(object sender, EventArgs e)
        {
            Form frm = new frmCalificaciones();
            frm.Show();
        }

        private void pbRep_Click(object sender, EventArgs e)
        {
            Form frm = new frmReportes();
            frm.Show();
        }
    }
}
