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
    public partial class frmCrearDepart : Form
    {
        public frmCrearDepart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coneccion oper = new Coneccion();
            oper.insertar("insert into departamentos (nombre) values ('" + tbnombre.Text.ToString() + "')");
            Close();
        }
    }
}
