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
using bingo.DO;
using bingo.BL;

namespace bingo.AdminCP.PageUC
{
    public partial class ucAlbumDetail : System.Web.UI.UserControl
    {
        //private static int type = 0;
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (Request.QueryString["AlbumID"] != null)
        //    {
        //        int id = int.Parse(Request.QueryString["AlbumID"].ToString());
        //        type = int.Parse(Request.QueryString["Type"].ToString());
        //        DataTable dt = new cmsImagesBL().SelectByAlbumID(id, type);
        //        gvAt.DataSource = dt;
        //        gvAt.DataBind();
        //    }
        //}
        //protected void btnAdd_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("Default.aspx?Page=ImageDetail&AlbumID=" + Request.QueryString["AlbumID"].ToString());
        //}
        //protected void gvAt_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int ImageID = int.Parse(gvAt.DataKeys[gvAt.SelectedIndex].Value.ToString());
        //    Response.Redirect("Default.aspx?Page=ImageDetail&ImageID=" + ImageID.ToString() + "&AlbumID=" + Request.QueryString["AlbumID"].ToString());
        //}
        //protected void gvAt_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    new cmsImagesBL().Delete(new cmsImagesDO { ImageID = Convert.ToInt32(gvAt.DataKeys[e.RowIndex].Value) });
        //    Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
        //}
        //public string getImg(string id)
        //{
        //    string s = "";
        //    if (type == 0)
        //    {
        //        return s = "/Media/" + new cmsImagesBL().Select(new cmsImagesDO { ImageID = int.Parse(id) }).ImgFile;
        //    }
        //    else
        //    {
        //        return s = "http://i1.ytimg.com/vi/" + new cmsImagesBL().Select(new cmsImagesDO { ImageID = int.Parse(id) }).ImgFile + "/default.jpg";
        //    }
        //}
    }
}