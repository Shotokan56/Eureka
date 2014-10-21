<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSlide.ascx.cs" Inherits="bingo.Module.ucSlide" %>
 <div class="silde-wrap">
          <div class="bannerslide">
        <div class="wt-rotator">
            <a href="#"></a>
            <div class="desc" >
            </div>
            <div class="preloader">
            </div>
            <div class="c-panel">
                <div class="buttons">
                    <div class="prev-btn">
                    </div>
                    <div class="play-btn">
                    </div>
                    <div class="next-btn">
                    </div>
                </div>
                <!--End #buttons-->
                <div class="thumbnails">
                    <ul>
                        <asp:Repeater runat="server" ID="rptSlide">
                            <ItemTemplate>
                                <li><a href='/Media/<%#Eval("SlideImg")%>' title='<%#Eval("Title") %>'></a><a href='<%#Eval("SlideUrl")%>'>
                                </a>
                                    <div style="left: 0px; background-color: #4EA77E; opacity: 0.4; filter: alpha(opacity=40);
                                        top: 236px; height: 300px; width: 960px;">
                                        <span class="cap-title" style="text-transform: uppercase;"><a href='<%#Eval("SlideUrl")%>'>
                                            <%#Eval("Title") %></a> </span>
                                            <span class="description" style="text-transform: uppercase;"><a href='<%#Eval("SlideUrl")%>'>
                                            <%#Eval("Description")%></a> </span>
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <!--End #thumbnails-->
            </div>
            <!--End #c-panel-->
        </div>
    </div>
</div>