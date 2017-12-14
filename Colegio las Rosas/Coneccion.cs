using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Colegio_las_Rosas
{
    class Coneccion
    {
        SQLiteConnection cnx;
        SQLiteCommand cmd;

        public Coneccion()
        {
            cnx = new SQLiteConnection("Data Source = C:\\SQLite\\LasRosas.db;Vercion=3;");
            try

            {
                cnx.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No establesida:" + ex.ToString());
            }
            finally
            {
                cnx.Close();
            }

        }
        public void Login(string sql)
        {
        cnx = new SQLiteConnection("Data Source = C:\\SQLite\\LasRosas.db;Vercion=3;");
        try
        {
        cnx.Open();
        cmd = new SQLiteCommand(sql, cnx);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Guardado");
        }
        catch (Exception ex)
        {
        MessageBox.Show("Error" + ex.ToString());
        }

        }

        public DataSet MostrarData(string sql)    
       {
           cnx = new SQLiteConnection("Data Source = C:\\SQLite\\LasRosas.db;Vercion=3;");

            try
            {
                cnx.Open();
                DataSet dt = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cnx);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
               MessageBox.Show("No se pudo" + ex.ToString());
            }
            return null;
        }
        public string insertar(string sql)
        {
            cnx = new SQLiteConnection("Data Source = C:\\SQLite\\LasRosas.db;Vercion=3;");

            try
            {
                cnx.Open();
                cmd = new SQLiteCommand(sql, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO GUARDADO:" + ex.ToString());
            }
            return null;
        }

    }
}
