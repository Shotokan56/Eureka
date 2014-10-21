<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true" CodeBehind="Album-Image.aspx.cs" Inherits="bingo.Album_Image" %>
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
            <h2 class="h2-tilte" id="title" runat="server">
                Album Ảnh
            </h2>
            <asp:HiddenField ID="hdfPage" runat="server" />
            <div runat="server" id="divRoot">
                    <ul class="ul-root-ntt">
                        <asp:Repeater runat="server" ID="rptAlbum">
                            <ItemTemplate>
                                <li>
                                <a href='/Album-Detail/<%#Eval("AlbumID")%>/Image.aspx'>
                                    <img alt='<%#Eval("Title")%>' src='/Media/<%#Eval("CoverImg") %>' />
                                    <p><%#Eval("Title") %></p>
                                </a>
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

