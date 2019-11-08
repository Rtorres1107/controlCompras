using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsertarDepartamento : System.Web.UI.Page
{
    Class1 clase = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
            
            llenarempresa();
        
    }

    public void llenarempresa(){
        DDLEmpresa.ClearSelection();
        DDLEmpresa.DataSource = clase.llenarempresa();
        DDLEmpresa.DataTextField = "nombreEmpresa";
        DDLEmpresa.DataValueField = "idempresa";
        DDLEmpresa.DataBind();

    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Write(clase.InsertarDepartamento(txtDepartamento.Text,Convert.ToInt32(DDLEmpresa.SelectedValue)));
            LimpiarCampos();
        }
        catch (Exception ex)
        {

            Response.Write("Error al Insertar..." + ex.Message.ToString());
            return;
        }

    }
    protected void LimpiarCampos()
    {
        txtDepartamento.Text = "";
        DDLEmpresa.ClearSelection();
    }
}