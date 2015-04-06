<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="WebLocaliza.Paginas.CambiarContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>
        Cambiar contraseña
    </h2>
    <p>
        Use el formulario siguiente para cambiar la contraseña.
    </p>
         <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <div class="accountInfo">
                <fieldset class="changePassword">
                    <legend>Información de cuenta</legend>
                    <p>
                        <asp:Label ID="lbl1" runat="server" >Contraseña anterior:</asp:Label>
                        <asp:TextBox ID="txtContraseñaActual" runat="server" CssClass="passwordEntry" 
                            TextMode="Password"></asp:TextBox>
                        
                    </p>
                    <p>
                        <asp:Label ID="lbl2" runat="server" AssociatedControlID="txtNuevaContraseña">Nueva contraseña:</asp:Label>
                        <asp:TextBox ID="txtNuevaContraseña" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                       
                    </p>
                    <p>
                        <asp:Label ID="lbl3" runat="server" AssociatedControlID="txTconfirmacionContraseña">Confirmar la nueva contraseña:</asp:Label>
                        <asp:TextBox ID="txTconfirmacionContraseña" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                    </p>
                </fieldset>
                <p class="submitButton">
                    <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" 
                        CommandName="Cancel" Text="Cancelar"/>
                    <asp:Button ID="BtnCambiar" runat="server" Text="Cambiar contraseña" 
                        />
                </p>
            </div>
</asp:Content>
