<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Amigos.ascx.cs" Inherits="Murmurio.Visual.Controles.Amigos" %>

<script type="text/javascript">

//    function PegaId(item) {

//        alert(item);
//    
//    }

</script>

<table cellpadding="1" cellspacing="1" width="100%" border="0" class="FriendControlBlueBorder">

    <tr>
        <td align="center">
            <asp:Label ID="lblError" runat="server" CssClass="redtext"></asp:Label>
        </td>
    </tr>
    <tr>
        <td valign="top" align="center">
            <asp:DataList ID="ListaAmigos" runat="server" Width="100%" RepeatColumns="5">
                <ItemTemplate>
                    <table border="0" cellpadding="0" cellspacing="0" align="center" style="background-color: Transparent">
                        <tr>
                            <td align="center" valign="top">
                                <a href='<%#getHREF(Container.DataItem)%>' onClick='<%#PegaId(Container.DataItem)%>'>
                                    <img src='<%# getSRC(Container.DataItem) %>' align="middle" border="0" width="50px" >
                                </a>
                                    &nbsp;&nbsp;
                             </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </td>
    </tr>
</table>
