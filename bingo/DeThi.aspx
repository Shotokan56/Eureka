<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true"
    CodeBehind="DeThi.aspx.cs" Inherits="bingo.DeThi" %>

<%@ Register Src="Module/MenuLeft2.ascx" TagName="MenuLeft2" TagPrefix="uc2" %>
<%@ Register Src="Module/ucMenuLeft.ascx" TagName="ucMenuLeft" TagPrefix="uc7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="imgtop">
        <img src="/images/bannercontent.jpg" alt="bingo" />
    </div>
    <div class="contentnews">
        <div class="left-wrap">
            <uc7:ucMenuLeft ID="ucMenuLeft" runat="server" />
            <uc2:MenuLeft2 ID="MenuLeft1" runat="server" />
        </div>
        <div class="rightnews">
            <h2 class="h2-tilte" id="title" runat="server">
                MỘT SỐ ĐỀ THI THAM KHẢO
            </h2>
            <ul class="DeThi">
                <asp:Repeater ID="rptDeThi" runat="server">
                    <ItemTemplate>
                        <li><a href='<%#Eval("Description")%>' target="_blank">
                            <%#Eval("Title") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>
</asp:Content>
