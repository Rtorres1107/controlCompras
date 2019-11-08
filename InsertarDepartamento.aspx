<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="InsertarDepartamento.aspx.cs" Inherits="InsertarDepartamento" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:Label ID="Label3" runat="server" Text="Insertar departamento"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Departamento"></asp:Label>
        <br />
        <asp:TextBox ID="txtDepartamento" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="empresa"></asp:Label>
        <br />
        <asp:DropDownList ID="DDLEmpresa" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="Insertar" />
</asp:Content>
