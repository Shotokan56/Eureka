<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true"
    CodeBehind="tintuc.aspx.cs" Inherits="bingo.tintuc" %>

<%@ Register Src="Module/ucMenuLeft.ascx" TagName="ucMenuLeft" TagPrefix="uc3" %>
<%@ Register Src="Module/MenuLeft2.ascx" TagName="MenuLeft2" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hdfPage" runat="server" />
    <div class="imgtop">
        <img src="/images/bannercontent.jpg" alt="bingo" />
    </div>
    <div class="contentnews">
        <div class="left-wrap">
            <uc3:ucMenuLeft ID="ucMenuLeft" runat="server" />
            <uc2:MenuLeft2 ID="MenuLeft1" runat="server" />
        </div>
        <div class="rightnews">
            <h2 class="h2-tilte" id="title" runat="server">
                Tin Tức
            </h2>
            <div class="under-right">
                <div class="about-xebanchay">
                    <h5 style="margin: 7px 0px 0px 34px; color: White; display: none; float: left; font-size: 14px;
                        text-transform: uppercase;">
                        <asp:Label ID="lblTitle" runat="server" Text="" Visible="false"></asp:Label>
                    </h5>
                    <div style="float: left; width: 100%;">
                        <asp:Repeater ID="rptOtherNews" runat="server">
                            <ItemTemplate>
                                <div class="cat-content-box" style="">
                                    <div style="float: left; width: 100px; height: 100px; padding: 3px; border: 1px solid #CCCCCC;
                                        margin-right: 5px;">
                                        <a id="A1" style="width: 100px; height: 100px;" runat="server" href='<%#"/bai-viet/"+Eval("ArticleID")+"/"+FriendlyUrl(Eval("Title").ToString())%>'>
                                            <img style="width: 100px; height: 100px;" runat="server" id="imgNews" class="cat-content-box-img"
                                                alt='<%#Eval("Title").ToString()%>' title='<%#Eval("Title").ToString()%>' src='<%#"~/Media/" + Eval("ImageUrl") %>' />
                                        </a>
                                    </div>
                                    <div class="cat-content-box-news">
                                        <a id="A2" runat="server" href='<%#"/Noi-Dung/"+Eval("ArticleID")+"/"+FriendlyUrl(Eval("Title").ToString())%>'
                                            title='<%#Eval("Title") %>'>
                                            <%#Eval("Title") %></a>
                                        <p>
                                            <%#Eval("Description")%>
                                        </p>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                        <div class="Page" style="float: left; width: 100%; margin-top: 5px;">
                            <div style="float: left;">
                                <asp:LinkButton ID="PreviousPage" ToolTip="Trang sau" runat="server" OnClick="PreviousPage_Click">
                        <img alt="PreviousPage" style="border: 0px;" src="/image/prevpage.png" />
                                </asp:LinkButton>
                            </div>
                            <div style="float: right;">
                                <asp:LinkButton ID="NextPage" ToolTip="Trang trước" runat="server" OnClick="NextPage_Click">
                        <img alt="NextPage" style="border: 0px;" src="/image/nextpage.png" />
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
