<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucArticle.ascx.cs" Inherits="bingo.Module.ucArticle" %>
<div class="main-content">
    <h2 class="h2-main-title">
        <a href='/Tin-Tuc/-1/News.aspx' title="xx">Khởi nghiệp & Sáng tạo tương lai</a>
    </h2>
    <div class="content-box">
        <ul class="content-Top">
            <asp:Repeater ID="rptTop" runat="server">
                <ItemTemplate>
                    <li>
                        <div class="content-img-box">
                            <a href='/Noi-Dung/<%#Eval("ArticleID") %>/<%#Eval("Title") %>.aspx'>
                                <img alt='<%#Eval("Title") %>' title='<%#Eval("Title") %>' class="content-img" src='/Media/<%#Eval("ImageUrl") %>' />
                            </a>
                        </div>
                        <a href='/Noi-Dung/<%#Eval("ArticleID") %>/<%#Eval("Title") %>.aspx'>
                            <h2 class="content-title">
                                <%#Eval("Title") %></h2>
                        </a><a href='/Noi-Dung/<%#Eval("ArticleID") %>/<%#Eval("Title") %>.aspx'>
                            <p class="content-desc">
                                <%#Eval("Description")%>
                            </p>
                        </a>
                        <p class="content-readmore">
                            <a title='<%#Eval("Title") %>' href='/Noi-Dung/<%#Eval("ArticleID") %>/<%#Eval("Title") %>.aspx'>
                                xem tiếp</a>
                        </p>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
        <div class="morediv">
            <ul class="other-article">
                <asp:Repeater ID="ArticleLeft" runat="server">
                    <ItemTemplate>
                        <li><a href='/Noi-Dung/<%#Eval("ArticleID") %>/<%#Eval("Title") %>.aspx' title='<%#Eval("Title") %>'>
                            <%#Eval("Title") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <ul class="other-article2">
                <asp:Repeater ID="ArticleRight" runat="server">
                    <ItemTemplate>
                        <li><a href='/Noi-Dung/<%#Eval("ArticleID") %>/<%#Eval("Title") %>.aspx' title='<%#Eval("Title") %>'>
                            <%#Eval("Title") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>
    <!--End div .content-box-->
</div>
