<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="Envios.aspx.vb" Inherits="Localiza_VB.Envios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section>
            DNI Cliente<br />
            <asp:TextBox ID="E_DNI" runat="server"></asp:TextBox>
            <br />
            Tipo envío<br />
&nbsp;<asp:DropDownList ID="E_TipoEnvio" runat="server">
    <asp:ListItem>PAQUETE</asp:ListItem>
    <asp:ListItem>SOBRE</asp:ListItem>
            </asp:DropDownList>
            <br />
    <br />
    Cantidad<br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Peso<br />
            <asp:TextBox ID="E_Peso" runat="server"></asp:TextBox>
            <br />
            Destino Inicio<br />
            <asp:DropDownList ID="E_DestinoIni" runat="server">
                <asp:ListItem>LIMA</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Destino fin<br />
            <asp:DropDownList ID="E_DestinoF" runat="server">
                <asp:ListItem>AREQUIPA</asp:ListItem>
                <asp:ListItem>LAMBAYEQUE</asp:ListItem>
                <asp:ListItem>LA LIBERTAD</asp:ListItem>
                <asp:ListItem>CUSCO</asp:ListItem>
                <asp:ListItem>PUCALLPA</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Añadir unidad transporte<br />
        <asp:GridView ID="E_ListaUnidadTransporte" runat="server">
            <Columns>
                    <asp:BoundField HeaderText="Placa" />
                    <asp:BoundField HeaderText="Chofer" />
                    <asp:BoundField HeaderText="Fecha salida" />
                    <asp:BoundField HeaderText="Fecha de llegada" />
                    <asp:ButtonField Text="Asignar" />
                    <asp:BoundField HeaderText="Capacidad Disponible" />
            </Columns>
            </asp:GridView>
            <asp:Button ID="E_Guardar" runat="server" Text="Guardar" />
            <br />
</section>
</asp:Content>
