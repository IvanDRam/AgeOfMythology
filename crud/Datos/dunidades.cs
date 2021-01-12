using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using crud.Logica;
using System.Data;

namespace crud.Datos
{
    class dunidades
    {
        private SqlCommand cmd = new SqlCommand();
        private int unidad;
        public bool insertar(lunidades dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("insertar_unidad", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", dt.Nombre);
                cmd.Parameters.AddWithValue("@Costo", dt.Costo);
                cmd.Parameters.AddWithValue("@Puntos_resis", dt.Puntos_resis);
                cmd.Parameters.AddWithValue("@Velocidad", dt.Velocidad);
                cmd.Parameters.AddWithValue("@Coste_poblacion", dt.Coste_poblacion);
                cmd.Parameters.AddWithValue("@Alcance_max", dt.Alcance_max);
                cmd.Parameters.AddWithValue("@Arm_anticontundente", dt.Arm_anticontundente);
                cmd.Parameters.AddWithValue("@Arm_anticortante", dt.Arm_anticortante);
                cmd.Parameters.AddWithValue("@Arm_antiperforante", dt.Arm_antiproyectiles);
                cmd.Parameters.AddWithValue("@Dam_cortante", dt.Dam_cortante);
                cmd.Parameters.AddWithValue("@Dam_perforante", dt.Dam_perforante);
                cmd.Parameters.AddWithValue("@Dam_Demoledor", dt.Dam_demoledor);
                cmd.Parameters.AddWithValue("@Civilizacion", dt.Civilizacion);
                cmd.Parameters.AddWithValue("@Edad", dt.Edad);
                cmd.Parameters.AddWithValue("@Tipo", dt.Tipo);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

        public bool borrar(lunidades dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("borrar_unidad", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Unidad", dt.Unidad);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

        public bool actualizar(lunidades dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("actualizar_unidad", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Unidad",dt.Unidad);
                cmd.Parameters.AddWithValue("@Nombre", dt.Nombre);
                cmd.Parameters.AddWithValue("@Costo", dt.Costo);
                cmd.Parameters.AddWithValue("@Puntos_resis", dt.Puntos_resis);
                cmd.Parameters.AddWithValue("@Velocidad", dt.Velocidad);
                cmd.Parameters.AddWithValue("@Coste_poblacion", dt.Coste_poblacion);
                cmd.Parameters.AddWithValue("@Alcance_max", dt.Alcance_max);
                cmd.Parameters.AddWithValue("@Arm_anticontundente", dt.Arm_anticontundente);
                cmd.Parameters.AddWithValue("@Arm_anticortante", dt.Arm_anticortante);
                cmd.Parameters.AddWithValue("@Arm_antiperforante", dt.Arm_antiproyectiles);
                cmd.Parameters.AddWithValue("@Dam_cortante", dt.Dam_cortante);
                cmd.Parameters.AddWithValue("@Dam_perforante", dt.Dam_perforante);
                cmd.Parameters.AddWithValue("@Dam_Demoledor", dt.Dam_demoledor);
                cmd.Parameters.AddWithValue("@Civilizacion", dt.Civilizacion);
                cmd.Parameters.AddWithValue("@Edad", dt.Edad);
                cmd.Parameters.AddWithValue("@Tipo", dt.Tipo);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

        public DataTable mostrar()
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("mostrar_unidad", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;

                }
                else
                {
                    return null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
