<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListArticle.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucListArticle" %>
<asp:HiddenField ID="hdfPageIndex" runat="server" />
<h2>
    Danh sách Tin tức</h2>
<div style="width:100%; float:left; margin-bottom:10px;">
    <table>
        <tr>
            <td style="width: 100%">
                Lựa chọn theo Danh mục: 
                <asp:DropDownList ID="cboCategory" runat="server" 
                    AutoPostBack="True" 
                    onselectedindexchanged="cboCategory_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button CssClass="btnAdd" ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Thêm mới" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="gvAt" DataKeyNames="ArticleID" runat="server" AutoGenerateColumns="False" 
    BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
    CellPadding="4" onrowdeleting="gvAt_RowDeleting" 
    onselectedindexchanged="gvAt_SelectedIndexChanged" PageSize="100" Width="100%">
    <RowStyle BackColor="White" ForeColor="#330099" />
    <Columns>
        <asp:BoundField DataField="ArticleID" HeaderText="Mã ID" SortExpression="ArticleID" />
        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" SortExpression="Title" />
        <asp:BoundField DataField="CateTitle" HeaderText="Danh mục" SortExpression="CateTitle" />
        <asp:CheckBoxField DataField="IsPublish" HeaderText="Hiển thị" />
        <asp:TemplateField HeaderText="Action">
            <ItemTemplate>
                <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ArticleID") %>'
                    CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            </ItemTemplate>
        </asp:TemplateField>
                    
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>
    <asp:Panel ID="pnlPaging" runat="server">
        <div id="Paging">
            <div style="float:left;">
                Trang 
                <asp:DropDownList ID="ddlPageIndex" runat="server" AutoPostBack="true" 
                        onselectedindexchanged="ddlPageIndex_SelectedIndexChanged">
                </asp:DropDownList>
                /
                <asp:Label ID="lblTotalPages" runat="server" Text=""></asp:Label>
            </div>
            <div style="float:right;">
                Hiển thị
                <asp:DropDownList ID="ddlNumberItemPerPage" runat="server" AutoPostBack="true" 
                    onselectedindexchanged="ddlNumberItemPerPage_SelectedIndexChanged">
                </asp:DropDownList>
                Kết quả/ trang
            </div>
        </div>
    </asp:Panel>
    
</div>


