using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.DO;
using bingo.BL;

namespace bingo.AdminCP.PageUC
{
    public partial class ucTaiLieuHocTap : System.Web.UI.UserControl
    {
        cmsArticleDO objTaiLieu = new cmsArticleDO();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                grvPropertyDataSource();
                
            }
        }
        protected void grvPropertyDataSource()
        {
            if (!IsPostBack)
            {
                ddllop.DataSource = new cmsCategoryBL().SelectClassTaiLieu();
                ddllop.DataBind();
              
            }
            grvProperties.DataSource = new cmsArticleBL().SelectTL(int.Parse(ddllop.SelectedValue.ToString()));
            grvProperties.DataBind();
        }





        protected void grvProperties_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvProperties.EditIndex = e.NewEditIndex;
            grvPropertyDataSource();
        }

        protected void grvProperties_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            objTaiLieu = new cmsArticleDO();
            objTaiLieu.ArticleID = Convert.ToInt32(((Label)grvProperties.Rows[e.RowIndex].Cells[0].FindControl("lblTaiLieuID")).Text);
            objTaiLieu.Title = ((TextBox)grvProperties.Rows[e.RowIndex].Cells[1].FindControl("txtTitle")).Text.Trim();
            objTaiLieu.Description = ((TextBox)grvProperties.Rows[e.RowIndex].Cells[2].FindControl("txtTaiLieuURL")).Text.Trim();
            objTaiLieu.CategoryID = int.Parse(((DropDownList)grvProperties.Rows[e.RowIndex].Cells[4].FindControl("ddlCateTitle")).SelectedValue.ToString());
            objTaiLieu.OrderID = int.Parse(((TextBox)grvProperties.Rows[e.RowIndex].Cells[3].FindControl("txtOrderID")).Text.Trim());
            objTaiLieu.eTitle = "TaiLieu";
            objTaiLieu.CreateDate = DateTime.Now;
            new cmsArticleBL().Update(objTaiLieu);
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
                TextBox txtTitle = (TextBox)grvProperties.Controls[0].Controls[0].FindControl("txtETitle");
                TextBox txtUrl = (TextBox)grvProperties.Controls[0].Controls[0].FindControl("txtETaiLieuURL");
                DropDownList ddlELopHoc = (DropDownList)grvProperties.Controls[0].Controls[0].FindControl("ddlELopHoc");
                TextBox txtThuTu = (TextBox)grvProperties.Controls[0].Controls[0].FindControl("txtEThuTu");


                objTaiLieu.Title = txtTitle.Text.Trim();
                objTaiLieu.Description = txtUrl.Text.Trim();
                objTaiLieu.CategoryID = int.Parse(ddlELopHoc.SelectedValue.ToString());
                objTaiLieu.eTitle = "TaiLieu";
                objTaiLieu.OrderID = int.Parse(txtThuTu.Text);
                objTaiLieu.CreateDate = DateTime.Now;

                new cmsArticleBL().Insert(objTaiLieu);
                //Functions.Alert("Thêm thành công!");
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
                TextBox txtUrl = (TextBox)grvProperties.FooterRow.FindControl("txtFTaiLieuURL");
                DropDownList ddlLopHoc = (DropDownList)grvProperties.FooterRow.FindControl("ddlFCateTitle");
                TextBox txtThuTu = (TextBox)grvProperties.FooterRow.FindControl("txtFOrderID");

                cmsArticleDO objTaiLieu = new cmsArticleDO();
                objTaiLieu.Title = txtTitle.Text.Trim();
                objTaiLieu.Description = txtUrl.Text.Trim();
                objTaiLieu.CreateDate = DateTime.Now;
                objTaiLieu.CategoryID = int.Parse(ddlLopHoc.SelectedValue.ToString());
                objTaiLieu.eTitle = "TaiLieu";
                objTaiLieu.OrderID = int.Parse(txtThuTu.Text);
                objTaiLieu.CreateDate = DateTime.Now;
                new cmsArticleBL().Insert(objTaiLieu);
                //Functions.Alert("Thêm thành công!");
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
            new cmsArticleBL().Delete(new cmsArticleDO { ArticleID = Convert.ToInt32(grvProperties.DataKeys[e.RowIndex].Value) });
           // Functions.Alert("Xóa thành công!");
            grvPropertyDataSource();
        }

        protected void ddllop_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvProperties.DataSource = new cmsArticleBL().SelectTL(int.Parse(ddllop.SelectedValue.ToString()));
            grvProperties.DataBind();
        }

        protected void grvProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}