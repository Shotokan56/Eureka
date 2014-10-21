<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAddMultiImg.ascx.cs"
    Inherits="bingo.AdminCP.PageUC.ucAddMultiImg" %>
<h2>
    Cập nhật hình ảnh</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Sản phẩm:
        </td>
        <td class="style9">
            <div style="float: left; vertical-align: middle;">
                <asp:DropDownList ID="cboAlbum" runat="server">
                </asp:DropDownList>
            </div>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 1
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle1" runat="server" Width="179px"></asp:TextBox>
            <asp:FileUpload ID="fuImage1" runat="server" />
            &nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 2
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle2" runat="server" Width="179px" ValidationGroup="submitGrp"></asp:TextBox>
            <asp:FileUpload ID="fuImage2" runat="server" />
            &nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 3
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle3" runat="server" Width="179px" ValidationGroup="submitGrp"></asp:TextBox>
            <asp:FileUpload ID="fuImage3" runat="server" />
            &nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 4
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle4" runat="server" Width="179px" ValidationGroup="submitGrp"></asp:TextBox>
            <asp:FileUpload ID="fuImage4" runat="server" />
            &nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 5
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle5" runat="server" Width="179px" ValidationGroup="submitGrp"></asp:TextBox>
            <asp:FileUpload ID="fuImage5" runat="server" />
            &nbsp;
            <asp:HyperLink ID="HyperLink5" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" Text="Hủy" />
        </td>
    </tr>
</table>
