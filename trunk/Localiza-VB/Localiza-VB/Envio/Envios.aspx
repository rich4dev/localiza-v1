<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="Envios.aspx.vb" Inherits="Localiza_VB.Envios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    Codigo Envio<section><br />
            <asp:TextBox ID="E_CODIGO" runat="server"></asp:TextBox>
            <br />
    <br />
    <section>DNI<br />
            <asp:TextBox ID="E_DNI" runat="server"></asp:TextBox>
</section>
            <br />
            <br />
    Cantidad<br />
    <asp:TextBox ID="E_Cantidad" runat="server"></asp:TextBox>
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
                <asp:ListItem>RAUL QUISPE</asp:ListItem>
                <asp:ListItem>CRITHIAN PEREZ</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
    Chofer<br />
            <asp:DropDownList ID="E_Chofer" runat="server">
                <asp:ListItem>AREQUIPA</asp:ListItem>
                <asp:ListItem>LAMBAYEQUE</asp:ListItem>
                <asp:ListItem>LA LIBERTAD</asp:ListItem>
                <asp:ListItem>CUSCO</asp:ListItem>
                <asp:ListItem>PUCALLPA</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Añadir unidad transporte<br />

             <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">Transporte_1</asp:ListItem>
                <asp:ListItem Value="2">Transporte_2</asp:ListItem>
                <asp:ListItem Value="3">Transporte_3</asp:ListItem>
                <asp:ListItem Value="4">Transporte_4</asp:ListItem>
                <asp:ListItem Value="5">Transporte_5</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            
            <asp:Button ID="E_Guardar" runat="server" Text="Guardar" />
            <br />
</section>
</asp:Content>
