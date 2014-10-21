<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAlbum.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucAlbum" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
    
<h2>
    Album</h2>
<table width="100%">
    <tr>
        <td>
            Tiêu đề
        </td>
        <td>
            <asp:TextBox runat="server" ID="txtTitle" Width="100%"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh
        </td>
        <td class="style9">
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank">[Xem 
            ảnh]</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            Description
        </td>
        <td>
            <asp:TextBox runat="server" ID="txtDescription" TextMode="MultiLine" Height="150px"
                Width="100%"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Sắp xếp
        </td>
        <td>
            <asp:TextBox runat="server" ID="txtOrderID" Width="50px"></asp:TextBox>
        </td>
    </tr>
   
    <tr>
        <td>
        </td>
        <td>
            <asp:Button runat="server" ID="btnLuu" Text="Lưu" OnClick="btnLuu_Click" />
        </td>
    </tr>
</table>
<asp:FilteredTextBoxExtender runat="server" FilterType="Numbers" ID="flter1" TargetControlID="txtOrderID">
</asp:FilteredTextBoxExtender>