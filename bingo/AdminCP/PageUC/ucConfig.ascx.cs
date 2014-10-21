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
    public partial class ucConfig : System.Web.UI.UserControl
    {
        sysConfigDO objConfig = new sysConfigDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ConfigID"] != null)
            {
                objConfig.ConfigID = int.Parse(Request.QueryString["ConfigID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objConfig = new sysConfigBL().Select(objConfig);
            txtTitle.Text = objConfig.ConfigName;
            // Sử dụng CKEditor
            if (objConfig.ConfigID == 2 )
            {
                trSupport.Visible = false;
                trDes.Visible = true;
                trPopup.Visible = false;
                txtCK.Text = objConfig.ConfigValue;
            }
            if (objConfig.ConfigID == 3)
            {
                trSupport.Visible = true;
                trDes.Visible = false;
                trPopup.Visible = false;
                txtCK.Text = objConfig.ConfigValue;
            }
            if (objConfig.IsActive == true)
            {
                chkActive.Checked = true;
            }
            else
            {
                trSupport.Visible = false;
                trDes.Visible = true;
                trPopup.Visible = false;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objConfig.ConfigID <= 0)
            {
                new sysConfigBL().Insert(objConfig);
            }
            else
            {
                new sysConfigBL().Update(objConfig);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListConfig");
        }

        private void initObject()
        {
            objConfig.ConfigName = txtTitle.Text;

            if (objConfig.ConfigID == 2)
            {
                objConfig.ConfigValue = txtDescription.Text;
            }

            if (objConfig.ConfigID == 3)
            {
                objConfig.ConfigValue = txtCK.Text;
            }
          
            if (chkActive.Checked == true)
            {
                objConfig.IsActive = chkActive.Checked;
            }
        }
        private string UploadFile(FileUpload fulImages)
        {
            if (fulImages.HasFile)
            {
                string FileName = "popupCHTG.jpg";
                if (objConfig.ConfigID == 6)
                    FileName = "banner-logo.jpg";
                if (objConfig.ConfigID == 7)
                    FileName = "bannerright.jpg";

                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                if (System.IO.File.Exists(SaveLocation))
                    System.IO.File.Delete(SaveLocation);
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=ListConfig");
        }

        public string MarshalByRefO { get; set; }
    }
}