using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Consultas : System.Web.UI.Page
{
    ControlComprasDataContext Empresa = new ControlComprasDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        LlenarEmpresa();
    }
    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        int resultado = 0;
        resultado = Empresa.Sp_InserEmpresa(txtNombre.Text, txtSucursal.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
        try
        {
            lblMensaje.Text = "Empresa insertada con exito";
            LlenarEmpresa();
            Limpiar();
        }
        catch(Exception x)
        {
            lblMensaje.Text = "Empresa NO pudo ser insertada";
        }
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(lblIdEmpresa.Text);
        Empresa.Sp_ElimEmpresa(id);
        LlenarEmpresa();
        Limpiar();
    }
    public void LlenarEmpresa()
    {

        GridView1.DataSource = LlamarEmpresas();
        GridView1.DataBind();
    }
    public void Limpiar()
    {
        txtNombre.Text = "";
        txtSucursal.Text = "";
        txtDireccion.Text = "";
        txtTelefono.Text = "";
        txtCorreo.Text = "";
        lblIdEmpresa.Text = "";
    }
    public List<spTodosEmpresaResult> LlamarEmpresas()
    {
        var llamada = Empresa.spTodosEmpresa();
        return llamada.ToList();
    }
   


    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        TableCell celda = GridView1.Rows[e.NewSelectedIndex].Cells[1];
        Buscar(Convert.ToInt32(celda.Text));
    }
    public void Buscar(int id) {

        try
        {
            //LlenarEmpresa();
            //Limpiar();
            var registro = Empresa.Sp_BuscarEmpresa(id);

            foreach (var empresa in registro)
            {
                txtNombre.Text = empresa.nombre.ToString();
                txtSucursal.Text = empresa.sucursal.ToString();
                txtDireccion.Text = empresa.direccion.ToString();
                txtTelefono.Text = empresa.telefono.ToString();
                txtCorreo.Text = empresa.correo.ToString();
                lblIdEmpresa.Text = empresa.id_empresa.ToString();
            }
        }
        catch (Exception ex)
        {

            Response.Write(ex.Message);
        }
    }

    protected void btnActualizar_Click1(object sender, EventArgs e)
    {
        int resultado = 0;
        resultado = Empresa.Sp_ActuaEmpresa(Convert.ToInt32(lblIdEmpresa.Text), txtNombre.Text, txtSucursal.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
        try
        {
            lblMensaje.Text = "Empresa Actualizar con exito";
            LlenarEmpresa();
            Limpiar();
        }
        catch(Exception x)
        {
            Response.Write(x.Message);
            lblMensaje.Text = "Empresa NO pudo ser Actualizado";
        }
    }
}

