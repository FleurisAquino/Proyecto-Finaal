using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Colegio_las_Rosas
{
    public partial class frmlogin : Form
    {
        //Metodo para usuario y contrsena 
        public frmlogin()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("CLRlogo.png");
        }
        SQLiteConnection cnx = new SQLiteConnection(@"Data Source = C:\\SQLite\\LasRosas.db; Vercion=3;");

        public void Login(string usuario, string contracena)

        {
            try
            {//Filtra de la base de datos los usuarios y contracenas existentes 
                cnx.Open();
                SQLiteCommand cmd = new SQLiteCommand ("select * from login where clave = @pas and usuario = @user", cnx);
                cmd.Parameters.AddWithValue("pas", contracena);
                cmd.Parameters.AddWithValue("user",usuario);
                SQLiteDataAdapter dat = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                dat.Fill(dt);

                if (dt.Rows.Count ==1)
                

                {//Oculta la tabla de login y abre la interfas pricipal 
                    this.Hide();
                    Form frm = new frmgeneral();
                    frm.Show();
                }
                else
                {//mensaje de error si el usuario o contracena es incorrecto
                    MessageBox.Show("USUARIO O CONTRACEÑA INCORRECTO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo" + ex.ToString());
            }
            finally
            {
                cnx.Close();
            }
        }
        private void l_Load(object sender, EventArgs e)
        {

        }
        private void btnentrar_Click(object sender, EventArgs e)
        {//permite introducir el usuario y la contracena en los texbox corespndientes 
            Login(this.tbcontracena.Text,this.tbusuario.Text);           
        }       
    }
}
