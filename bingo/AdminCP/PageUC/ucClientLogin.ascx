<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucClientLogin.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucClientLogin" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<h2>
    Cập nhật thông tin đăng nhập khách hàng</h2>
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
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            
        </td>
    </tr>
    <tr>
        <td>
            Tên khách hàng
        </td>
        <td>
            <asp:TextBox ID="txtClientName" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
           
        </td>
        <td>
            
        </td>
    </tr>
  
    <tr>
        <td class="style8">
            Trình bày:</td>
        
       
    </tr>
    
    <tr>
        <td colspan="4">
            <div style="float: left; margin-right: 10px; margin-top: 10px;">
                 <asp:Button runat="server" ID="btSave" Text="Lưu" OnClick="btSave_Click" />
            </div>
            <div style="margin-top: 10px;">
                <asp:Button runat="server" ID="btCancel" Text="Hủy" OnClick="btSave_Click" />
            </div>
        </td>
    </tr>
</table>