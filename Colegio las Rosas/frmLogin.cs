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
    public partial class frmCrearLogin : Form
    {
        public frmCrearLogin()
        {
            InitializeComponent();
        }

        private void frmCrearLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLguardar_Click(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            oper.insertar(" INSERT INTO login (clave,usuario,fkempleado)VALUES('" + tbLcontracena.Text.ToString() + "','" + tbLusuario.Text.ToString() + "','" + tbLcodEmp.Text.ToString() + "')");
        }
    }
    
           
    
}
