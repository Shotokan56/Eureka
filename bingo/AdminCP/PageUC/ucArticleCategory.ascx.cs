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
    public partial class ucArticleCategory : System.Web.UI.UserControl
    {
        cmsCategoryDO objCat = new cmsCategoryDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.DevCboDatabinder(cboParent, new cmsCategoryBL().SelectAll(), cmsCategoryDO.TITLE_FIELD, cmsCategoryDO.CATEGORYID_FIELD);
            if (Request.QueryString["CategoryID"] != null)
            {
                objCat.CategoryID = int.Parse(Request.QueryString["CategoryID"].ToString());
                initForm();
            }
            if (!IsPostBack)
            {
                //rdoDanhMuc.Checked = true;
            }
        }

        private void initForm()
        {
            objCat = new cmsCategoryBL().Select(objCat);
            txtTitle.Text = objCat.Title;
            txtDescription.Text = objCat.Description;
            txtDetailContent.Text= objCat.DetailContent;
            chkIsHomePage.Checked = objCat.IsHompage;
            chkIsPublish.Checked = !objCat.IsPublish;
            chkIsMenu.Checked = objCat.IsMenu;
            if (objCat.eTitle == "LopHoc")
            {
                chkIsClass.Checked = true;
            }
            if (objCat.eTitle == "ThongBao")
            {
                ckNoti.Checked = true;
            }
            if (objCat.eTitle == "footmenu")
            {
                ckfootmenu.Checked = true;
            }

            if (objCat.CategoryTypeID == 1) rdoImage.Checked = true;
            else if (objCat.CategoryTypeID == 3) rdoNoiDung.Checked = true;
            else if (objCat.CategoryTypeID == 0) rdoVideo.Checked = true;
            else if (objCat.CategoryTypeID == 2) rdoDanhMuc.Checked = true;
            else if (objCat.CategoryTypeID == 4) rdoTaiLieu.Checked = true;
            else
            {
                rdoDanhMuc.Checked = true;
            }

            if (objCat.ParentID == 0) chkIsTop.Checked = true;
            else
            {
                chkIsTop.Checked = false;
                cboParent.Value = objCat.ParentID.ToString();
            }
            txtOrderID.Text = objCat.OrderID.ToString();
            if (!string.IsNullOrEmpty(objCat.ImageURL))
            {
                hplImage.NavigateUrl = "~/Media/" + objCat.ImageURL;
                hplImage.Visible = true;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objCat.CategoryID <= 0)
            {
                objCat.CreateDate = DateTime.Now;
                objCat.UserCreate = int.Parse(Session["UserID"].ToString());
                new cmsCategoryBL().Insert(objCat);
            }
            else
            {
                new cmsCategoryBL().Update(objCat);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListArticleCategory");
        }

        private void initObject()
        {
            objCat.Title = txtTitle.Text;
            objCat.CreateDate = DateTime.Now;
            objCat.Description = txtDescription.Text;
            objCat.DetailContent = txtDetailContent.Text;
            objCat.IsHompage = chkIsHomePage.Checked;
            objCat.IsPublish = !chkIsPublish.Checked;
            objCat.IsMenu = chkIsMenu.Checked;
            if (chkIsClass.Checked == true)
            {
                objCat.eTitle = "LopHoc";
            }
            if (ckNoti.Checked == true)
            {
                objCat.eTitle = "ThongBao";
            }
            if (ckfootmenu.Checked == true)
            {
                objCat.eTitle = "footmenu";
            }

            if (rdoVideo.Checked) objCat.CategoryTypeID = 0;
            else if (rdoImage.Checked) objCat.CategoryTypeID = 1;
            else if (rdoDanhMuc.Checked) objCat.CategoryTypeID = 2;
            else if (rdoTaiLieu.Checked) objCat.CategoryTypeID = 4;
            else if (rdoNoiDung.Checked)
            {
                objCat.CategoryTypeID = 3;
                objCat.IsContent = rdoNoiDung.Checked;
            }

            objCat.OrderID = int.Parse(txtOrderID.Text);
            //if (chkIsTop.Checked) objCat.ParentID = 0;
            if ((cboParent.SelectedItem != null) && (cboParent.SelectedItem.ToString() != "0"))
            {
                objCat.ParentID = int.Parse(cboParent.Value.ToString());
            }
            else
            {
                objCat.ParentID = 0;
            }


            if (!string.IsNullOrEmpty(fuImage.FileName))
                objCat.ImageURL = UploadFile(fuImage);

            
        }

        private string UploadFile(FileUpload fulImage)
        {
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}