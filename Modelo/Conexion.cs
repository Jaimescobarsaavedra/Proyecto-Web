using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Conexion
    {
        private string cadena = "server=localhost; database=proyecto; user=root; password=12345678";
        public MySqlConnection conectar = new MySqlConnection();
        public void abrirConexion()
        {
            try
            {
                conectar.ConnectionString = cadena;
                conectar.Open();
                System.Diagnostics.Debug.WriteLine("conexion exitosa");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }   
            
        }
        public void cerrarConexion()
        {
            try
            {
                if(conectar.State == ConnectionState.Open)
                {
                    conectar.Close();
                    System.Diagnostics.Debug.WriteLine("conexion cerrada");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}
