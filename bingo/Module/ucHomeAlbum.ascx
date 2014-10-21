<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHomeAlbum.ascx.cs"
    Inherits="bingo.Module.ucHomeAlbum" %>

  

<div class="HomeAlbum">
    <div class="cap-album">
        <a href="#" title="Hình Ảnh">THƯ VIỆN HÌNH ẢNH</a></div>
    <div class="detail-album">
        <asp:Repeater ID="rptAnhTo" runat="server">
            <ItemTemplate>
                <a class="fancybox" id="showanh" rel="group" href='/Media/<%#Eval("ImgFile") %>' >
                    <img  alt='<%#Eval("Title") %>' src='/Media/<%#Eval("ImgFile") %>' class="bigimg" />
                   </a>
            </ItemTemplate>
        </asp:Repeater>
        <ul class="smallimg">
            <asp:Repeater ID="rptAlbum" runat="server">
                <ItemTemplate>
                    <li><a class="fancybox" rel="group" href='/Media/<%#Eval("ImgFile") %>'>
                        <img src='/Media/<%#Eval("ImgFile") %>' alt='<%#Eval("Title") %>' title='<%#Eval("Title") %>' /></a></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</div>
