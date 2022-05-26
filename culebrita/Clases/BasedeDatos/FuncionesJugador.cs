using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SerpienteProyecto.Clases.BasedeDatos
{
    internal class FuncionesJugador
    {
        public DataTable ConsultarCampeones()
        {
            ConexionMySql conexion = new ConexionMySql();
            DataTable tabla = new DataTable();
            string consulta = "select  * from serpiente.info_player order by points_player desc;";
            tabla = conexion.consultaTablaDirecta(consulta);
            return tabla;
        }

        public String ConsultarJugadorMAX()
        {
            ConexionMySql conexion = new ConexionMySql();
            DataTable tabla = new DataTable();
            string consulta = "select name_player,points_player from serpiente.info_player where points_player=" +
                "(select max(points_player)from serpiente.info_player);";
            tabla = conexion.consultaTablaDirecta(consulta);
            string jugador = "";
            foreach (DataRow row in tabla.Rows)
            {
                jugador += ($"{row[0]} - {row[1]}");
            }
            return jugador;
        }

        public void InsertarJugador(string nombre, int pts)
        {
            ConexionMySql conexion = new ConexionMySql();
            string consulta = $"INSERT INTO `serpiente`.`info_player` (`name_player`, `points_player`) VALUES ('{nombre}', '{pts}');";
            conexion.EjecutaSQLDirecto(consulta);
        }

    }
}
