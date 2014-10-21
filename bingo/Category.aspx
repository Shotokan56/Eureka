<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true"
    CodeBehind="Category.aspx.cs" Inherits="bingo.Category" %>

<%@ Register Src="Module/MenuLeft2.ascx" TagName="MenuLeft2" TagPrefix="uc2" %>
<%@ Register Src="Module/ucMenuLeft.ascx" TagName="ucMenuLeft" TagPrefix="uc3" %>
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
            <%--<uc2:MenuLeft2 ID="MenuLeft2" runat="server" />--%>
        </div>
        <div class="rightnews">
            <div id="rightnews" runat="server">
                <asp:Repeater ID="rptOtherNews" runat="server">
                    <ItemTemplate>
                        <div class="cat-content-box">
                            <div style="float: left; width: 120px; height: 120px; padding: 3px; border: 1px solid #CCCCCC; margin-right: 5px;">
                                <a id="A1" runat="server" href='<%#"/bai-viet/"+Eval("ArticleID")+"/"+FriendlyUrl(Eval("Title").ToString())%>'>
                                    <img runat="server" id="imgNews" style="width: 120px; height: 120px;" class="cat-content-box-img" alt='<%#Eval("Title").ToString()%>'
                                        title='<%#Eval("Title").ToString()%>' src='<%#"~/Media/" + Eval("ImageUrl") %>' />
                                </a>
                            </div>
                            <div class="cat-content-box-news">
                                <a id="A2" runat="server" href='<%#"/bai-viet/"+Eval("ArticleID")+"/"+FriendlyUrl(Eval("Title").ToString())%>'
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
                        <img alt="PreviousPage" style="border: 0px;" src="/images/PrevPage.png" />
                        </asp:LinkButton>
                    </div>
                    <div style="float: right;">
                        <asp:LinkButton ID="NextPage" ToolTip="Trang trước" runat="server" OnClick="NextPage_Click">
                        <img alt="NextPage" style="border: 0px;" src="/images/nextpage.png" />
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
