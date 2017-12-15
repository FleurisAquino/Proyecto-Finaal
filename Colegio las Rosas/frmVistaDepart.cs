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
    public partial class frmVistaDepart : Form
    {
        public frmVistaDepart()
        {
            InitializeComponent();
        }

        private void frmVistaDepart_Load(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();

            DataSet ds = oper.MostrarData("select codigo as Codigo,nombre as Departamento,total_cargos as Total  from departamentos");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmCrearDepart();
            frm.Show();
            Close();
        }
    }
}
