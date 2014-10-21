<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenu.ascx.cs" Inherits="bingo.Module.ucMenu" %>
<ul class="main-menu">
    <li><a href="/Default.aspx">Trang Chủ</a></li>
    <asp:Repeater ID="rptTopMenu" runat="server" OnItemDataBound="rptTopMenu_ItemDataBound">
        <ItemTemplate>
            <li>
                <asp:HyperLink ID="hplMenu" runat="server"></asp:HyperLink></li>
        </ItemTemplate>
    </asp:Repeater>
     <li><a href="/LienHe.aspx">Liên Hệ</a></li>
</ul>
