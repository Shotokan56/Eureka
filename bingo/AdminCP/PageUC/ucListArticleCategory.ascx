<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListArticleCategory.ascx.cs"
    Inherits="bingo.AdminCP.PageUC.ucListArticleCategory" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>

<h2>
    Danh mục</h2>
<dxwtl:ASPxTreeList ID="tlCategory" runat="server" AutoGenerateColumns="False" Width="90%"
    ClientInstanceName="tlCategory" KeyFieldName="CategoryID" ParentFieldName="ParentID"
    EnableCallbacks="False" OnNodeDeleted="tlCategory_NodeDeleted" OnStartNodeEditing="tlCategory_StartNodeEditing">
    <SettingsPager Mode="ShowPager" PageSize="20">
        <AllButton Text="Tất cả">
        </AllButton>
        <NextPageButton Text="Tiếp theo &gt;">
        </NextPageButton>
        <PrevPageButton Text="&lt; Trước">
        </PrevPageButton>
    </SettingsPager>
    <SettingsBehavior AllowFocusedNode="True" />
    <SettingsPager ShowDefaultImages="False">
        <AllButton Text="Tất cả">
        </AllButton>
        <NextPageButton Text="Tiếp theo &gt;">
        </NextPageButton>
        <PrevPageButton Text="&lt; Trước">
        </PrevPageButton>
    </SettingsPager>
    <Columns>
        <dxwtl:TreeListTextColumn FieldName="CategoryID" Name="clCategoryID" Visible="False"
            VisibleIndex="0">
        </dxwtl:TreeListTextColumn>
        <dxwtl:TreeListTextColumn Caption="Tiêu đề" Width="70%" Name="Title" VisibleIndex="0"
            FieldName="Title">
        </dxwtl:TreeListTextColumn>
        <dxwtl:TreeListTextColumn Caption="Trang chủ" Width="10%" FieldName="IsHomPage" Name="clIsHomePage"
            VisibleIndex="1">
        </dxwtl:TreeListTextColumn>
        <dxwtl:TreeListTextColumn Caption="Hiển thị" Width="10%" FieldName="IsPublish" Name="clIsPublish"
            VisibleIndex="2">
        </dxwtl:TreeListTextColumn>
        <dxwtl:TreeListTextColumn Caption="Thứ tự" Width="10%" FieldName="OrderID" Name="clOrderID"
            VisibleIndex="3">
        </dxwtl:TreeListTextColumn>
        <dxwtl:TreeListCommandColumn Caption="Sửa" VisibleIndex="4">
            <EditButton Text="Sửa" Visible="True">
            </EditButton>
        </dxwtl:TreeListCommandColumn>
        <dxwtl:TreeListCommandColumn VisibleIndex="5" Caption="Xóa">
            <DeleteButton Text="Xóa" Visible="True">
            </DeleteButton>
        </dxwtl:TreeListCommandColumn>
    </Columns>
</dxwtl:ASPxTreeList>
<div style="width: 100%; float: left;">
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm mới" />
</div>
