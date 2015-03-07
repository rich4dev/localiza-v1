<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="SeguimientoEnvio.aspx.vb" Inherits="Localiza_VB.SeguimientoEnvio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
            <h1>Seguimiento de envíos</h1></hgroup>
        <section>
               <div> Codigo de envío<br />
                <asp:TextBox ID="S_Codigo" runat="server"></asp:TextBox>
                <br />
                <asp:GridView ID="S_ListaEnvio" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="Paquete" />
                        <asp:BoundField HeaderText="Destino Origen" />
                        <asp:BoundField HeaderText="Destino Final" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
    </div>
            <div>
                <iframe src="https://www.google.com/maps/embed?pb=!1m10!1m8!1m3!1d124871.60035466685!2d-76.989526941969!3d-12.027163076379997!3m2!1i1024!2i768!4f13.1!5e0!3m2!1ses-419!2spe!4v1425669541618" width="600" height="450" frameborder="0" style="border:0"></iframe>

            </div>
    </section>

</asp:Content>
