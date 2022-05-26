using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SerpienteProyecto.Clases.BasedeDatos
{
    internal class ConexionMySql
    {
        public MySqlConnection conexion;
        private String _conexion { get; }
        public ConexionMySql()
        {
            _conexion = "server=127.0.0.1; database=serpiente; Uid=root ; pwd=12345";
        }
        public void cerrarConexionBD()
        {
            conexion.Close();
        }
        public void abrirConexion()
        {
            conexion = new MySqlConnection(_conexion);
            conexion.Open();
        }
        public DataTable consultaTablaDirecta(String Mysqll)
        {
            abrirConexion();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand(Mysqll, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerrarConexionBD();
            return dataTable;
        }
        public void EjecutaSQLDirecto(String Mysqll)
        {
            abrirConexion();
            try
            {

                MySqlCommand comm = new MySqlCommand(Mysqll, conexion);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cerrarConexionBD();
            }

        }
    }
}
