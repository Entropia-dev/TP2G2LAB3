<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP2PROG3G1.Actividad2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 839px;
        }
        .auto-style3 {
            width: 333px;
        }
        .auto-style4 {
            width: 224px;
        }
        .auto-style5 {
            width: 100%;
            height: 28px;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 258px;
        }
        .auto-style8 {
            width: 203px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Agregar Sucursal </td>
                    <td class="auto-style3">Listado de sucursales</td>
                    <td class="auto-style4">Eliminar sucursal</td>
                </tr>
            </table>
        </div>
        <table class="auto-style5">
            <tr>
                <td><strong>Eliminar sucursales</strong></td>
            </tr>
        </table>
        <table class="auto-style6">
            <tr>
                <td class="auto-style7">Ingrese la id de sucursal</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox1" runat="server" Width="424px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" Width="188px" />
                </td>
            </tr>
        </table>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
