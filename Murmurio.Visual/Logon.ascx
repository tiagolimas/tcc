<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Logon.ascx.cs" Inherits="Murmurio.Visual.Logon" %>
<link href="css/screen.css" rel="stylesheet" type="text/css"></link>
<div id="ConteudoPrincipalLogin" style="clip: rect(auto, auto, auto, auto); width: 260px;
    margin-right: 0px;">
    <div style="width: 185px; left:60px; position:Absolute; top:40px;" >
        <asp:Login ID="ControleLogin" runat="server" OnAuthenticate="Autenticar" BackColor="Transparent"
            ForeColor="White" VisibleWhenLoggedIn="True" FailureText="Dados incorretos."
            LoginButtonText="Entrar" RememberMeText="Lembrar" TextLayout="TextOnTop" TitleText="Login">
            <LoginButtonStyle BackColor="Transparent" ForeColor="White" />
            <TextBoxStyle BackColor="Transparent" ForeColor="White" />
        </asp:Login>
    </div>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" Font-Italic="True"
        NavigateUrl="~/Cadastro.aspx" style=" left:60px; position:absolute; top:230px;">
             Cadastre-se
    </asp:HyperLink>
</div>
