<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucImageDetail.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucImageDetail" %>
<h2>
    Cập nhật Image</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Tiêu đề:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtTitle" ErrorMessage="*** Cần nhập tiêu đề" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkVideo" runat="server" Checked="True" Text="Video" />
        </td>
    </tr> 
    <tr>
        <td class="style8">
            Tiêu đề TA:
        </td>
        <td class="style9">
            <asp:TextBox ID="txteTitle" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
        </td>
    </tr>   
    
    <tr id="trDes" runat="server" visible="true">
        <td class="style8">
            Mô tả:</td>
        <td>
            <asp:TextBox ID="txtDescription" TextMode="MultiLine" runat="server" Width="90%">
           </asp:TextBox>
        </td>
    </tr>
    <tr id="tr1" runat="server" visible="true">
        <td class="style8">
            Mô tả TA:</td>
        <td>
            <asp:TextBox ID="txteDescription" TextMode="MultiLine" runat="server" Width="90%">
           </asp:TextBox>
        </td>
    </tr>
    <tr runat="server" id="trVideo" visible="false">
        <td class="style8">
            Video:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtVideo" runat="server" Width="300px"></asp:TextBox>
        </td>
    </tr>
   <tr runat="server" id="trPopup" visible="false">
        <td class="style8">
            Hình ảnh
        </td>
        <td class="style9">
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" >[Xem 
            ảnh]</asp:HyperLink>
        </td>
    </tr>
    
    
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" 
                ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" Text="Hủy" onclick="btnReset_Click" />
        </td>
    </tr>
    
    
</table>
