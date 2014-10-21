<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucImages.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucImages" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>
<h2>
    Cập nhật hình ảnh</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Album:
        </td>
        <td class="style9">
           <div style="float: left; vertical-align: middle;">
                <asp:DropDownList ID="cboAlbum"
                    runat="server">
                </asp:DropDownList>
            </div></td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh
        </td>
        <td class="style9">
        <asp:TextBox ID="txtTitle" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtTitle" ErrorMessage="*** Cần nhập tiêu đề" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" Visible="False">[Xem 
            ảnh]</asp:HyperLink>
        </td>
    </tr>
    
    
    <tr runat="server" id="trimg" visible="false">
        <td class="style8">
            Chi tiết:</td>
        <td>
            <CKEditor:CKEditorControl ID="txtDescription" runat="server" Width="90%">
            </CKEditor:CKEditorControl>
        </td>
    </tr>
    
   
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" 
                ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" Text="Hủy" />
        </td>
    </tr>
</table>