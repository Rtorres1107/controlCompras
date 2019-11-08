using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Compras : System.Web.UI.Page
{
    ControlComprasDataContext compras = new ControlComprasDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            LlenarCompra();
        }
    }
    protected void LlenarCompra()
    {
        GridView1.DataSource = LlamaCompra();
        GridView1.DataBind();
    }


    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        int resultado = 0;
        resultado = compras.Sp_InserCompras(Convert.ToDecimal(txtmonto.Text), Convert.ToDateTime(txtfecha_factu.Text), txtn_factu.Text, txtproducto.Text, Convert.ToDecimal(txtprecio_uni.Text), Convert.ToDecimal(txtprecio_venta.Text), Convert.ToInt32(txtcantidad.Text), Convert.ToDateTime(txtfecha_salida.Text), Convert.ToDateTime(txtfecha_entrada.Text), Convert.ToInt32(txtcuentaxpagar.Text));
        try
        {
            Response.Write("Insertado con exito");
            LlenarCompra();
            LimpiarCampos();
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
   

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(lblCompras.Text);
        compras.Sp_ElimCompra(id);
        LlenarCompra();
        LimpiarCampos();
    }

    protected void btnactualizar_Click(object sender, EventArgs e)
    {
         compras.Sp_ActuaCompra(Convert.ToInt32(lblCompras.Text), Convert.ToDecimal(txtmonto.Text), Convert.ToDateTime(txtfecha_factu.Text), txtn_factu.Text, txtproducto.Text, Convert.ToDecimal(txtprecio_uni.Text), Convert.ToDecimal(txtprecio_venta.Text), Convert.ToInt32(txtcantidad.Text), Convert.ToDateTime(txtfecha_salida.Text), Convert.ToDateTime(txtfecha_entrada.Text), Convert.ToInt32(txtcuentaxpagar.Text));
        try
        {
            Response.Write("Datos Actualizados");
            LlenarCompra();
            LimpiarCampos();
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
            Response.Write("Datos no Actualizados");
        }
    }
    protected void LimpiarCampos()
    {
        txtmonto.Text = "";
        txtfecha_factu.Text = "";
        txtn_factu.Text = "";
        txtproducto.Text = "";
        txtprecio_uni.Text = "";
        txtprecio_venta.Text = "";
        txtcantidad.Text = "";
        txtfecha_salida.Text = "";
        txtfecha_entrada.Text = "";
        txtcuentaxpagar.Text = "";
    }
    public List<spTodasComprasResult> LlamaCompra()
    {
        var llamar = compras.spTodasCompras();
        return llamar.ToList();
    }

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        TableCell celda = GridView1.Rows[e.NewSelectedIndex].Cells[1];
        Buscar(Convert.ToInt32(celda.Text));
    }

    public void Buscar(int id)
    {
        try
        {
            LlenarCompra();
            LimpiarCampos();
            var registro = compras.spBuscarCompra(id);

            foreach (var compra in registro)
            {
                txtmonto.Text = Convert.ToString(compra.monto_facturado);
                txtfecha_factu.Text = Convert.ToString(compra.fecha_facturacion);
                txtn_factu.Text = compra.n_factura;
                txtproducto.Text = compra.producto;
                txtprecio_uni.Text = Convert.ToString(compra.precio_uni);
                txtprecio_venta.Text = Convert.ToString(compra.precio_venta);
                txtcantidad.Text = Convert.ToString(compra.cantidad);
                txtfecha_salida.Text = Convert.ToString(compra.fecha_salida);
                txtfecha_entrada.Text = Convert.ToString(compra.fecha_entrada);
                txtcuentaxpagar.Text = Convert.ToString(compra.id_cuentasxpagar);
                lblCompras.Text = compra.id_compras.ToString();
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}