using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VariablesDeSession.WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int conteo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt.Text = "0";
            }
            if (Session["click"] != null)
            {
                txt.Text = ((int)Session["click"]).ToString();
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            // Si ya se ha usado el viewstate con la variable click
            if (Session["click"] != null)
            {
                conteo = (int)Session["click"] + 1;
            }
            txt.Text = conteo.ToString();

            Session["click"] = conteo;
        }
    }
}