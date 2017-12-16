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
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbtotal.Text = (Convert.ToInt32(tbparti.Text) + Convert.ToInt32(tbprod.Text)+ Convert.ToInt32(tbvalores.Text)+ Convert.ToInt32(tbexamen.Text)+ Convert.ToInt32(tbasig.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            oper.insertar(" INSERT INTO calificaciones (fecha_calif,prueva,paricipacion,asignacion,produccion,valores,total_cali,fkcod_curso,fkcod_asig)VALUES('" + dtFcali.Text + "','" + tbexamen.Text.ToString() + "','" + tbparti.Text.ToString() + "','" + tbasig.Text.ToString() + "','" + tbparti.Text.ToString() + "','" + tbvalores.Text.ToString() + "','" +tbtotal.Text.ToString() + "','" + tbCur.Text.ToString() + "','" + tbasign.Text.ToString() + "')");
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
