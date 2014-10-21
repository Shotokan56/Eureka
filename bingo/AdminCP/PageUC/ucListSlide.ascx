<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListSlide.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucListSlide" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<h2>
    Danh sách Slide</h2>
<asp:GridView ID="gvSlide" DataKeyNames="SlideID" runat="server" AutoGenerateColumns="False" 
    BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px"
        CellPadding="4" onrowdeleting="gvSlide_RowDeleting" 
    onselectedindexchanged="gvSlide_SelectedIndexChanged" PageSize="100" Width="100%">
    <Columns>
        <asp:TemplateField HeaderText="STT">
            <ItemTemplate>
                <%# Container.DataItemIndex + 1 %>
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" />
            <FooterTemplate>
                Tổng tiền:
            </FooterTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" SortExpression="Title" />
        <asp:BoundField DataField="SlideURL" HeaderText="Đường dẫn" SortExpression="SlideURL" />
        <asp:TemplateField HeaderText="Action" HeaderStyle-Width="10%" ItemStyle-HorizontalAlign="Center">
            <ItemTemplate>
                <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("SlideID") %>'
                    CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Height="40px" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>
<asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Thêm mới" />