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
    public partial class frmVistaCalificaciones : Form
    {
        public frmVistaCalificaciones()
        {
            InitializeComponent();
        }

        private void frmVistaCalificaciones_Load(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();

            DataSet ds = oper.MostrarData("select a.nombre as Nombre,a.apellido1 as Apellido, c.total_cali from alumno a inner join calificaciones c on a.codigo=c.fkcodalumn" );

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click_1(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            DataSet ds = oper.MostrarData("select a.nombre as Nombre,a.apellido1 as Apellido, c.total_cali from alumno a inner join calificaciones c on a.codigo=c.fkcodalumn");
            ds.WriteXml("C:\\SQLite\\LasRosasNotaMes\\cali.xml");

            frmReporteMensual cali = new frmReporteMensual("NotaMes.rpt");
            cali.Show();

        }
    }
}
