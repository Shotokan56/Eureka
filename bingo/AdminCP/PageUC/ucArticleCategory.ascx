<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucArticleCategory.ascx.cs"
    Inherits="bingo.AdminCP.PageUC.ucArticleCategory" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>

<script type="text/javascript">
    function SelectAndClosePopup(value) {
        cbParent.SetValue(value);
        pcParent.Hide();
    }
</script>
<h2>
    Cập Nhật Danh Mục</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Tiêu Đề
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle" runat="server" Width="273px" ValidationGroup="submitGrp"></asp:TextBox>
            <asp:TextBox ID="txteTitle" Visible="false" runat="server" Width="273px" ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"
                ErrorMessage="*** Nhập Tiêu Đề?" ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
            <asp:RadioButton ID="rdoVideo" GroupName="type" Visible="true" Text="Video"
                runat="server" />
            <asp:RadioButton ID="rdoImage" GroupName="type" Visible="true" Text="Ảnh" runat="server" />
            <asp:RadioButton ID="rdoNoiDung" GroupName="type" Text="Nội Dung" runat="server" />
            <asp:RadioButton ID="rdoDanhMuc" runat="server" GroupName="type" Text="Danh Mục" />
            <asp:RadioButton ID="rdoTaiLieu" runat="server" GroupName="type" Text="Tài Liệu" />
        </td>
    </tr>
    <tr>
        <td class="style8">
            Thuộc danh mục:
        </td>
        <td class="style9">
            <div style="float: left; vertical-align: middle;">
                <dxe:ASPxComboBox ID="cboParent" ClientEnabled="false" ClientInstanceName="cbParent"
                    runat="server" Height="16px" Width="143px">
                </dxe:ASPxComboBox>
            </div>
            <div style="float: left; margin-left: 5px; vertical-align: middle;">
                <dxe:ASPxButton ID="btnSelectParent" runat="server" Text="Chọn">
                    <ClientSideEvents Click="function(s, e) { pcParent.Show();}" />
                </dxe:ASPxButton>
            </div>
            <div style="float: left; margin-left: 5px; vertical-align: middle;">
                <asp:CheckBox ID="chkIsTop" runat="server" />Danh mục cấp cao nhất</div>
            <div style="float: left; margin-left: 5px; vertical-align: middle;">
                <asp:CheckBox ID="chkIsMenu" runat="server" />Menu</div>
                  <div style="float: left; margin-left: 5px; vertical-align: middle;">
                <asp:CheckBox ID="ckfootmenu" runat="server" />FootMenu</div>
            <div style="float: left; margin-left: 5px; vertical-align: middle;">
                <asp:CheckBox ID="chkIsClass" runat="server" />Lớp Học</div>
            <div style="float: left; margin-left: 5px; vertical-align: middle;">
                <asp:CheckBox ID="ckNoti" runat="server" />Thông Báo</div>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình Ảnh:
        </td>
        <td class="style9">
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" Visible="False">[Xem 
            Ảnh]</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Mô Tả
        </td>
        <td class="style9">
            <%--set multiPageID = radmultipage   --%>
            <%--<telerik:RadTabStrip runat="server" ID="RadTabStrip1" SelectedIndex="0" MultiPageID="RadMultiPage1">
                <Tabs>
                    <telerik:RadTab runat="server" Text="Mô Tả" SelectedIndex="0" PageViewID="RadPageView1">
                    </telerik:RadTab>
                </Tabs>
            </telerik:RadTabStrip>
            <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0" Height="500px">
                <telerik:RadPageView ID="RadPageView1" runat="server">
                    <telerik:RadEditor ID="txtDescription" runat="server" Width="850px">
                        <ImageManager MaxUploadFileSize="1024000000" DeletePaths="~/Media/" UploadPaths="~/Media/"
                            ViewPaths="~/Media/"></ImageManager>
                    </telerik:RadEditor>
                </telerik:RadPageView>
            </telerik:RadMultiPage>--%>
               <CKEditor:CKEditorControl ID="txtDescription" runat="server" Width="100%">
            </CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Nội Dung
        </td>
        <td class="style9">
          <%--  <telerik:RadTabStrip runat="server" ID="RadTabStrip2" SelectedIndex="0" MultiPageID="RadMultiPage1">
                <Tabs>
                    <telerik:RadTab runat="server" Text="Nội Dung" SelectedIndex="0" PageViewID="RadPageView1">
                    </telerik:RadTab>
                </Tabs>
            </telerik:RadTabStrip>
            <telerik:RadMultiPage ID="RadMultiPage2" runat="server" SelectedIndex="0" Height="500px">
                <telerik:RadPageView ID="RadPageView3" runat="server">
                    <telerik:RadEditor ID="txtDetailContent" runat="server" Width="850px">
                        <ImageManager MaxUploadFileSize="1024000000" DeletePaths="~/Media/" UploadPaths="~/Media/"
                            ViewPaths="~/Media/"></ImageManager>
                    </telerik:RadEditor>
                </telerik:RadPageView>
            </telerik:RadMultiPage>--%>
              <CKEditor:CKEditorControl ID="txtDetailContent" runat="server" Width="100%">
            </CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hiển Thị
        </td>
        <td class="style4">
            <div style="float: left; vertical-align: middle;">
                &nbsp;
                <asp:CheckBox ID="chkIsHomePage" runat="server" />
                Hiện Trang Chủ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkIsPublish" runat="server" />
                Ẩn Đi &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Số
                Thứ Tự:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
            <div style="float: left; vertical-align: middle;">
                <asp:TextBox ID="txtOrderID" runat="server" Width="68px" ValidationGroup="submitGrp"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtOrderID"
                ErrorMessage="*** C?n nh?p s? th? t?" ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" Text="Luu" OnClick="btnSave_Click" ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" Text="H?y" />
        </td>
    </tr>
</table>
<dxpc:ASPxPopupControl ID="pcParent" runat="server" ClientInstanceName="pcParent"
    CloseAction="CloseButton" ContentUrl="~/AdminCP/ListCategory.aspx" HeaderText="Chọn Danh Mục"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Height="336px"
    Width="699px">
    <ContentCollection>
        <dxpc:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
        </dxpc:PopupControlContentControl>
    </ContentCollection>
</dxpc:ASPxPopupControl>
