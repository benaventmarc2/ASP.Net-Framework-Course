using System;
namespace SesionUsuarios.WebForms
{
    public partial class SesionesDeUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // El servidor manda la respuesta al cliente
            Response.Write("Canditad de aplicaciones instanciadas" + Application["Aplicaciones"] + "<br/>");
            Response.Write("Cantidad de sesiones de usuario " + Application["SesionesUsuario"]);
        }
    }
}