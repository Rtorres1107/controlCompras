using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Reflection;

public partial class Login : System.Web.UI.Page
{
    ControlComprasDataContext compras = new ControlComprasDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var usuario = compras.buscar_usuario(txtUsuario.Text, txtContra.Text);
        int numero_filas = Convert.ToInt32(usuario.LongCount());
        string tipo = "";
        if (numero_filas != 0)
        {
            Response.Write("Entrada permitida");
            Response.Write("<br />");
            var consulta = from l in compras.buscar_usuario(txtUsuario.Text, txtContra.Text) select new {Tipo=l.tipo,Usuario=l.usuario };
            foreach (var item in consulta.ToList())
            {
                Session.Add("Tipo", item.Tipo);
                Session.Add("Usuario",item.Usuario);
                Response.Redirect("Validar.aspx");
            }
        }
        else
        {
            Response.Write("Entrada denegada");
        }
    }

}