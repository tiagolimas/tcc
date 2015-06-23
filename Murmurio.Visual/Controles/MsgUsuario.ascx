<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MsgUsuario.ascx.cs" Inherits="Murmurio.Visual.Controles.MsgUsuario" %>



<table cellpadding="0" cellspacing="1" border="0" width="290px" >
    <tr>
        <td colspan="3" align="left">
            <asp:GridView ID="GridViewUserScraps" ItemStyle-VerticalAlign="Top" AutoGenerateColumns="False"
                GridLines="None" Width="100%" ShowHeader="False" runat="server" AlternatingRowStyle-BackColor="Transparent"
                CellPadding="4" ForeColor="#ffffff" PageSize="4" BackColor="Transparent">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <table align="left" cellpadding="1" cellspacing="2">
                                <tr>
                                    <td>
                                        <a href='<%#getHREF(Container.DataItem)%>'>
                                            <img align="middle" src='<%#getSRC(Container.DataItem)%>' border="0" width="25px" /></a>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <div align="justify">
                                <%#DataBinder.Eval(Container.DataItem, "Mensagem")%>
                                <br />
                                <br />
                            </div>
                            <%--<span class="SmallBlackText">Postado em: &nbsp;</span>
                            <asp:Label ID="lblSendDate" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"DataEnvio")%>'></asp:Label>--%>
                            </span>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <RowStyle BackColor="Transparent" />
                <FooterStyle BackColor="Transparent" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="Transparent" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="Transparent" Font-Bold="True" ForeColor="#ffffff" />
                <HeaderStyle BackColor="Transparent" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="Transparent" />
                <AlternatingRowStyle BackColor="Transparent" />
            </asp:GridView>
        </td>
    </tr>
</table>
