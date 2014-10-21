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
    public partial class ucImages : System.Web.UI.UserControl
    {
        cmsImagesDO objArt = new cmsImagesDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Functions.ddlDatabinder(cboAlbum, cmsSanPhamDO.SANPHAMID_FIELD, cmsSanPhamDO.TENSANPHAM_FIELD, new cmsSanPhamBL().SelectAll());
            //if (Request.QueryString["ImageID"] != null)
            //{
            //    objArt.ImageID = int.Parse(Request.QueryString["ImageID"].ToString());
            //    initForm();
            //}
        }

        //private void initForm()
        //{
        //    objArt = new cmsImagesBL().Select(objArt);
        //    txtTitle.Text = objArt.Title;
        //    txtDescription.Text = objArt.Description;


        //    cboAlbum.SelectedValue = objArt.SanPhamID.ToString();

        //    if (!string.IsNullOrEmpty(objArt.ImgFile))
        //    {
        //        hplImage.Visible = true;
        //        hplImage.NavigateUrl = "~/Media/" + objArt.ImgFile;
        //    }
            
        //}

        //protected void btnSave_Click(object sender, EventArgs e)
        //{
        //    initObject();
        //    if (objArt.ImageID <= 0)
        //    {
        //        new cmsImagesBL().Insert(objArt);
        //    }
        //    else
        //    {
        //        new cmsImagesBL().Update(objArt);
        //    }
        //    Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListImage");
        //}
        //private void initObject()
        //{
        //    objArt.Title = txtTitle.Text;
        //    objArt.Description = txtDescription.Text;
        //    objArt.SanPhamID = int.Parse(cboAlbum.SelectedValue.ToString());
        //    if (!string.IsNullOrEmpty(fuImage.FileName))
        //        objArt.ImgFile = UploadFile(fuImage);
           
        //}

        private string UploadFile(FileUpload fulImages)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {
                string FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}