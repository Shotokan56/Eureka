<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucUser.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucUser" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<h2>
    User&nbsp;</h2>
<table width="100%">
    <tr>
        <td>
            <p style="width: 120px; margin: 0">
                Username</p>
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
            <p style="width: 120px; margin: 0">
                Password</p>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            (Ko nhập nếu giữ nguyên password cũ)
        </td>
    </tr>
    <tr>
        <td>
            Email
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
            Địa chỉ:
        </td>
        <td>
            <asp:TextBox ID="txtAddress" runat="server" Width="235px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Yahoo IM
        </td>
        <td>
            <asp:TextBox ID="txtYahoo" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
            Họ tên:
        </td>
        <td>
            <asp:TextBox ID="txtFullname" runat="server" Width="235px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Admin:
        </td>
        <td>
            <asp:CheckBox ID="cbAdmin" runat="server" />
        </td>
        <td>
            Active:
        </td>
        <td>
            <asp:CheckBox ID="cbActive" runat="server" />
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <div style="float: left; margin-right: 10px; margin-top: 10px;">
                <asp:Button ID="btSave" runat="server" Text="Lưu" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
                    CssPostfix="Soft_Orange" OnClick="btSave_Click" />
            </div>
            <div style="margin-top: 10px;">
            <asp:Button ID="btCancel" runat="server" Text="Hủy" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
                    CssPostfix="Soft_Orange" onclick="btCancel_Click"/>
                
            </div>
        </td>
    </tr>
</table>
