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
        .auto-style8 {
            width: 405px;
        }
        .auto-style9 {
            height: 28px;
            width: 405px;
        }
        .auto-style10 {
            height: 26px;
            width: 405px;
        }
        .auto-style21 {
            height: 25px;
            width: 405px;
        }
        .auto-style26 {
            text-align: center;
        }
        .auto-style27 {
            height: 26px;
            width: 421px;
        }
        .auto-style28 {
            width: 421px;
        }
        .auto-style29 {
            height: 28px;
            width: 421px;
        }
        .auto-style31 {
            height: 25px;
            width: 421px;
        }
        .auto-style32 {
            height: 10px;
            width: 421px;
        }
        .auto-style33 {
            height: 10px;
            width: 405px;
        }
        .auto-style34 {
            width: 421px;
            height: 31px;
        }
        .auto-style35 {
            width: 405px;
            height: 31px;
        }
        .auto-style36 {
            width: 421px;
            height: 39px;
        }
        .auto-style37 {
            width: 405px;
            height: 39px;
        }
        .auto-style38 {
            margin-bottom: 0px;
        }
        .auto-style39 {
            width: 421px;
            height: 34px;
        }
        .auto-style40 {
            width: 405px;
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="auto-style26">
            Numerologia Pitagorica<br />
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style27">
                    &nbsp;</td>
                <td class="auto-style10">
                    <asp:HyperLink ID="HlTantrica" runat="server" NavigateUrl="~/MiPaginaTantrica.aspx">Ir a Numerologia Tántrica</asp:HyperLink>
                    </td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="lblApellidos" runat="server" Text="Herencia - Apellido/s:"></asp:Label>
                    <asp:TextBox ID="tbApellidos" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre/s:"></asp:Label>
                    <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="lblFechadeNac" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
            <asp:TextBox ID="txtFecha" runat="server" oninput="formatFecha(this)" placeholder="DD/MM/YYYY"></asp:TextBox>
                </td>
                <td class="auto-style40">
                    </td>
            </tr>
            <tr>
                <td class="auto-style27">
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">
                    Vibracion de las Casas.<br />
                    <asp:Label ID="lblVibracioncasas" runat="server" Text="Ingrese Nombre y numeración:"></asp:Label>
                    <asp:TextBox ID="tbCasas" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    Planos:<asp:Button ID="btnPlanos" runat="server" OnClick="btnPlanos_Click" Text="Ver Como Trabajan los Numeros en mis Planos" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="lblResultado" runat="server" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="lbl_Planos" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Button ID="btn_Numeroalma" runat="server" OnClick="btn_Numeroalma_Click" Text="Numero de Alma" />
                    <br />
                    Numero de Alma o Destino
                    <br />
                    <asp:Label ID="IntroducciónNumeroAlma" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="Introducción" runat="server"></asp:Label>
                    <br />
                    <asp:GridView ID="gvNumerodealma" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Número de Alma">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_Numerodealma" runat="server" Text='<%# Bind("Info") %>'></asp:Label>
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
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style32">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Influencia del Dia y Mes" />
                </td>
                <td class="auto-style33">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style32">
                    <asp:GridView ID="gvInfluenciaDia" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Influencia del Dia">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_NumeroInfluenciaDia" runat="server" Text='<%# Bind("Dia") %>'></asp:Label>
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
                <td class="auto-style33">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style32">
                    <asp:GridView ID="gvInfluenciaMes" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Influencia del Mes">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_NumeroInfluenciaMes" runat="server" Text='<%# Bind("Info") %>'></asp:Label>
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
                <td class="auto-style33">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <br />
                    <asp:Button ID="btnDesafios" runat="server" OnClick="btnDesafios_Click" Text="Averiguar Desafios" />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónADesafio" runat="server"></asp:Label>
                    <asp:GridView ID="gvPrimerdesafio" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="Desafio" HeaderText="Desafio" />
                            <asp:BoundField DataField="Info" HeaderText="Información" />
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
                    <asp:Label ID="lbl_Rangodesafio1" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvSegundodesafio" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <asp:Label ID="lbl_Rangodesafio2" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:GridView ID="gvTercerdesafio" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <asp:Label ID="lbl_Rangodesafio3" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style34">
                    <asp:GridView ID="gvCuartodesafio" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <asp:Label ID="lbl_Rangodesafio4" runat="server"></asp:Label>
                </td>
                <td class="auto-style35">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btnPinaculos" runat="server" OnClick="btnPinaculos_Click" Text="Averiguar Pinaculos" />
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAPinaculos" runat="server"></asp:Label>
                    <asp:GridView ID="gvPrimerpinaculo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <asp:Label ID="lbl_Rangopinaculo1" runat="server"></asp:Label>
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvSegundopinaculo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <asp:Label ID="lbl_Rangopinaculo2" runat="server"></asp:Label>
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvTercerpinaculo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <asp:Label ID="lbl_Rangopinaculo3" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvCuartopinaculo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <asp:Label ID="lbl_Rangopinaculo4" runat="server"></asp:Label>
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btn_Periodo52" runat="server" OnClick="btn_Periodo52_Click" Text="Ver mis Periodos de 52 Dias" />
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAPeriodos52Dias" runat="server"></asp:Label>
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="lbl_Periodos52" runat="server"></asp:Label>
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style36">
                    <asp:DataList ID="dlPeriodo52" runat="server" CellPadding="4" DataSourceID="SqlDataSourcePeriodo52" ForeColor="#333333">
                        <AlternatingItemStyle BackColor="White" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <ItemStyle BackColor="#E3EAEB" />
                        <ItemTemplate>
                            <asp:Label ID="lbl_Periodo1" runat="server" Text='<%# Bind("1") %>'></asp:Label>
                            <br />
                            <asp:Label ID="lbl_Periodo2" runat="server" Text='<%# Bind("2") %>'></asp:Label>
                            <br />
                            <asp:Label ID="lbl_Periodo3" runat="server" Text='<%# Bind("3") %>'></asp:Label>
                            <br />
                            <asp:Label ID="lbl_Periodo4" runat="server" Text='<%# Bind("4") %>'></asp:Label>
                            <br />
                            <asp:Label ID="lbl_Periodo5" runat="server" Text='<%# Bind("5") %>'></asp:Label>
                            <br />
                            <asp:Label ID="lbl_Periodo6" runat="server" Text='<%# Bind("6") %>'></asp:Label>
                            <br />
                            <asp:Label ID="lbl_Periodo7" runat="server" Text='<%# Bind("7") %>'></asp:Label>
                            <br />
                        </ItemTemplate>
                        <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSourcePeriodo52" runat="server" ConnectionString="<%$ ConnectionStrings:NumTantricaConnectionString %>" SelectCommand="SELECT * FROM [Periodos_52_dias]"></asp:SqlDataSource>
                </td>
                <td class="auto-style37">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">
                    <asp:Button ID="btnRetoCapsula" runat="server" OnClick="btnRetoCapsula_Click" Text="Averiguar Capsula" />
                </td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónACapsula" runat="server"></asp:Label>
                    <asp:GridView ID="gvCapsula" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
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
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btn_Autoexpresion" runat="server" OnClick="btn_Autoexpresion_Click" Text="Auto Expresión - Auto Imagen - Auto Motivación " />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAAutomotivacion" runat="server"></asp:Label>
                    <asp:GridView ID="gvAutoMotivacion" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAAutoimagen" runat="server"></asp:Label>
                    <asp:GridView ID="gvAutoImagen" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAAutoexpresion" runat="server"></asp:Label>
                    <asp:GridView ID="gvAutoExpresion" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónARetoAutoMotivacion" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvRetoAutoMotivacionAdicional" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónARetoAutoImagen" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvRetoAutoImagenAdicional" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónARetoAutoExpresion" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvRetoExpresionAdicional" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btn_VibracionesAnuales" runat="server" OnClick="btn_VibracionesAnuales_Click" Text="Vibraciones Anuales Personales" />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAVibracionesAnuales" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lbl_VibracionesAnuales" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvVibracionAnualPersonal" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btnHerencia" runat="server" OnClick="btnHerencia_Click" Text="Averiguar Herencia" />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAHerencia" runat="server"></asp:Label>
                    <br />
                    <asp:GridView ID="gvHerencia" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
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
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btnVibracionCasas" runat="server" OnClick="btnVibracionCasas_Click" Text="Vibración de las Casas" />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAVibraciónDeLasCasas" runat="server"></asp:Label>
                    <asp:GridView ID="gvVibracionCasas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btn_Aspectos" runat="server" OnClick="btn_Aspectos_Click" Text="Ver Aspectos" CssClass="auto-style38" />
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:GridView ID="gvAspectodelasletras" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Letra" HeaderText="Letra" />
                            <asp:BoundField DataField="Fisico" HeaderText="Fisico" />
                            <asp:BoundField DataField="Afectivo" HeaderText="Afectivo" />
                            <asp:BoundField DataField="Espiritual" HeaderText="Espiritual" />
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
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btnPersonal" runat="server" OnClick="btnPersonal_Click" Text="Año - Mes - Dia Personal" />
                    <br />
                    </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónDiaPersonal" runat="server"></asp:Label>
                    <asp:GridView ID="gvDiapersonal" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónMesPersonal" runat="server"></asp:Label>
                    <asp:GridView ID="gvMespersonal" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="IntroducciónAñoPersonal" runat="server"></asp:Label>
                    <asp:GridView ID="gvAniopersonal" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="Anio_Personal" HeaderText="Año Personal" />
                            <asp:BoundField DataField="Info" HeaderText="Información" />
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
                    <br />
                    </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <br />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
