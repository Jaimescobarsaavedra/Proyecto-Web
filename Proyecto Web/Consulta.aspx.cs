using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Proyecto_Web
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void BTNconsultar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.consultar(GridView1);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeletedEventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario.borrar(Convert.ToString(e.Keys["nombre"]))>0)
            {
                usuario.consultar(GridView1);
            }
        }
    }
}