<%@ Page Title="" Language="C#" MasterPageFile="~/Mestra.Master" AutoEventWireup="true"
    CodeBehind="Perfil.aspx.cs" Inherits="Murmurio.Visual.Perfil" %>

<%@ Register src="Logon.ascx" tagname="Logon" tagprefix="uc1" %>

<%@ Register src="Usuario.ascx" tagname="Usuario" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--    <head id="Head1" runat="server">--%>
    <%-- <title>M u r m ú r i o</title>--%>
    <%--  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="css/screen.css" rel="stylesheet" type="text/css"></link>
        <script src="jquery-2.0.2.js" type="text/javascript"></script>--%>
    <%--    </head>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
    </asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <div id="ConteudoPrincipal">
                <%--<div class="black-35">
                    <br />
                    <uc1:Logon ID="Logon1" runat="server" />
                    <uc2:Usuario ID="Usuario1" runat="server" />
                    <br />
                    <br />
                </div>--%>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
