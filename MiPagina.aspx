<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MiPagina.aspx.cs" Inherits="Numero.MiPagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Numerología</title>
    <script>
        function formatFecha(textBox) {
            var inputValue = textBox.value;
            
            if (inputValue.length === 2 || inputValue.length === 5) {
                textBox.value = inputValue + '/';
            }
        }
    </script>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style5 {
            text-align: right;
            height: 28px;
        }
        .auto-style6 {
            height: 28px;
        }
        .auto-style7 {
            height: 34px;
        }
        .auto-style8 {
            width: 881px;
        }
        .auto-style9 {
            height: 28px;
            width: 881px;
        }
        .auto-style10 {
            height: 26px;
            width: 881px;
        }
        .auto-style11 {
            height: 34px;
            width: 881px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <br />
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblApellidos" runat="server" Text="Herencia - Apellido/s:"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="tbApellidos" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre/s:"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" Width="148px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblFechadeNac" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                </td>
                <td class="auto-style9">
            <asp:TextBox ID="txtFecha" runat="server" oninput="formatFecha(this)" placeholder="DD/MM/YYYY"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style10">
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style11">
                    <asp:Label ID="lblResultado" runat="server" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="lblVibracionAnual" runat="server" OnClick="lblVibracionAnual_Click" Text="Vibracion Anual" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="btnAuto" runat="server" OnClick="btnAuto_Click" Text="Auto motivacion/imagen/expresion" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblVibracioncasas" runat="server" Text="Nombre y numeración:"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="tbCasas" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="btnCalcularCasa" runat="server" OnClick="btnCalcularCasa_Click" Text="Calcular" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <div>
            </div>
        </div>
    </form>
</body>
</html>
