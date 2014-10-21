using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using bingo.DO;
using bingo.BL;

namespace bingo.AdminCP.PageUC
{
    public partial class ucListVideo : System.Web.UI.UserControl
    {
        cmsImagesDO objImage = new cmsImagesDO();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                grvPropertyDataSource();
            }
        }
        protected void grvPropertyDataSource()
        {
            grvProperties.DataSource = new cmsImagesBL().Selectvideo();
            grvProperties.DataBind();
        }





        protected void grvProperties_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvProperties.EditIndex = e.NewEditIndex;
            grvPropertyDataSource();
        }

        protected void grvProperties_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            objImage = new cmsImagesDO();
            objImage.ImageID = Convert.ToInt32(((Label)grvProperties.Rows[e.RowIndex].Cells[0].FindControl("lblImageID")).Text);
            objImage.Title = ((TextBox)grvProperties.Rows[e.RowIndex].Cells[1].FindControl("txtTitle")).Text.Trim();
            objImage.ImgFile = ((TextBox)grvProperties.Rows[e.RowIndex].Cells[2].FindControl("txtImgFile")).Text.Trim();
            objImage.AlbumID = 5;
            new cmsImagesBL().Update(objImage);
            // tắt khung nhập
            grvProperties.EditIndex = -1;
            grvPropertyDataSource();
        }

        protected void grvProperties_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvProperties.EditIndex = -1;
            grvPropertyDataSource();
        }
        protected void grvProperties_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("EmptyInsert"))
            {
                TextBox txtTitle = (TextBox)grvProperties.Controls[0].Controls[0].FindControl("txtEImagesTitle");
                TextBox txtUrl = (TextBox)grvProperties.Controls[0].Controls[0].FindControl("txtEImagesUrl");

            
                objImage.Title = txtTitle.Text.Trim();
                objImage.ImgFile = txtUrl.Text.Trim();
                objImage.AlbumID = 5;

                new cmsImagesBL().Insert(objImage);
                Functions.Alert("Thêm Video thành công!");
                grvPropertyDataSource();
                
            }
            else if (e.CommandName.Equals("Cancel"))
            {
                grvProperties.ShowFooter = false;
                grvPropertyDataSource();
            }
            if (e.CommandName.Equals("Insert"))
            {
                TextBox txtTitle = (TextBox)grvProperties.FooterRow.FindControl("txtFTitle");
                TextBox txtUrl = (TextBox)grvProperties.FooterRow.FindControl("txtFImgFile");
     
                    cmsImagesDO objImage= new cmsImagesDO();
                    objImage.Title = txtTitle.Text.Trim();
                    objImage.ImgFile = txtUrl.Text.Trim();
                    objImage.AlbumID = 5;
                    new cmsImagesBL().Insert(objImage);
                    Functions.Alert("Thêm thành công!");
                    grvPropertyDataSource();
            }
            
        }

        protected void AddNewRecord(object sender, EventArgs e)
        {
            grvProperties.ShowFooter = true;
            grvPropertyDataSource();
        }
       

        protected void grvProperties_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            new cmsImagesBL().Delete(new cmsImagesDO { ImageID = Convert.ToInt32(grvProperties.DataKeys[e.RowIndex].Value) });
            Functions.Alert("Xóa thuộc tính thành công!");
            grvPropertyDataSource();
        }

    }
}
