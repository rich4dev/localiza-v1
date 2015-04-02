<%@ Page Title="Registrar Envio" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Envio.aspx.cs" Inherits="WebLocaliza.Account.Envio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblcodigo" runat="server" Text="Codigo Envio"></asp:Label>
    <br />
    <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbldni" runat="server" Text="Dni Cliente"></asp:Label>
    <br />
    <asp:TextBox ID="txtdni" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblcantidad" runat="server" Text="Cantidad"></asp:Label>
    <br />
    <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblcodigo2" runat="server" Text="Peso"></asp:Label>
    <br />
    <asp:TextBox ID="txtpeso" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblcodigo3" runat="server" Text="Lugar Origen"></asp:Label>
    <br />
    <asp:DropDownList ID="cboorigen" runat="server" Height="25px" Width="121px">
            <asp:ListItem>Lima</asp:ListItem>
            <asp:ListItem>Callao</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lblcodigo4" runat="server" Text="Lugar Destino"></asp:Label>
    <br />
    <asp:DropDownList ID="cbodestino" runat="server" Height="25px" Width="121px">
             <asp:ListItem>Lima</asp:ListItem>
            <asp:ListItem>Callao</asp:ListItem>
             <asp:ListItem>Trujillo</asp:ListItem>
            <asp:ListItem>Piura</asp:ListItem>
             <asp:ListItem>Chiclayo</asp:ListItem>
            <asp:ListItem>Lambayeuqe</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lbltransporte" runat="server" Text="Transporte"></asp:Label>
    <br />
    <asp:DropDownList ID="cbotransporte" runat="server" Height="25px" Width="121px">
             <asp:ListItem value="1">Tranporte1</asp:ListItem>
            <asp:ListItem value="2">Tranporte2</asp:ListItem>
             <asp:ListItem value="3">Tranporte3</asp:ListItem>
            <asp:ListItem value="4"> Tranporte4</asp:ListItem>
             <asp:ListItem value="5">Tranporte5</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="btnregistrar" runat="server" CommandName="Login" 
    Text="Registrar"   onclick="LoginButton_Click"/>
              
</asp:Content>
