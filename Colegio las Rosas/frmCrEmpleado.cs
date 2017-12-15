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
        }

        public frmCrEmpleado(string v)
        {
            InitializeComponent();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            oper.insertar(" INSERT INTO empleado (nombre,apellido,fechaNacimiento,sexo,fechaingreso,telefono,celular,cedula,direccion,fkCodCargo,fkCodDepart,sueldo )VALUES('" + tbnombre.Text.ToString() + "','" + tbapellido.Text.ToString() + "','" +dtNacimiento.Text.ToString() + "','" + cbgenero.Text.ToString() + "','" + dtIngreso.Text.ToString()+ "','" +tbtelefono.Text.ToString()+ "','"+tbcelular.Text.ToString()+"','"+tbcedula.Text.ToString()+"','"+tbdireccion.Text.ToString()+"','"+tbCargo.Text.ToString()+"','"+tbDepart.Text.ToString()+"','"+tbsueldo.Text.ToString()+"')");
        }

        private void frmCrEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
    
}
