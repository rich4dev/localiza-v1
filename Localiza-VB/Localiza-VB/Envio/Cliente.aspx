<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="Cliente.aspx.vb" Inherits="Localiza_VB.Cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section>
            DNI<br />
            <asp:TextBox ID="C_DNI" runat="server"></asp:TextBox>
<asp:Button ID="C_Consultar" runat="server" Text="Consultar" />
            <br />
            Nombre<br />
            <asp:TextBox ID="C_Nombre" runat="server"></asp:TextBox>
            <br />
            Apellido Paterno<br />
            <asp:TextBox ID="C_ApPaterno" runat="server"></asp:TextBox>
            <br />
            Apellido Materno<br />
            <asp:TextBox ID="C_ApeMaterno" runat="server"></asp:TextBox>
            <br />
            Género<br />
            <asp:DropDownList ID="C_Genero" runat="server">
                <asp:ListItem>Femenino</asp:ListItem>
                <asp:ListItem>Masculino</asp:ListItem>
            </asp:DropDownList>
            <br />
            Email<br />
            <asp:TextBox ID="C_Correo" runat="server"></asp:TextBox>
            <br />
            Teléfono<br />
            <asp:TextBox ID="C_Telefono" runat="server"></asp:TextBox>
            <br />
            Distrito<br />
            <asp:DropDownList ID="C_Distrito" runat="server">
                <asp:ListItem>LIMA</asp:ListItem>
                <asp:ListItem>ANCON</asp:ListItem>
                <asp:ListItem>ATE</asp:ListItem>
                <asp:ListItem>BREÑA</asp:ListItem>
                <asp:ListItem>CARABAYLLO</asp:ListItem>
                <asp:ListItem>COMAS</asp:ListItem>
                <asp:ListItem>CHACLACAYO</asp:ListItem>
                <asp:ListItem>CHORRILLOS</asp:ListItem>
                <asp:ListItem>LA VICTORIA</asp:ListItem>
                <asp:ListItem>LA MOLINA</asp:ListItem>
                <asp:ListItem>LINCE</asp:ListItem>
                <asp:ListItem>LURIGANCHO</asp:ListItem>
                <asp:ListItem>LURIN</asp:ListItem>
                <asp:ListItem>MAGDALENA DEL MAR</asp:ListItem>
                <asp:ListItem>MIRAFLORES</asp:ListItem>
                <asp:ListItem>PACHACAMAC</asp:ListItem>
                <asp:ListItem>PUEBLO LIBRE</asp:ListItem>
                <asp:ListItem>PUCUSANA</asp:ListItem>
                <asp:ListItem>PUENTE PIEDRA</asp:ListItem>
                <asp:ListItem>PUNTA HERMOSA</asp:ListItem>
                <asp:ListItem>PUNTA NEGRA</asp:ListItem>
                <asp:ListItem>RIMAC</asp:ListItem>
                <asp:ListItem>SAN BARTOLO</asp:ListItem>
                <asp:ListItem>SAN ISIDRO</asp:ListItem>
                <asp:ListItem>BARRANCO</asp:ListItem>
                <asp:ListItem>SAN MARTIN DE PORRES</asp:ListItem>
                <asp:ListItem>SAN MIGUEL</asp:ListItem>
                <asp:ListItem>SANTA MARIA DEL MAR</asp:ListItem>
                <asp:ListItem>SANTA ROSA</asp:ListItem>
                <asp:ListItem>SANTIAGO DE SURCO</asp:ListItem>
                <asp:ListItem>SURQUILLO</asp:ListItem>
                <asp:ListItem>VILLA MARIA DEL TRIUNFO</asp:ListItem>
                <asp:ListItem>JESUS MARIA</asp:ListItem>
                <asp:ListItem>INDEPENDENCIA</asp:ListItem>
                <asp:ListItem>EL AGUSTINO</asp:ListItem>
                <asp:ListItem>SAN JUAN DE MIRAFLORES</asp:ListItem>
                <asp:ListItem>SAN JUAN DE LURIGANCHO</asp:ListItem>
                <asp:ListItem>SAN LUIS</asp:ListItem>
                <asp:ListItem>CIENEGUILLA</asp:ListItem>
                <asp:ListItem>SAN BORJA</asp:ListItem>
                <asp:ListItem>VILLA EL SALVADOR</asp:ListItem>
                <asp:ListItem>LOS OLIVOS</asp:ListItem>
                <asp:ListItem>SANTA ANITA</asp:ListItem>
            </asp:DropDownList>
            <br />
            Dirección<br />
            <asp:TextBox ID="C_Direccion" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="C_Guardar" runat="server" Text="Guardar" />
            <asp:Label id="lbltexto" runat="server"/>

 </section>
</asp:Content>
