<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP2PROG3G1.Actividad1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 333px;
        }
        .auto-style4 {
            width: 499px;
        }
        .auto-style5 {
            width: 499px;
            height: 116px;
        }
        .auto-style6 {
            height: 116px;
        }
        .auto-style7 {
            width: 100%;
            height: 348px;
        }
        .auto-style8 {
            width: 499px;
            height: 60px;
        }
        .auto-style9 {
            height: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;<asp:HyperLink ID="hlAgregarSuc" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hlListadoSuc" runat="server" NavigateUrl="~/ListarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlEliminarSuc" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td>GRUPO N</td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <table class="auto-style7">
            <tr>
                <td class="auto-style4"><strong>AGREGAR SUCURSAL</strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Nombre sucursal: </td>
                <td>
                    <asp:TextBox ID="txtNombresc" runat="server" Width="276px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Descripcion:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtDesc" runat="server" Height="82px" Width="282px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Provincia:</td>
                <td>
                    <asp:DropDownList ID="ddlpcias" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Direccion:</td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="Aceptar" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
