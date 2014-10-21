<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListConfig.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucListConfig" %>
<h2 style="text-align: left;">
    Danh sách Cấu hình hệ thống</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvConfig" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" 
                CellPadding="4" Width="100%"
                DataKeyNames="ConfigID" OnPageIndexChanging="gvConfig_PageIndexChanging" OnRowDeleting="gvConfig_RowDeleting"
                OnSelectedIndexChanged="gvConfig_SelectedIndexChanged"
                AllowPaging="True" PageSize="50">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="ConfigID" HeaderText="ID" Visible="False">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ConfigName" HeaderText="Tên" >
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="isActive" HeaderText="Active" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />                           
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