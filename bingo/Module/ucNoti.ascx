<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucNoti.ascx.cs" Inherits="bingo.Module.ucNoti" %>
<div class="cap-album">
    <a href="DeThi.aspx" title="Hình Ảnh">LỜI HỌC VIÊN EUREKA</a>
</div>
<div class="noti-detail">
    <ul>
        <asp:Repeater ID="rptNoti" runat="server">
            <ItemTemplate>
                <li><a href='<%#Eval("Description")%>' target ="_blank"><%#Eval("Title") %></a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</div>
