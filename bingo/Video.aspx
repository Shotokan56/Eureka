<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true"
    CodeBehind="Video.aspx.cs" Inherits="bingo.Video" %>

<%@ Register Src="Module/MenuLeft2.ascx" TagName="MenuLeft2" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="imgtop">
        <img src="/images/bannercontent.jpg" alt="bingo" />
    </div>
    <div class="contentnews">
        <div class="left-wrap">
            <uc2:MenuLeft2 ID="MenuLeft1" runat="server" />
        </div>
        <div class="rightnews">
            <h2 class="h2-tilte" id="title" runat="server" >
                Video
            </h2>
            <asp:HiddenField ID="hdfPage" runat="server" />
            <div runat="server" id="divRoot">
                <ul class="ul-root-ntt">
                    <asp:Repeater runat="server" ID="rptVideo"  >
                        <ItemTemplate>
                            <li>
                                <iframe width="300px" height="200px" style="margin: 10px;" frameborder="0"
                                    allowfullscreen="" id="ifVideo" src='<%#Eval("ImgFile") %>' runat="server"></iframe>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
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
</asp:Content>
