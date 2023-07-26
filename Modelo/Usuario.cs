using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.Data;

namespace Modelo
{
    public class Usuario
    {
        Conexion conectar = new Conexion();
        public int crear(string nombre, string fecha, string sexo)
        {
            int no = 0;
            conectar.abrirConexion();
            string consulta = string.Format("INSERT INTO proyecto.usuarios(nombre, fecha_nacimiento,sexo) VALUES ('{0}','{1}','{2}')", nombre, fecha, sexo);
            MySqlCommand cmd = new MySqlCommand(consulta, conectar.conectar);
            cmd.Connection = conectar.conectar;
            no = cmd.ExecuteNonQuery();
            conectar.cerrarConexion();
            return no;
        }

        private DataTable consultar()
        {
            DataTable tabla = new DataTable();
            conectar.abrirConexion();
            string consulta = string.Format("SELECT * FROM proyecto.usuarios");
            MySqlDataAdapter cmd = new MySqlDataAdapter(consulta, conectar.conectar);
            cmd.Fill(tabla);
            conectar.cerrarConexion();
            return tabla;
        }

        public void consultar(GridView grid)
        {
            grid.DataSource = consultar();
            grid.DataBind();
        }

        public int borrar(string nombre)
        {
            int no = 0;
            conectar.abrirConexion();
            string consulta = string.Format("DELETE FROM proyecto.usuarios WHERE nombre={0};", nombre);
            MySqlCommand cmd = new MySqlCommand(consulta, conectar.conectar);
            cmd.Connection = conectar.conectar;
            no =cmd.ExecuteNonQuery();
            conectar.cerrarConexion();
            return no;
        }
    }
}
