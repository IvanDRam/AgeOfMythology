using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace crud.Datos
{
    internal static class CONEXIONMAESTRA
    {
        public static SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-O28IP4D; Initial Catalog = aom; Integrated Security = True");
  
        public static void abrir()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            
        }
        public static void cerrar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
