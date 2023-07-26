using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Proyecto_Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sexoTemporal = "";
            Usuario usuario = new Usuario();
            if (TXTsexo.Text == "Masculino")
            {
                sexoTemporal = "M";
               
            }else if (TXTsexo.Text == "Femenino")
            {
                sexoTemporal = "F";
            }
            if (usuario.crear(TXTnombre.Text, TXTfecha.Text, sexoTemporal)>0)
            {
                Label4.Text = "registrado correctamente";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}