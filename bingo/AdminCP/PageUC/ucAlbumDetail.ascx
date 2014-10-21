<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAlbumDetail.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucAlbumDetail" %>
<h2>Danh sách Imgase Album</h2>
    <asp:GridView ID="gvAt" DataKeyNames="ImageID" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
    BorderStyle="None" BorderWidth="1px" CellPadding="4" onrowdeleting="gvAt_RowDeleting" onselectedindexchanged="gvAt_SelectedIndexChanged" PageSize="100" Width="100%">
    <RowStyle BackColor="White" ForeColor="#330099" />
    <Columns>
        <asp:TemplateField HeaderText="STT">
            <ItemTemplate>
                <%# Container.DataItemIndex + 1 %>
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" SortExpression="Title" />
        <asp:BoundField DataField="eTitle" HeaderText="Tiêu đề TA" SortExpression="CateTitle" />
        <asp:CheckBoxField DataField="StyleAlbum" HeaderText="Video" />
        <asp:TemplateField HeaderText="Ảnh Video">
            <ItemTemplate>
                <asp:Image ID="imgVideo" ImageUrl='<%#getImg(Eval("ImageID").ToString()) %>' runat="server" Width="100px" Height="60px" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" CommandArgument='<%#Eval("ImageID") %>' ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ImageID") %>'
                    CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>
<br />
<asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Thêm mới" />
