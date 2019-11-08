<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="Empresa.aspx.cs" Inherits="Consultas" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1>Consultar Empresa</h1>
        <p>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSucursal" runat="server" Text="Sucursal:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSucursal" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="Insertar" />
&nbsp;
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click1" />
&nbsp;
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        </p>
        <p>
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            <asp:Label ID="lblIdEmpresa" runat="server" Visible="False"></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server"  OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>