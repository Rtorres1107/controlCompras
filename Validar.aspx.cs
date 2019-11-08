using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Validar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Usuario"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            if (Convert.ToString(Session["Tipo"]) == "admin")
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Response.Redirect("Empleado.aspx");
            }
        }
    }
}