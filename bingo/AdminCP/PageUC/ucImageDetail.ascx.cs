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
using bingo.DO;

namespace bingo.AdminCP.PageUC
{
    public partial class ucImageDetail : System.Web.UI.UserControl
    {
        //private static cmsImagesDO obj = new cmsImagesDO();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    int id = 0;
        //    if (Request.QueryString["ImageID"] != null)
        //    {
        //        id = int.Parse(Request.QueryString["ImageID"].ToString());
        //    }
        //    obj = new cmsImagesBL().Select(new cmsImagesDO { ImageID = id });
        //    if (Request.QueryString["AlbumID"] != null)
        //        obj.AlbumID = int.Parse(Request.QueryString["AlbumID"].ToString());
        //    txtDescription.Text = obj.Description;
        //    txteDescription.Text = obj.eDescription;
        //    txtTitle.Text = obj.Title;
        //    txteTitle.Text = obj.eTitle;
        //    chkVideo.Checked = obj.StyleAlbum;
        //    if ((obj.StyleAlbum == true)||(id==0))
        //    {
        //        trPopup.Visible = false;
        //        trVideo.Visible = true;
        //        chkVideo.Checked = true;
        //        if (id == 0)
        //            txtVideo.Text = "";
        //        else
        //            txtVideo.Text = "http://www.youtube.com/watch?v=" + obj.ImgFile;
        //    }
        //    else
        //    {
        //        trPopup.Visible = true;
        //        trVideo.Visible = false;
        //        hplImage.ImageUrl = "~/Media/" + obj.ImgFile;
        //    }
        //}
        //private string UploadFile(FileUpload fulImage)
        //{
        //    if (fuImage.HasFile)
        //    {
        //        string FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
        //        string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
        //        fulImage.SaveAs(SaveLocation);
        //        return FileName;
        //    }
        //    return string.Empty;
        //}
        //private cmsImagesDO init()
        //{
        //    obj.Description = txtDescription.Text;
        //    obj.eDescription = txteDescription.Text;
        //    obj.Title = txtTitle.Text;
        //    obj.eTitle = txteTitle.Text;
        //    obj.StyleAlbum = chkVideo.Checked;
        //    if (chkVideo.Checked == true)
        //    {
        //        string s = txtVideo.Text;
        //        try
        //        {
        //            obj.ImgFile = s.Substring(s.IndexOf("=") + 1, s.IndexOf("&"));
        //        }
        //        catch
        //        {
        //            obj.ImgFile = s.Substring(s.IndexOf("=") + 1);
        //        }
        //    }
        //    else
        //    {
        //        obj.ImgFile = UploadFile(fuImage);
        //    }
        //    return obj;
        //}
        //protected void btnSave_Click(object sender, EventArgs e)
        //{
        //    obj = init();
        //    if (Request.QueryString["ImageID"] != null)
        //    {
        //        obj.ImageID = int.Parse(Request.QueryString["ImageID"].ToString());
        //        new cmsImagesBL().Update(obj);
        //    }
        //    else
        //    {
        //        new cmsImagesBL().Insert(obj);
        //    }
        //    if (obj.StyleAlbum == true)
        //        Functions.Alert("Cập nhật thành công!!", "Default.aspx?Page=AlbumDetail&AlbumID=" + obj.AlbumID + "&Type=1");
        //    else
        //        Functions.Alert("Cập nhật thành công!!", "Default.aspx?Page=AlbumDetail&AlbumID=" + obj.AlbumID + "&Type=0");
        //}

        //protected void btnReset_Click(object sender, EventArgs e)
        //{
        //    if (obj.StyleAlbum == true)
        //        Response.Redirect("Default.aspx?Page=AlbumDetail&AlbumID=" + obj.AlbumID + "&Type=1");
        //    else
        //        Response.Redirect("Default.aspx?Page=AlbumDetail&AlbumID=" + obj.AlbumID + "&Type=0");
        //}
    }
}