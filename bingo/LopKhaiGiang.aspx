<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true"
    CodeBehind="LopKhaiGiang.aspx.cs" Inherits="bingo.LopKhaiGiang" %>

<%@ Register Src="Module/ucMenuLeft.ascx" TagName="ucMenuLeft" TagPrefix="uc7" %>
<%@ Register Src="Module/MenuLeft2.ascx" TagName="MenuLeft2" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="imgtop">
        <img src="/images/bannercontent.jpg" alt="bingo" />
    </div>
    <div class="contentnews">
        <div class="left-wrap">
            <uc7:ucMenuLeft ID="ucMenuLeft" runat="server" />
            <uc2:MenuLeft2 ID="MenuLeft2" runat="server" />
        </div>
        <div class="rightnews">
            <%--<h2 class="h2-tilte" id="title" runat="server">
                News
            </h2>--%>
            <asp:Label ID="rightnews" runat="server" Text="Trang Web đang trong thời gian hoàn thiện"></asp:Label>
        </div>
    </div>
</asp:Content>
