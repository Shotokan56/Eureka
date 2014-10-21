<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="bingo.Default" %>

<%@ Register Src="Module/ucSlide.ascx" TagName="ucSlide" TagPrefix="uc2" %>
<%@ Register Src="Module/ucArticle.ascx" TagName="ucArticle" TagPrefix="uc3" %>
<%@ Register Src="Module/ucLopSapKhaiGiang.ascx" TagName="ucLopSapKhaiGiang" TagPrefix="uc4" %>
<%@ Register Src="Module/ucHomeAlbum.ascx" TagName="ucHomeAlbum" TagPrefix="uc5" %>
<%@ Register Src="Module/ucNoti.ascx" TagName="ucNoti" TagPrefix="uc6" %>
<%@ Register Src="Module/ucHomeVideo.ascx" TagName="ucHomeVideo" TagPrefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:ucSlide ID="ucSlide" runat="server"></uc2:ucSlide>
    <!--End div .slide-->
    <div class="container">
        <div class="container-left">
            <uc3:ucArticle ID="ucArticle" runat="server"></uc3:ucArticle>
            <!--End div .main-content-->
            <div class="main-content">
                <h2 class="h2-main-title">
                    <a href="/KhaiGiang.aspx" title="Lịch Khai Giảng">LỚP SẮP KHAI GIẢNG</a>
                </h2>
                <uc4:ucLopSapKhaiGiang ID="ucLopSapKhaiGiang" runat="server"></uc4:ucLopSapKhaiGiang>
                <!--End div .home-content-->
            </div>
            <!--End div .main-content-->
        </div>
        <!--End div .container-left-->
        <div class="container-right">
          <%--<uc5:ucHomeAlbum ID="ucHomeAlbum" runat="server"></uc5:ucHomeAlbum>
            <div class="noti">--%>
             <%--     <uc6:ucNoti ID="ucNoti" runat="server"></uc6:ucNoti>
            </div>
            <uc4:ucHomeVideo ID="ucHomeVideo" runat="server"></uc4:ucHomeVideo>--%>
           
        </div>
       
            <img src='/Media/1.jpg' alt='' title='' />
            <img src='/Media/2.jpg' alt='' title='' />
            <img src='/Media/3.jpg' alt='' title='' />
        <!--End div .container-right-->
    </div>
</asp:Content>
