<%@ Page Title="" Language="C#" MasterPageFile="~/bingo.Master" AutoEventWireup="true"
    CodeBehind="LienHe.aspx.cs" Inherits="bingo.LienHe" %>

<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="Module/MenuLeft2.ascx" TagName="MenuLeft2" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="imgtop">
        <img src="/images/bannercontent.jpg" alt="bingo" />
    </div>
    <div class="contentnews">
        <div class="left-wrap">
        
        <uc2:MenuLeft2 ID="ucMenuLeft2" runat="server" />
        </div>
    </div>
    <div class="rightnews">
        <h2 class="h2-tilte" id="title" runat="server">
            Liên Hệ
        </h2>
       <%-- <iframe width="670" height="350" frameborder="0" scrolling="no" marginheight="0"
            marginwidth="0" src="https://maps.google.com/maps/ms?msa=0&amp;msid=213084560647430273582.0004d8ae5b2ba40aaf4ec&amp;ie=UTF8&amp;t=m&amp;ll=21.018386,105.803683&amp;spn=0.003505,0.00751&amp;z=17&amp;output=embed">
        </iframe>
        <br />
        <small>Xem <a href="https://maps.google.com/maps/ms?msa=0&amp;msid=213084560647430273582.0004d8ae5b2ba40aaf4ec&amp;ie=UTF8&amp;t=m&amp;ll=21.018386,105.803683&amp;spn=0.003505,0.00751&amp;z=17&amp;source=embed"
            style="color: #0000FF; text-align: left">Eureka</a> ở bản đồ lớn hơn</small>
        <div class="map-box">
            <asp:Label runat="server" ID="ltrContact" Text=""></asp:Label>
        </div>--%>
        <div class="mail" id="mail">
            <br />
            <asp:Label ID="Label2" Text="Họ tên" runat="server" CssClass="span-contact"></asp:Label>
            <asp:TextBox ID="txtTen" runat="server" Width="320px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTen"
                Display="Dynamic" ValidationGroup="btn" ErrorMessage="*"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label1" Text="Tiêu đề" runat="server" CssClass="span-contact"></asp:Label>
            <asp:TextBox ID="txtSub" runat="server" Width="320px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtSub"
                Display="Dynamic" ValidationGroup="btn" ErrorMessage="*"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label6" Text="Email" runat="server" CssClass="span-contact"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" Width="320px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail"
                ErrorMessage="*" ValidationGroup="btn" ValidationExpression="submitGrp" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                ErrorMessage="Email format" Display="Dynamic" ValidationGroup="btn" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Label7" Text="Số điện thoại" runat="server" CssClass="span-contact"></asp:Label>
            <asp:TextBox ID="txtsdt" runat="server" Width="320px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtsdt"
                Display="Dynamic" ValidationGroup="btn" ErrorMessage="*"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label3" Text="Nội dung" runat="server" CssClass="span-contact"></asp:Label>
            <asp:TextBox ID="txtND" runat="server" TextMode="MultiLine" Width="400px" Height="100px"
                CssClass="txtnd"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ValidationGroup="btn"
                ControlToValidate="txtND" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
            <br />
            <br />
            <div style="float: left; width: 100%; margin-top: 5px;">
                <div style="float: left; width: 200px;">
                    <asp:Label ID="Label4" Text="Mã bảo vệ" runat="server" CssClass="span-contact"></asp:Label>
                    <asp:TextBox ID="txtbv" runat="server" Width="70px" Height="20px" />
                </div>
                <div style="float: left; width: 108px; height: 31px; margin: 0; padding: 0;">
                    <cc1:CaptchaControl ID="ccJoin" runat="server" validateIntegratedModeConfiguration="false"
                        CaptchaHeight="31" CaptchaWidth="90" CaptchaBackgroundNoise="Extreme" CaptchaLength="5" />
                    <br />
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="Label5" Text=" " runat="server" CssClass="span-contact"></asp:Label>
            <asp:Button ID="ButtonSend" OnClick="ButtonSend_Click" ValidationGroup="btn" Width="75px"
                Text="Gửi" runat="server" CssClass="button" Style="margin-left: 120px;" />
            <asp:Label ID="lbLoi" Text="" runat="server"></asp:Label>
        </div>
    </div>
    </div>
</asp:Content>
