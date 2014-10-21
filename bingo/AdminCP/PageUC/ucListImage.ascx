<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListImage.ascx.cs"
    Inherits="bingo.AdminCP.PageUC.ucListImage" %>
<h2>Album</h2>
<div style="width: 60%; float: left; margin-bottom: 10px;">
    Lựa chọn theo album:
    <asp:DropDownList ID="cboAlbum" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboAlbum_SelectedIndexChanged">
    </asp:DropDownList>
</div>
<div style="width: 40%; float: right; text-align: right; margin-bottom: 10px;">
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm mới" />
</div>
<asp:DataList ID="dlAlbumDetail" runat="server" Width="100%" BackColor="White" BorderColor="#CC9966"
    BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" RepeatColumns="7"
    RepeatDirection="Horizontal" DataKeyField="ImageID" OnDeleteCommand="dlAlbumDetail_DeleteCommand"
    OnSelectedIndexChanged="dlAlbumDetail_SelectedIndexChanged">
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <ItemStyle BackColor="White" ForeColor="#330099" Width="120px" />
    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    <ItemTemplate>
        <center>
            <a class="fancyboxx" rel="group1" title="<%#Eval("Title")%>" href="<%#"/Media/" + (Eval("ImgFile")).ToString() %>">
                <img width="100px" height="70px" src="<%#"/Media/" + (Eval("ImgFile")).ToString() %>" /></a>
            <br />
            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/Images/edit_16x16.gif" />
            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ImageID") %>'
                CommandName="Delete" ImageUrl="~/AdminCP/Images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            <br />
            <%#Eval("Title")%>
        </center>
    </ItemTemplate>
</asp:DataList>
<table border="0" width="100%">
    <tr>
        <td align="left">
            <asp:LinkButton ID="lbPrev" runat="server" Font-Bold="True" OnClick="lbPrev_Click1">
Trang trước
            </asp:LinkButton>
        </td>
        <td align="right">
            <asp:LinkButton ID="lbNext" runat="server" Font-Bold="True" OnClick="lbNext_Click1">
Trang sau
            </asp:LinkButton>
        </td>
    </tr>
</table>
