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
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace bingo.AdminCP.PageUC
{
    public partial class ucAddMultiImg : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(cboAlbum, cmsAlbumDO.ALBUMID_FIELD, cmsAlbumDO.TITLE_FIELD, new cmsAlbumBL().SelectAll());
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int AlbumID = int.Parse(cboAlbum.SelectedValue.ToString());
            initObject(fuImage1, txtTitle1.Text,AlbumID);
            initObject(fuImage2, txtTitle2.Text, AlbumID);
            initObject(fuImage3, txtTitle3.Text, AlbumID);
            initObject(fuImage4, txtTitle4.Text, AlbumID);
            initObject(fuImage5, txtTitle5.Text, AlbumID);
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListImage");
        }

        private void initObject(FileUpload fulImage, string title,int AlbumID)
        {
            if (string.IsNullOrEmpty(title)) return;
            cmsImagesDO objArt = new cmsImagesDO();
            objArt.Title = title;
            objArt.AlbumID = AlbumID;
            if (!string.IsNullOrEmpty(fulImage.FileName))
                objArt.ImgFile = UploadFile(fulImage, title);
           
            new cmsImagesBL().Insert(objArt);
        }
        private string UploadFile(FileUpload fulImages, string title)
        {

            string FileName = string.Format("{0}{1}", Functions.Change_AV(title) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
            string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
            fulImages.SaveAs(SaveLocation);
            return FileName;
            
          
        }
       

        //public void ResizeImage(string OriginalFile, string NewFile, int NewWidth=800, int MaxHeight=600, bool OnlyResizeIfWider)
        //{
        //    System.Drawing.Image FullsizeImage = System.Drawing.Image.FromFile(OriginalFile);

        //    // Prevent using images internal thumbnail

        //    FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

        //    FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

        //    if (OnlyResizeIfWider)
        //    {

        //        if (FullsizeImage.Width <= NewWidth)
        //        {
        //            NewWidth = FullsizeImage.Width;
        //        }
        //    }

        //    int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;
        //    if (NewHeight > MaxHeight)
        //    {
        //        // Resize with height instead
        //        NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
        //        NewHeight = MaxHeight;
        //    }
        //    System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

        //    // Clear handle to original file so that we can overwrite it if necessary
        //    FullsizeImage.Dispose();

        //    // Save resized picture
        //    NewImage.Save(NewFile);
        //}


    }
}
