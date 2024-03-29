﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace VariablesDeSession.WebForms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private int conteo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
            if (Session["click"] != null)
            {
                txtConteo.Text = ((int)Session["click"]).ToString();
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            // Si ya se ha usado el viewstate con la variable click
            if (Session["click"] != null)
            {
                conteo = (int)Session["click"] + 1;
            }
            txtConteo.Text = conteo.ToString();

            Session["click"] = conteo;
        }
    }
}