<%@ Page Title="" Language="C#" MasterPageFile="~/Mestra.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="Murmurio.Visual.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ConteudoPrincipal">
        <asp:Label ID="Label1" runat="server" Text="Pagina de Longin" BackColor="White" Font-Bold="True"
            Font-Size="Larger"></asp:Label>

            <iframe src="Principal.aspx" class="black-35" frameborder="0" scrolling="no" style="background-color: Transparent"></iframe>

        <asp:Login ID="ctlLogin" runat="server" OnAuthenticate="Autenticar">
        </asp:Login>
    </div>
</asp:Content>
