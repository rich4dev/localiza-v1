<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.Master" AutoEventWireup="true" CodeBehind="Seguimiento.aspx.cs" Inherits="WebLocaliza.Paginas.Seguimiento" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ingresar codigo envio"></asp:Label>
<br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Button ID="btnBUscar" runat="server" Text="Buscar" 
    onclick="btnBUscar_Click" />
    <asp:Label ID="Label2" runat="server"></asp:Label>
<br />
<cc1:GMap ID="GMap1" runat="server" />
&nbsp;</asp:Content>
