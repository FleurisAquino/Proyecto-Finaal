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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            
            DataSet ds = oper.MostrarData("select codigo,nombre,apellido,cedula,telefono,direccion,sueldo from empleado");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           //frmCrEmpleado frm = new frmCrEmpleado(dataGridView1.CurrentRow.Cells[0].Value.ToString());
           //frm.ShowDialog();
        }
    }
}
