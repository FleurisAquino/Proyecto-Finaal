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
    public partial class frmInscrip : Form
    {
        public frmInscrip()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btConsul_Click(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            oper.insertar(" INSERT INTO alumno (nombre, apellido1,apellido2,fecha_nacimiento,sexo,fkpadre,fkmadre )VALUES('" + tbnombre.Text.ToString() + "','" + tbapellido1.Text.ToString() + "','" + tbapellido2.Text.ToString() + "','" + DTPfechanac.Text.ToString() + "','" + cbSex.Text.ToString() + "','" + tbFKPcodigo.Text.ToString() + "','"+tbMcodigo.Text.ToString()+"')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            oper.insertar(" INSERT INTO padre (nombre, apellido,telefono,celular,cedula,direccion )VALUES('" + tbPnombre.Text.ToString() + "','" + tbPapellido.Text.ToString() + "','" + tbPtelefono.Text.ToString() + "','" + tbPcelular.Text.ToString() + "','" + tbPcedula.Text.ToString() + "','" + tbPdireccion.Text.ToString() + "')");

   
            Coneccion guardar = new Coneccion();
            DataSet ds = new DataSet();
            ds = oper.MostrarData("SELECT codigo FROM padre order by - codigo limit 1");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                tbFKPcodigo.Text = fila["codigo"].ToString();
            }

            Coneccion guar = new Coneccion();
            oper.insertar(" INSERT INTO madre (nombre, apellido,telefono,celular,cedula,direccion )VALUES('" + tbMnombre.Text.ToString() + "','" + tbMapellido.Text.ToString() + "','" + tbMtelefono.Text.ToString() + "','" + tbMcelular.Text.ToString() + "','" + tbMcedula.Text.ToString() + "','" + tbMdireccion.Text.ToString() + "')");


            Coneccion guard = new Coneccion();
            DataSet das = new DataSet();
            ds = oper.MostrarData("SELECT codigo FROM madre order by - codigo limit 1");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                tbMcodigo.Text = fila["codigo"].ToString();
            }
        }
    }
}
