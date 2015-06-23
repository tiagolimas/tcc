<%@ Page Title="" Language="C#" MasterPageFile="~/Mestra.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Murmurio.Visual.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <script type="text/javascript">

        function TrocaFrame() {
           // $(ifrPrincipal.src = "Logon.aspx");
            alert("TrocaFrame!!!");
        }

    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <iframe id="ifrPrincipal" src="Logar.aspx" class="black-35" frameborder="0" scrolling="no" 
        style="background-color: Transparent; " 
        height="300px" width="1000px" marginheight="0" marginwidth="0"></iframe>
       

</asp:Content>
