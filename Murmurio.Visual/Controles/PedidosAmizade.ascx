<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PedidosAmizade.ascx.cs" Inherits="Murmurio.Visual.Controles.PedidosAmizade" %>


<table cellpadding="1" cellspacing="1" width="100%" border="0">

    <tr>
        <td align="center">
            <asp:Label ID="lblError" runat="server" CssClass="redtext"></asp:Label>
        </td>
    </tr>
    <tr>
        <td valign="top" align="center">
            <asp:DataList ID="ListaPedidosAmizade" runat="server" Width="100%" RepeatColumns="5"
                OnItemCommand="ListaPedidosAmizade_ItemCommand">
                <ItemTemplate>
                    <table border="0" cellpadding="1" cellspacing="1" align="center" style="background-color: Transparent">
                        <tr>
                            <td align="center" valign="top">
                                <a href='<%#getHREF(Container.DataItem)%>'>
                                    <input type="hidden" id="hiddenId" value='<%# DataBinder.Eval(Container.DataItem, "IdUsuario") %>'
                                        runat="server" name="hiddenId" />
                                    <img src='<%# getSRC(Container.DataItem) %>' align="middle" border="0" width="50px">
                                    <br />
                                    <asp:Button ID="AcceptButton" runat="server" ToolTip="Aceitar" 
                                    Text="V" ForeColor="#ffffff" CommandName="Accept" style="background-color: Transparent" /><br />
                                    <asp:Button ID="Deny" runat="server" ToolTip="Negar" Text="X" ForeColor="#ffffff"
                                    CommandName="Deny" style="background-color: Transparent" />
                                </a>&nbsp;
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </td>
    </tr>
</table>
