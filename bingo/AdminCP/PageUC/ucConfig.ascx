<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucConfig.ascx.cs" Inherits="bingo.AdminCP.PageUC.ucConfig" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>
<h2>
    Cập nhật Slide</h2>
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
            <asp:CheckBox ID="chkActive" runat="server" Checked="True" Text="Active" />
        </tr>   
    
    <tr id="trDes" runat="server" visible="true">
        <td class="style8">
            Chi tiết:</td>
        <td>
            <asp:TextBox ID="txtDescription" TextMode="MultiLine" runat="server" Width="90%">
           </asp:TextBox>
        </td>
    </tr>
    <tr id="trSupport" runat="server" visible="false">
        <td class="style8">
            Trình bày:</td>
        <td class="style9">
            <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="100%">               
                <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Mô tả:">
                    <ContentTemplate>
                        <CKEditor:CKEditorControl ID="txtCK" runat="server" Height="300px" Width="90%"></CKEditor:CKEditorControl>
                    </ContentTemplate>
                </asp:TabPanel>

                <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="Mô tả TA:" Visible="false">
                    <ContentTemplate>
                        <CKEditor:CKEditorControl ID="txtCKTA" runat="server" Height="300px"  Width="90%"></CKEditor:CKEditorControl>
                    </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
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
