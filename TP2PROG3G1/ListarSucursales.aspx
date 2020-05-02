<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarSucursales.aspx.cs" Inherits="TP2PROG3G1.Actividad3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1031px;
            height: 60px;
        }
        .auto-style2 {
            width: 333px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 451px;
        }
        .auto-style5 {
            width: 359px;
        }
        .auto-style6 {
            width: 175px;
        }
        .auto-style7 {
            width: 87%;
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
        <p>
            &nbsp;</p>
        <table class="auto-style3">
            <tr>
                <td><strong>Listado de sucursales</strong></td>
            </tr>
        </table>
        <p>
            <br />
        </p>
        <table class="auto-style7">
            <tr>
                <td class="auto-style4">Busqueda ingrese ID sucursal</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtIngreseSucursal" runat="server" Width="346px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" Width="135px" OnClick="btnFiltrar_Click1" />
                </td>
                <td>
                    <asp:Button ID="btnMostrar" runat="server" Text="Mostrar todos" Width="161px" OnClick="btnMostrar_Click1" />
                </td>
            </tr>
        </table>
        <p>
            <asp:GridView ID="grdListadoSucursal" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
