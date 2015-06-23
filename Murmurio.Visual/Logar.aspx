<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logar.aspx.cs" Inherits="Murmurio.Visual.Logar" %>

<%@ Register Src="Logon.ascx" TagName="Logon" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/screen.css" rel="stylesheet" type="text/css"></link>
</head>
<body style="background-color: Transparent">
    <form id="form1" runat="server" style="background-color: Transparent">
    <div class="default">
        <uc1:Logon ID="Logon1" runat="server" />
        <%--        <asp:Label ID="Label1" runat="server" Text="Pagina Login" Font-Bold="True" Font-Size="Larger"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Entrar" BackColor="Transparent" 
            ForeColor="White" onclick="Button1_Click" />--%>
    </div>
    </form>
</body>
</html>
