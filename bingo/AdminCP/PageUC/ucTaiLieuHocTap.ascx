<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTaiLieuHocTap.ascx.cs"
    Inherits="bingo.AdminCP.PageUC.ucTaiLieuHocTap" %>
<h2>
    Danh Sách Tài Liệu</h2>
<div id="Div1" runat="server">
    <div style="float:left; width:50%;">
        <asp:DropDownList runat="server" ID="ddllop" DataTextField="Title" DataValueField="CategoryID"
            Width="300px" AutoPostBack=true 
            onselectedindexchanged="ddllop_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    <div style="float: right; width: 50%;">
        <span style="float: right">
            <asp:Button runat="server" ID="btnAddNewRecord" Text="Thêm Tài Liệu" CssClass="button"
                OnClick="AddNewRecord" /></span>
    </div>
    <asp:GridView ID="grvProperties" DataKeyNames="ArticleID" runat="server" AutoGenerateColumns="False"
        CssClass="tstyle2" PageSize="20" AllowPaging="true" Width="100%" PagerStyle-CssClass="pgr"
        OnRowCancelingEdit="grvProperties_RowCancelingEdit" OnRowEditing="grvProperties_RowEditing"
        OnRowUpdating="grvProperties_RowUpdating" OnRowCommand="grvProperties_RowCommand"
        OnRowDeleting="grvProperties_RowDeleting" 
        onselectedindexchanged="grvProperties_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField HeaderText="ID" ItemStyle-Width="10%">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblTaiLieuID" Text='<%#Eval("ArticleID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Title" ItemStyle-Width="30%">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblTitle" Text='<%#Eval("Title") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtTitle" Text='<%#Eval("Title") %>' Width="220px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                        ForeColor="Red" ControlToValidate="txtTitle" ValidationGroup="vlProperty"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox runat="server" ID="txtFTitle" Text="" Width="220px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ErrorMessage="*"
                        ForeColor="Red" ControlToValidate="txtFTitle" ValidationGroup="vlfProperty"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đường Dẫn" ItemStyle-Width="35%">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblTaiLieuURL" Text='<%#Eval("Description") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtTaiLieuURL" Text='<%#Eval("Description") %>' Width="420px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4a" runat="server" ErrorMessage="*"
                        ForeColor="Red" ControlToValidate="txtTaiLieuURL" ValidationGroup="vlProperty"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox runat="server" ID="txtFTaiLieuURL" Text="" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatora4" runat="server" ErrorMessage="*"
                        ForeColor="Red" ControlToValidate="txtFTaiLieuURL" ValidationGroup="vlfProperty"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Thứ tự" ItemStyle-Width="10%">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblOrderID" Text='<%#Eval("OrderID") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtOrderID" Text='<%#Eval("OrderID") %>' Width="50px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                        ForeColor="Red" ControlToValidate="txtOrderID" ValidationGroup="vlProperty"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox runat="server" ID="txtFOrderID" Text="" Width="45px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                        ForeColor="Red" ControlToValidate="txtFOrderID" ValidationGroup="vlfProperty"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Lớp" ItemStyle-Width="30%">
                <ItemTemplate>
                 <asp:Label runat="server" ID="lblCateTitle" Text='<%#Eval("CateTitle") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                     <asp:DropDownList runat="server" ID="ddlCateTitle" DataTextField="Title" DataValueField="CategoryID"
                            Width="150px" AppendDataBoundItems=true SelectedValue='<%#Eval("CategoryID") %>' DataSource='<%#bingo.AdminCP.Functions.DataType()%>' >
                     </asp:DropDownList>
                </EditItemTemplate>
                <FooterTemplate>
                     <asp:DropDownList runat="server" ID="ddlFCateTitle" DataTextField="Title" DataValueField="CategoryID"
                            Width="150px" DataSource='<%#bingo.AdminCP.Functions.DataType()%>'>
                     </asp:DropDownList>
                   
                </FooterTemplate>
            </asp:TemplateField>

            <asp:CommandField ShowEditButton="true" HeaderText="Sửa" ItemStyle-Width="10%" CausesValidation="false" />
            <asp:TemplateField HeaderText="Xóa" ItemStyle-Width="10%">
                <ItemTemplate>
                    <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ArticleID") %>'
                        CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="btnInsert" runat="Server" Text="Insert" CssClass="button" CommandName="Insert"
                        UseSubmitBehavior="False" ValidationGroup="vlfProperty" />
                    <asp:Button ID="btnCancel" runat="Server" Text="Cancel" CssClass="button" CommandName="Cancel"
                        UseSubmitBehavior="False" />
                </FooterTemplate>
            </asp:TemplateField>

        </Columns>
        <EmptyDataTemplate>
            <h2>
                Danh mục hiện tại chưa có tài liệu nào. Vui lòng nhập tài liệu đầu tiên</h2>
            <table class="tablet">
                <tr>
                    <td>
                        Tiêu Đề
                        <asp:TextBox runat="server" ID="txtETitle" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                            ForeColor="Red" ControlToValidate="txtETitle" ValidationGroup="vlEmpProperty"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        Đường Dẫn
                        <asp:TextBox runat="server" ID="txtETaiLieuURL" Width="300px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ErrorMessage="*"
                            ForeColor="Red" ControlToValidate="txtETaiLieuURL" ValidationGroup="vlEmpProperty"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        Lớp Học
                        <asp:DropDownList runat="server" ID="ddlELopHoc" DataTextField="Title" DataValueField="CategoryID"
                            Width="200px" DataSource='<%#bingo.AdminCP.Functions.DataType()%>'>
                        </asp:DropDownList>
                    </td>
                     <td>
                        Thứ Tự
                        <asp:TextBox runat="server" ID="txtEThuTu" Width="50px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                            ForeColor="Red" ControlToValidate="txtEThuTu" ValidationGroup="vlEmpProperty"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:Button ID="btnInsert" runat="Server" Text="Insert" CommandName="EmptyInsert"
                            ValidationGroup="vlEmpProperty" UseSubmitBehavior="False" CssClass="button" />
                    </td>
                </tr>
            </table>
        </EmptyDataTemplate>
    </asp:GridView>
</div>
