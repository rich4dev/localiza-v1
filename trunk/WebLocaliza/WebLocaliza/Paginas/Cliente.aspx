<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="WebLocaliza.Paginas.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="DNI"></asp:Label>
    <br />
    <asp:TextBox ID="txtdni" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <br />
    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Apellido Paterno"></asp:Label>
    <br />
    <asp:TextBox ID="txtap" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Apellido Materno"></asp:Label>
    <br />
    <asp:TextBox ID="txtam" runat="server"></asp:TextBox>
    <br />
    <br />
    Genero<br />
    <asp:DropDownList ID="cbogenero" runat="server" Height="34px" Width="123px">
               <asp:ListItem value="F">Femenino</asp:ListItem>
                <asp:ListItem value="M">Masculino</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    Email<br />
    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
    <br />
    <br />
    Telefono<br />
    <asp:TextBox ID="txtfono" runat="server"></asp:TextBox>
    <br />
    <br />
    Distrito<br />
    <asp:DropDownList ID="cbodistrito" runat="server" Height="24px" 
    Width="118px">
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
    <br />
    DIreccion<br />
    <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server"></asp:Label>
    <br />
    <asp:Button ID="btnguardar" runat="server" Text="Guardar" 
    onclick="btnguardar_Click" />
    <br />

</asp:Content>
