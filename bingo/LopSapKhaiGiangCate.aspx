<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true" CodeBehind="LopSapKhaiGiangCate.aspx.cs" Inherits="bingo.LopSapKhaiGiangCate" %>

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
            <uc2:MenuLeft2 ID="MenuLeft2" runat="server" />
        </div>
        <div class="rightnews">
            <%-- <h2 class="h2-tilte" id="title" runat="server">
                Tin Tức
            </h2>--%>
            <div id="rightnews" runat="server">
                <asp:Repeater ID="rptOtherNews" runat="server">
                    <ItemTemplate>
                        <div class="cat-content-box">
                           <div class="cat-content-box-news">
                                <a id="A2" runat="server" href='<%#"/khai-giang/"+Eval("ArticleID")+"/"+FriendlyUrl(Eval("Title").ToString())%>'
                                    title='<%#Eval("Title") %>'>
                                    <%#Eval("Title") %></a>
                                    <p class="Ngay"><%#Eval("Ngay") %></p>
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

