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
    public partial class ucSlide : System.Web.UI.UserControl
    {
        SlideDO objSlide = new SlideDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["SlideID"] != null)
            {
                hdfImageSlide.Value = "";
                hdfImageSlideThumbnail.Value = "";
                objSlide.SlideID = int.Parse(Request.QueryString["SlideID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objSlide = new SlideBL().Select(objSlide);
            hdfImageSlide.Value = objSlide.SlideImg.ToString();
            imgSlide.ImageUrl = "~/Media/" + objSlide.SlideImg.ToString();
            txtTitle.Text = objSlide.Title;
            txtDescription.Text = objSlide.Description;
            txtSlideURL.Text = objSlide.SlideURL;
            if (!string.IsNullOrEmpty(objSlide.SlideImg))
            {
                if (hdfImageSlide.Value != "")
                {
                    hplImage.Visible = true;
                    hplImage.NavigateUrl = "~/Media/" + objSlide.SlideImg;
                }
            }
            if (!string.IsNullOrEmpty(objSlide.SlideImg))
            {
                if (hdfImageSlideThumbnail.Value != "")
                {
                    hplImageThumbnail.Visible = true;
                }
            }
            txtOrder.Text = objSlide.OrderID.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objSlide.SlideID <= 0)
            {
                new SlideBL().Insert(objSlide);
            }
            else
            {
                new SlideBL().Update(objSlide);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListSlide");
        }

        private void initObject()
        {
            objSlide.Title = txtTitle.Text;
            objSlide.Description = txtDescription.Text;
           
            if (!string.IsNullOrEmpty(fuImage.FileName))
            {
                objSlide.SlideImg = UploadFile(fuImage, "");
            }
            else
            {
                objSlide.SlideImg = hdfImageSlide.Value.ToString();
            }
            objSlide.OrderID = int.Parse(txtOrder.Text);
            objSlide.SlideURL = txtSlideURL.Text;

        }
        private string UploadFile(FileUpload fulImages, string ControlFu)
        {

            string FileName = "";
            if (ControlFu == "Thumbnail")
            {
                if (!string.IsNullOrEmpty(fulImages.FileName))
                {
                    FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss") + "Thumbnail", fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
                    string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                    fulImages.SaveAs(SaveLocation);
                    return FileName;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(fulImages.FileName))
                {
                    FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
                    string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                    fulImages.SaveAs(SaveLocation);
                    return FileName;
                }
            }

            return string.Empty;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=ListSlide");
        }
    }
}