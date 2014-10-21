<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListClientLogin.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucListClientLogin" %>
<h2 style="text-align: left;">
    Danh sách Khách đăng nhập</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvClientLogin" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                DataKeyNames="ClientLoginID" OnPageIndexChanging="gvClientLogin_PageIndexChanging" OnRowDeleting="gvClientLogin_RowDeleting"
                OnSelectedIndexChanged="gvClientLogin_SelectedIndexChanged"
                AllowPaging="True">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="ClientLoginID" HeaderText="ClientLoginID" Visible="False">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ClientName" HeaderText="Tên người dùng" />
                    <asp:BoundField DataField="Username" HeaderText="Username" />
                    <asp:BoundField DataField="Password" HeaderText="Password" />
                    
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ClientLoginID") %>'
                                CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            </asp:GridView>
        </td>
    </tr>
</table>
<asp:Button ID="btnAdd" runat="server" Text="Thêm mới" onclick="btnAdd_Click" />