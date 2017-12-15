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
            pbregistro.Image = Image.FromFile("registro.png");
            pbFinanzas.Image = Image.FromFile("finanzas.png");
            pBempleados.Image = Image.FromFile("empleados.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form frm = new frmRegistros();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmlogin();
            frm.Show();
            this.Hide();
        }

        private void pbFinanzas_Click(object sender, EventArgs e)
        {
            Form frm = new frmFinanzas();
            frm.Show();
        }

        private void entrar(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            try

            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cerrar La Sesion" + ex.ToString());
            }

        }

        private void pbinscripcion_Click(object sender, EventArgs e)
        {

        }

        private void frmgeneral_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCrearLogin();
            frm.Show();
        }

        private void pBempleados_Click(object sender, EventArgs e)
        {
            Form frm = new frmEMPLEADS();
            frm.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCrEmpleado();
            frm.Show();
        }
  
    }

       
}


    