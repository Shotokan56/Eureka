<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListAlbum.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucListAlbum" %>
<h2>
    Danh sách Album ảnh</h2>

<asp:GridView ID="gvAlbum" DataKeyNames="AlbumID" runat="server" AutoGenerateColumns="False" 
    BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
    CellPadding="4" onrowdeleting="gvAlbum_RowDeleting" 
    onselectedindexchanged="gvAlbum_SelectedIndexChanged" PageSize="100" Width="100%">
    <Columns>
        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" SortExpression="Title" />
        <asp:BoundField DataField="Description" HeaderText="Mô tả" SortExpression="Description" />
        <asp:BoundField DataField="OrderID" HeaderText="Sắp xếp" SortExpression="OrderID" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("AlbumID") %>'
                    CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
       <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>
<asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Thêm mới" />

