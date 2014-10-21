using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using bingo.BL;

namespace bingo.AdminCP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            Response.Cache.SetExpires(new DateTime(1900, 01, 01, 00, 00, 00, 00));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblUsername.Text = Session["Username"].ToString();
            }
            if(Request.QueryString.Count == 0)
            {
                Control MnuPage = LoadControl("MenuUC/ucArticle.ascx");
                phSubNav.Controls.Add(MnuPage);
                hplArticle.CssClass = "active";
            }
            else
            {        
                Control CtrlPage = LoadControl("PageUC/uc" + Request.QueryString["Page"] + ".ascx");
                Control MnuPage = null;
                phPageControl.Controls.Add(CtrlPage);
                switch(Request.QueryString["Page"].ToString())
                {
                                    
                
               //Hệ Thống
                    case "ListUser":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucHeThong.ascx");
                        break;
                    case "User":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucHeThong.ascx");
                        break;
                    case "ListSlide":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucHeThong.ascx");
                        break;
                    case "Slide":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucHeThong.ascx");
                        break;
                    case "ListConfig":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucHeThong.ascx");
                        break;
                    case "Config":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucHeThong.ascx");
                        break;
               //Danh Mục
                    case "ListArticleCategory":
                        hplDanhMuc.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucDanhMuc.ascx");
                        break;
                    case "ArticleCategory":
                        hplDanhMuc.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucDanhMuc.ascx");
                        break;
                    case "ListLink":
                        hplDanhMuc.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucDanhMuc.ascx");
                        break;
               //Tin Tức   

                    case "ListArticle":
                        hplArticle.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucArticle.ascx");
                        break;
                    case "Article":
                        hplArticle.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucArticle.ascx");
                        break;
                    case "DeThi":
                        hplArticle.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucArticle.ascx");
                        break;
                    case "TaiLieuHocTap":
                        hplArticle.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucArticle.ascx");
                        break;
               //Hình Ảnh
                    case "ListAlbum":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucAlbum.ascx");
                        break;
                    case "Album":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucAlbum.ascx");
                        break;
                    case "ListImage":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucAlbum.ascx");
                        break;
                    case "Image":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucAlbum.ascx");
                        break;
                    case "AddMultiImg":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucAlbum.ascx");
                        break;
                    case "ListVideo":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucAlbum.ascx");
                        break;
                }
                phSubNav.Controls.Add(MnuPage);
            }
        }

       
    }
}
