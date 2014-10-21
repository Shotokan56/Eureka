<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuLeft2.ascx.cs" Inherits="bingo.Module.MenuLeft2" %>
<div class="leftmenu">
    <ul class="leftmenu">
      <%--  <div class="tit">
            <span>Các Khóa Học</span></div>--%>
        <asp:Repeater ID="rptLeftMenu" runat="server" OnItemDataBound="rptLeftMenu_ItemDataBound">
            <ItemTemplate>
                <li>
                    <asp:HyperLink ID="hplMenu" runat="server"></asp:HyperLink></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>


   
</div>