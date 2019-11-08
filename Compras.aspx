<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Compras.aspx.cs" Inherits="Compras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Compras</h1>
        <br />
        <table style="width: 70%;">
            <tr>
                <td>Monto_facturado:</td>
                <td>
                    <asp:TextBox ID="txtmonto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fecha_facturacion:</td>
                <td>
                    <asp:TextBox ID="txtfecha_factu" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>N_factura:</td>
                <td>
                    <asp:TextBox ID="txtn_factu" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Producto:</td>
                <td>
                    <asp:TextBox ID="txtproducto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Precio_Unitario:</td>
                <td>
                    <asp:TextBox ID="txtprecio_uni" runat="server"></asp:TextBox>
                </td>
                <tr>
                   <td>Precio_Venta:</td>
                   <td>
                     <asp:TextBox ID="txtprecio_venta" runat="server"></asp:TextBox>
                   </td>
                </tr>
                 <tr>
                 <td>Cantidad:</td>
                <td>
                    <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
           
                </td>
               </tr>
                      <td>Fecha_Salida:</td>
                <td>
                    <asp:TextBox ID="txtfecha_salida" runat="server"></asp:TextBox>
                </td>
                <tr>
                      <td>Fecha_Entrada:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtfecha_entrada" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                      <td>ID CuentaXPagar:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtcuentaxpagar" runat="server"></asp:TextBox>
                </td>
            </tr>
          
                <td colspan="2">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    <asp:Button ID="btneliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" />
                    <asp:Button ID="btnactualizar" runat="server" OnClick="btnactualizar_Click" Text="Actualizar" />
                </td>
            
        </table>
        <asp:Label ID="lblCompras" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="146px" Width="400px" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
