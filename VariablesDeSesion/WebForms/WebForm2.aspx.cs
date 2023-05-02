using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VariablesDeSesion.WebForms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private int conteo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtIncrementa.Text = "0";
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            // Si ya se ha usado el viewstate con la variable click
            if (ViewState["click"] != null)
            {
                // Leemos el valor, hacemos typecast, lo incrementamos y lo colocamos en la
                // variable para poder trabajar co nese dato
                conteo = (int)ViewState["click"] + 1;
            }

            // actualizamos el textbox
            txtIncrementa.Text = conteo.ToString();

            //Asignamos el valor al viewstate en la variable click
            ViewState["click"] = conteo;
        }
    }
}