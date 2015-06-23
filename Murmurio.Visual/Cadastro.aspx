<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Murmurio.Visual.Cadastro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/screen.css" rel="stylesheet" type="text/css"></link>
</head>
<body style="background-color: Transparent">
    <form id="form1" runat="server" >
    <div id="Cadastro">
        

        <asp:Label ID="Label1" runat="server" Text="Nome" ForeColor="White"></asp:Label>
        <br/>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email" ForeColor="White"></asp:Label>
        <br/>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Senha" ForeColor="White"></asp:Label>
        <br/>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Imagem" ForeColor="White"></asp:Label>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Registrar" 
            BackColor="Transparent" ForeColor="White" />
  

    </div>
    </form>
</body>
</html>
