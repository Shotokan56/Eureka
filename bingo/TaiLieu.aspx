<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true" CodeBehind="TaiLieu.aspx.cs" Inherits="bingo.TaiLieu" %>
<%@ Register Src="Module/MenuLeft2.ascx" TagName="MenuLeft2" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="imgtop">
        <img src="/images/bannercontent.jpg" alt="bingo" />
    </div>
    <div class="contentnews">
        <div class="left-wrap">
        
        <uc2:MenuLeft2 ID="ucMenuLeft2" runat="server" />
        </div>
    </div>
     <div class="rightnews">
<ul class="ullop">
    <asp:Repeater ID="rptlop" runat="server" OnItemDataBound="LoadDataLop">
        <ItemTemplate>
            <li class="lopli">
                <h1 class="lop"><%#Eval("Title") %></h1>
                <ul class="ultailieu">
                <asp:Repeater ID="rptTaiLieu" runat="server">
                    <ItemTemplate>
                        
                            <li><a href='<%#Eval("Description")%>'><%#Eval("Title")%></a></li>
                       
                    </ItemTemplate>
                </asp:Repeater>
               </ul>
            </li>
        </ItemTemplate>
    </asp:Repeater>
    </ul>
    </div>
</asp:Content>
