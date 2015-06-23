<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Murmurio.Visual.Usuario1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript" charset="utf-8" src="js/jquery.tubular.1.0.js"></script>
    <%--<script type="text/javascript" charset="utf-8" src="js/index.js"></script>--%>

    <link href="css/screen.css" rel="stylesheet" type="text/css"></link>
    <link href="css/usuarioPerfil.css" rel="stylesheet" type="text/css"></link>

    <%@ Register Src="~/Controles/Amigos.ascx" TagName="Amigos" TagPrefix="Uc1" %>
    <%@ Register Src="~/Controles/PedidosAmizade.ascx" TagName="PedidosAmizade" TagPrefix="Uc2" %>
    <%@ Register Src="~/Controles/MsgUsuario.ascx" TagName="MsgUsuario" TagPrefix="Uc3" %>
    
     <%-- window.top.location.href = window.top.location.href;--%>
    
    <script type="text/javascript">
    
        function recarregaPagina(info) {
           
            window.parent.TunelMaster(info);            
        }

    </script>

</head>
<body style="background-color: Transparent">
    <form id="form1" runat="server">
    <div id="UsuarioPerfil">
        <asp:ImageButton ID="ImagemUsuario" runat="server" Height="85px" ImageAlign="Left"
            Width="80px"  BackColor="Transparent" />
        <div style="height: 88px">
            <asp:Label ID="LblNomeUsuario" runat="server" Font-Bold="True" 
                Font-Size="X-Small" ForeColor="#CCFFCC" ></asp:Label>
            <br/>
            <asp:Button ID="btnVideos" runat="server" Text="Vídeos" BackColor="Transparent" ForeColor="White" OnClientClick="reloadPage()" />
            <asp:Button ID="btnAdd" runat="server" Text="Add" BackColor="Transparent" ForeColor="Green" OnClick="AddAmigo_Click" />
            
            <br/>
               <asp:Label ID="lblErro" runat="server" Font-Bold="True" Visible="False" Font-Size="X-Small" ForeColor="#FFCCCC" ></asp:Label>
            <br/>

            <asp:DropDownList ID="ddlAlbuns" runat="server" BackColor="Transparent" 
                ForeColor="White"></asp:DropDownList>
           
        </div>
 
        <asp:Label ID="lblDescricao" runat="server" 
            Text="Gosto de Arte, assim me aproximo de algo superior" 
            ForeColor="White" Font-Italic="True" Font-Size="Smaller"></asp:Label>

        <asp:TextBox ID="txtMurmurar" runat="server" CssClass="textbox" 
            TextMode="MultiLine" BackColor="Transparent"></asp:TextBox>

        <asp:Button ID="btnMurmurar" runat="server" Text="Murmurar" 
            BackColor="Transparent" ForeColor="White"
                OnClientClick="myFunction()" onclick="btnMurmurar_Click" />

        <div id="Mural">
            
            <%-- <asp:TextBox ID="txtMural" runat="server" CssClass="textbox" TextMode="MultiLine" BackColor="Transparent"></asp:TextBox> --%>
            
            <%--<asp:ListBox ID="listMural" runat="server" AutoPostBack="True" BackColor="Transparent"></asp:ListBox>--%>

            <Uc3:MsgUsuario ID="MsgUsuario" BackColor="Transparent" runat="server" />

        </div>

        <div id="ContainerAmigos">
            
            <Uc1:Amigos ID="Amigos" BackColor="Transparent" runat="server" />

        </div>

        <div id="ContainerPedidosAmizade">
            
            <Uc2:PedidosAmizade ID="PedidosAmizade" BackColor="Transparent" runat="server" />
            
        </div>
  
    </div>
    </form>
</body>
</html>
