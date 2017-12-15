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
    public partial class frmCrEmpleado : Form
    {
        
        public frmCrEmpleado()


        {
           InitializeComponent();

           // if (codigo != null)
            //{
               // buscar(codigo);
              //}
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            oper.insertar(" INSERT INTO empleado (nombre,apellido,fechaNacimiento,sexo,fechaingreso,telefono,celular,cedula,direccion,fkCodCargo,fkCodDepart,sueldo )VALUES('" + tbnombre.Text.ToString() + "','" + tbapellido.Text.ToString() + "','" + dtNacimiento.Text.ToString() + "','" + cbgenero.Text.ToString() + "','" + dtIngreso.Text.ToString() + "','" + tbtelefono.Text.ToString() + "','" + tbcelular.Text.ToString() + "','" + tbcedula.Text.ToString() + "','" + tbdireccion.Text.ToString() + "','" + tbCargo.Text.ToString() + "','" + tbDepart.Text.ToString() + "','" + tbsueldo.Text.ToString() + "')");
        }

       private void frmCrEmpleado_Load(object sender, EventArgs e)
       {

       }
       // private void buscar(string codigo)
        //{
          //  try
            //{
              //  Coneccion oper = new Coneccion();
               // DataSet ds = oper.MostrarData(" select codigo from empleado WHERE codigo='" + codigo + "' ");
               // foreach (DataRow fila in ds.Tables[0].Rows)
               // {
                  //  if (fila["codigo"] != null) tbCargo.Text = fila["codigo"].ToString();
               // }


           // }
           // catch (Exception)
           // {

                
           // }
       // }
        
        private void btcargo_Click(object sender, EventArgs e)
        {

        }

        private void btdepar_Click(object sender, EventArgs e)
        {
            Form frm = new frmVistaDepart();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ;
        }

        private void btcodCargo_Click(object sender, EventArgs e)
        {
            Form frm = new VistaCargos();
            frm.Show();
        }
    }
}