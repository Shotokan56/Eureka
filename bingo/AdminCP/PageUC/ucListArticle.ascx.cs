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
    public partial class ucListArticle : System.Web.UI.UserControl
    {
        private int _NumberItemPerPage = 20;

        public int NumberItemPerPage
        {
            get { return _NumberItemPerPage; }
            set { _NumberItemPerPage = value; }
        }

        int _PageIndex = 1;

        public int PageIndex
        {
            get { return _PageIndex; }
            set { _PageIndex = value; }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dtArticle = new DataTable("dtArticle");
                hdfPageIndex.Value = "0";
                dtArticle = new cmsArticleBL().SelectAll();
                this.BindddlNumberItemPerPageData();
                Functions.ddlDatabinder(cboCategory, cmsCategoryDO.CATEGORYID_FIELD, cmsCategoryDO.TITLE_FIELD, new cmsCategoryBL().SelectAll());
                cboCategory.Items.Insert(0, "------ Chọn tất cả -----");
                this.BindgvListArticleOnPage(dtArticle);
            }
        }

        public void BindgvListArticleOnPage(DataTable dtArticle)
        {
            this.BindddlPageIndexData(dtArticle);
            ddlPageIndex.SelectedValue = Convert.ToString(Int32.Parse(hdfPageIndex.Value.ToString()) + 1);
            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = dtArticle.DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = NumberItemPerPage;
            objPds.CurrentPageIndex = Int32.Parse(hdfPageIndex.Value);

            gvAt.DataSource = objPds;
            gvAt.DataBind();
        }

        protected void BindddlNumberItemPerPageData()
        {
            if (ddlNumberItemPerPage != null)
            {
                for (int i = 5; i <= 50; i += 5)
                {
                    ddlNumberItemPerPage.Items.Add(new ListItem(Convert.ToString(i)));
                }
                ddlNumberItemPerPage.SelectedValue = NumberItemPerPage.ToString();
            }
        }

        protected void BindddlPageIndexData(DataTable dtArticle)
        {
            if (dtArticle.Rows.Count > 0)
            {
                pnlPaging.Visible = true;
                if (ddlPageIndex != null)
                {
                    NumberItemPerPage = Int32.Parse(ddlNumberItemPerPage.SelectedValue);
                    int countArticle = dtArticle.Rows.Count;
                    if ((countArticle % NumberItemPerPage) == 0)
                    {
                        PageIndex = countArticle / NumberItemPerPage;
                        lblTotalPages.Text = Convert.ToString(PageIndex);
                    }
                    else
                    {
                        PageIndex = (countArticle / NumberItemPerPage) + 1;
                        lblTotalPages.Text = Convert.ToString(PageIndex);
                    }
                    ddlPageIndex.Items.Clear();
                    for (int i = 1; i <= PageIndex; i++)
                    {
                        ddlPageIndex.Items.Add(new ListItem(Convert.ToString(i)));
                    }
                    //PageIndex = 1;
                }
            }
            else
            {
                pnlPaging.Visible = false;
            }
        }

        protected void gvArticle_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        {

        }
        
        protected void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex <= 0)
            {
                DataTable dtArticle = new DataTable("dtArticle");
                dtArticle = new cmsArticleBL().SelectAll();
                hdfPageIndex.Value = "0";
                this.BindgvListArticleOnPage(dtArticle);
            }
            else
            {
                DataTable dtArticle = new DataTable("dtArticle");
                dtArticle = new cmsArticleBL().SelectByCategoryID(int.Parse(cboCategory.SelectedValue),0);
                hdfPageIndex.Value = "0";
                this.BindgvListArticleOnPage(dtArticle);
            }
        }
        
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=Article");
        }
        
        protected void gvAt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ArticleID = int.Parse(gvAt.DataKeys[gvAt.SelectedIndex].Value.ToString());
            Response.Redirect("Default.aspx?Page=Article&ArticleID=" + ArticleID.ToString());
        }
        
        protected void gvAt_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            new cmsArticleBL().Delete(new cmsArticleDO { ArticleID = Convert.ToInt32(gvAt.DataKeys[e.RowIndex].Value) });
            Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
        }

        protected void ddlPageIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtArticle = new DataTable("dtArticle");
            hdfPageIndex.Value = Convert.ToString(int.Parse(ddlPageIndex.SelectedValue) - 1);
            NumberItemPerPage = Int32.Parse(ddlNumberItemPerPage.SelectedValue);
            dtArticle = new cmsArticleBL().SelectAll();
            this.BindgvListArticleOnPage(dtArticle);
        }

        protected void ddlNumberItemPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtArticle = new DataTable("dtArticle");
            NumberItemPerPage = Int32.Parse(ddlNumberItemPerPage.SelectedValue);
            hdfPageIndex.Value = "0";
            dtArticle = new cmsArticleBL().SelectAll();
            this.BindgvListArticleOnPage(dtArticle);
        }
    }
}