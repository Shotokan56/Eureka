<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLopSapKhaiGiang.ascx.cs"
    Inherits="bingo.Module.ucLopSapKhaiGiang" %>
<ul class="home-content">
    <asp:Repeater ID="rptNewClass" runat="server" OnItemDataBound="LoadDataNewClass">
        <ItemTemplate>
            <li>
                <div class="home-content-left-wrap">
                    <img alt='<%#Eval("Title")%>' title='<%#Eval("Title")%>' src='Media/<%#Eval("ImageUrl") %>' />
                </div>
                <div class="home-content-title">
                    <a href='/KhaiGiang.aspx'>
                        <p>
                            <%#Eval("Title")%></p>
                    </a>
                </div>
                <%-- <asp:Repeater ID="rptTop1" runat="server">
                    <ItemTemplate>
                        <div class="home-content-title">
                            <a href='/khai-giang/<%#Eval("ArticleID") %>/<%#Eval("Title")%>.aspx'>
                                <p>
                                    <%#Eval("Title")%></p>
                            </a>
                            <p>
                                <a href='/khai-giang/<%#Eval("ArticleID") %>/<%#Eval("Title")%>.aspx' title='<%#Eval("Title")%>'>
                                    [Xem chi tiết]</a>
                            </p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>--%>
                <!--End div .home-content-left-wrap-->
                <ul class="home-content-ul">
                    <asp:Repeater ID="rptTop3" runat="server">
                        <ItemTemplate>
                            <li><a href='/khai-giang/<%#Eval("ArticleID") %>/<%#Eval("Title")%>.aspx' title='<%#Eval("Title")%>'>
                                <%#Eval("Title")%></a> </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
