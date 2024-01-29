﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MiPagina.aspx.cs" Inherits="Numero.MiPagina" %>

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
            width: 375px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style5 {
            text-align: right;
            height: 28px;
            width: 375px;
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
        .auto-style12 {
            width: 375px;
        }
        .auto-style13 {
            height: 26px;
            width: 375px;
        }
        .auto-style14 {
            height: 34px;
            width: 375px;
        }
        .auto-style15 {
            text-align: right;
            width: 375px;
            height: 26px;
        }
        .auto-style16 {
            text-align: right;
            width: 375px;
            height: 32px;
        }
        .auto-style17 {
            width: 881px;
            height: 32px;
        }
        .auto-style18 {
            height: 32px;
        }
        .auto-style19 {
            text-align: center;
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
                <td class="auto-style12">&nbsp;</td>
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
                <td class="auto-style12">&nbsp;</td>
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
                <td class="auto-style13"></td>
                <td class="auto-style10">
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style11">
                    <asp:Label ID="lblResultado" runat="server" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style10">
                    <asp:Button ID="lblVibracionAnual" runat="server" OnClick="lblVibracionAnual_Click" Text="Vibracion Anual" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="btnAuto" runat="server" OnClick="btnAuto_Click" Text="Auto motivacion/imagen/expresion" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
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
                <td class="auto-style16"></td>
                <td class="auto-style17">
                    <asp:Button ID="btnCalcularCasa" runat="server" OnClick="btnCalcularCasa_Click" Text="Calcular" />
                </td>
                <td class="auto-style18"></td>
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
                <td class="auto-style2">Para saber los Aspectos de los numeros:</td>
                <td class="auto-style8">
                    <asp:Button ID="btn_Aspectos" runat="server" OnClick="btn_Aspectos_Click" Text="Ver Aspectos" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">
                    <asp:GridView ID="gvAspectodelasletras" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="A" HeaderText="Aspecto de la letra A" />
                            <asp:BoundField DataField="B" HeaderText="Aspecto de la letra B" />
                            <asp:BoundField DataField="C" HeaderText="Aspecto de la letra C" />
                            <asp:BoundField DataField="D" HeaderText="Aspecto de la letra D" />
                            <asp:BoundField DataField="E" HeaderText="Aspecto de la letra E" />
                            <asp:BoundField DataField="F" HeaderText="Aspecto de la letra F" />
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                    <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="SqlDataSourceAspectos" ForeColor="Black">
                        <AlternatingItemStyle BackColor="PaleGoldenrod" />
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <HeaderTemplate>
                            <div class="auto-style19">
                                Aspectos de las Letras<br />
                            </div>
                        </HeaderTemplate>
                        <ItemTemplate>
                            A:
                            <asp:Label ID="ALabel" runat="server" Text='<%# Eval("A") %>' />
                            <br />
                            B:
                            <asp:Label ID="BLabel" runat="server" Text='<%# Eval("B") %>' />
                            <br />
                            C:
                            <asp:Label ID="CLabel" runat="server" Text='<%# Eval("C") %>' />
                            <br />
                            D:
                            <asp:Label ID="DLabel" runat="server" Text='<%# Eval("D") %>' />
                            <br />
                            E:
                            <asp:Label ID="ELabel" runat="server" Text='<%# Eval("E") %>' />
                            <br />
                            F:
                            <asp:Label ID="FLabel" runat="server" Text='<%# Eval("F") %>' />
                            <br />
                            <br />
                        </ItemTemplate>
                        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSourceAspectos" runat="server" ConnectionString="<%$ ConnectionStrings:NumTantricaConnectionString %>" SelectCommand="SELECT [A], [B], [C], [D], [E], [F] FROM [Aspecto_de_las_letras]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <br />
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style15">PERSONALIDAD INTERNA (AUTO MOTIVACION)<br />
                    PERSONALIDAD EXTERNA (AUTO IMAGEN)<br />
                    TALENTO
                    <br />
                    (AUTO EXPRESION)<br />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="btn_Autoexpresion" runat="server" OnClick="btn_Autoexpresion_Click" Text="Auto Expresión - Auto Imagen - Auto Motivación " />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">
                    <asp:GridView ID="gvAutoexpresion" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Auto Expresión">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_autoexpresion1" runat="server" Text='<%# Bind("Info") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">
                    <asp:GridView ID="gvAutomotivacion" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Auto Motivación">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_Automotivacion" runat="server" Text='<%# Bind("Info") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">
                    <asp:GridView ID="gvAutoimagen" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Auto Imagen">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_Autoimagen" runat="server" Text='<%# Bind("Info") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
