<%@ Page Title="M u r m ú r i o" Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs"
    Inherits="Murmurio.Visual.Principal" %>

<%@ MasterType VirtualPath="Mestra.Master" %>
<%@ Register src="Logon.ascx" tagname="Logon" tagprefix="uc1" %>
<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">--%>
<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>M u r m ú r i o</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    </link>
    <link rel="icon" type="image/png" href="/media/layout/favicon.png"></link>
    <link href="css/screen.css" rel="stylesheet" type="text/css"></link>
    <script src="jquery-2.0.2.js" type="text/javascript"></script>
    <script type="text/javascript" charset="utf-8" src="js/jquery.tubular.1.0.js"></script>
    <script type="text/javascript" charset="utf-8" src="js/index.js"></script>
    
    <script type="text/javascript">

                function myFunction() {
                    //alert("Hello World!");
                    $("#telaPrincipal").load('../Logon.ascx');
                    $("#telaPrincipal")
                       .text("Logon");
                };


                function ChamaPerfil() {
                    //alert("Hello World!");
                    $("#telaPrincipal").load('../Perfil.aspx');
                    $("#telaPrincipal")
                       .text("Logon");
                };

     </script>
    <!-- 			<script>
			
			  window.fbAsyncInit = function() {
				// init the FB JS SDK
				FB.init({
				  appId      : 'YOUR_APP_ID',                        // App ID from the app dashboard
				  channelUrl : '//WWW.YOUR_DOMAIN.COM/channel.html', // Channel file for x-domain comms
				  status     : true,                                 // Check Facebook Login status
				  xfbml      : true                                  // Look for social plugins on the page
				});

				// Additional initialization code such as adding Event Listeners goes here
			  };
			
			(function(d, s, id) {
		  var js, fjs = d.getElementsByTagName(s)[0];
		  if (d.getElementById(id)) return;
		  js = d.createElement(s); js.id = id;
		  js.src = "http://connect.facebook.net/pt_BR/all.js#xfbml=1";
		  fjs.parentNode.insertBefore(js, fjs);
		}(document, 'script', 'facebook-jssdk'));</script>
	 -->
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper" class="clearfix">
        <div class="geral">
              <a href="#">
                    <img src="media/Murmurio.gif" alt="somno" id="logo" /></a>
                <p id="video-controls" class="black-50">
                    <a href="#" class="tubular-play"><b>></b></a> &nbsp;&nbsp; <a href="#" class="tubular-pause">
                        <b>||</b></a> &nbsp;&nbsp; <a href="#" class="tubular-volume-up">+</a> &nbsp;&nbsp;
                    <a href="#" class="tubular-volume-down">-</a> &nbsp;&nbsp; <a href="#" class="tubular-mute">
                        M</a>
                </p>
            <!--LEFT-------------------------------------------------------------------------------------------------------------------------->
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <div id="main">
                <div id="info" class="black-35">
                    <h4 id="cantor">
                        - <em id="faixa">- </em>
                    </h4>
                </div>
                <div id="telaPrincipal" class="black-35">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" Visible="True">
                        <ContentTemplate>
<%--                            <asp:TextBox ID="TextBox1" runat="server" BackColor="Transparent" AutoPostBack="True"
                                ForeColor="White" Height="67px" TextMode="MultiLine" Width="313px"></asp:TextBox>--%>
                            <asp:Label ID="Label1" runat="server" Text="Pagina Principal"  Font-Bold="True" Font-Size="Larger"></asp:Label>
                            <asp:Button ID="Button1" runat="server" Text="Entrar" BackColor="Transparent" ForeColor="White"
                                OnClientClick="myFunction()" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <!-- RIGHT -------------------------------------------------------------------------------------------------------------------------->
            <div id="sidebar">

                

            </div>
            <!--MIDDLE-------------------------------------------------------------------------------------------------------------------------->
            <div id="sidebar2">
                <uc1:Logon ID="Logon1" runat="server" />
            </div>
            <!-- 		<iframe src="http://www.facebook.com/plugins/like.php?href=http%3A%2F%2Fjornalvdd.com%2Fjustica-determina-que-rock-rio-seja-realizado-na-bahia%2F&layout=box_count&width=62&show_faces=false&action=like&colorscheme=light&font=segoe+ui&height=62" scrolling="no" frameborder="0" style="border-top-style: none; border-right-style: none; border-bottom-style: none; border-left-style: none; border-width: initial; border-color: initial; overflow-x: hidden; overflow-y: hidden; width: 62px; height: 62px; " allowtransparency="true"></iframe>
		
		    <div class="fb-comments fb-social-plugin" data-enabled="true" data-num-posts="20" data-width="610" data-colorscheme="light" data-href="http://jornalvdd.com/justica-determina-que-rock-rio-seja-realizado-na-bahia/" data-ref="wp"></div>
     -->
            <!-- 		<div id="fb-root"></div>

		    <div class="fb-like" data-href="http://developers.facebook.com/docs/reference/plugins/like" data-width="450" data-show-faces="true" data-send="true"></div>
		
		     -->
        </div>
    </div>
    </form>
</body>
</html>
