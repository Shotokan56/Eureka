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
    public partial class ucListImage : System.Web.UI.UserControl
    {
        public int CurrentPage
        {
            get
            {
                // look for current page in ViewState
                object o = this.ViewState["_CurrentPage"];
                if (o == null)
                    return 0;	// default to showing the first page
                else
                    return (int)o;
            }

            set
            {
                this.ViewState["_CurrentPage"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cboAlbum.DataSource = new DataView(new cmsAlbumBL().SelectAll(), "AlbumID <> 5", "", DataViewRowState.CurrentRows);
                cboAlbum.DataTextField = cmsAlbumDO.TITLE_FIELD;
                cboAlbum.DataValueField = cmsAlbumDO.ALBUMID_FIELD;
                cboAlbum.DataBind();
                cboAlbum.Items.Insert(0, "Chọn tất cả -----------");
            }
            BindList();
        }



        protected void cboAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPage = 0;
            BindList();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
              Response.Redirect("Default.aspx?Page=AddMultiImg");
        }


        protected void dlAlbumDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ImageID = int.Parse(dlAlbumDetail.DataKeys[dlAlbumDetail.SelectedIndex].ToString());
            Response.Redirect("Default.aspx?Page=ImageDetail&ImageID=" + ImageID.ToString());
        }

        protected void dlAlbumDetail_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int PLID = int.Parse(dlAlbumDetail.DataKeys[e.Item.ItemIndex].ToString());
            Xoafile(PLID);
            new cmsImagesBL().Delete(new cmsImagesDO { ImageID = PLID });

            Functions.Alert("Xóa thành công", "Default.aspx?Page=ListImage");
        }

        private void Xoafile(int ID)
        {
            cmsImagesDO Img = new cmsImagesBL().Select(new cmsImagesDO { ImageID = ID });
            string duongdan = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), Img.ImgFile);
            if (System.IO.File.Exists(duongdan))
            {
                System.IO.File.Delete(duongdan);
            }
        }

        private void binddatalist(DataTable dt)
        {
            // use PageDatasource object for paging  purpose..

            PagedDataSource Page = new PagedDataSource();
            try
            {


                Page.AllowPaging = true;
                Page.DataSource = dt.DefaultView;
                Page.PageSize = 21;
                Page.CurrentPageIndex = CurrentPage;
                dlAlbumDetail.DataSource = Page;
                dlAlbumDetail.DataBind();
                lbNext.Enabled = !Page.IsLastPage;
                lbPrev.Enabled = !Page.IsFirstPage;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }



        private void BindList()
        {
           
            if (cboAlbum.SelectedIndex <= 0)
            {
                binddatalist(new cmsImagesBL().SelectAll());

            }
            else
            {
                binddatalist(new cmsImagesBL().SelectByAlbumID(int.Parse(cboAlbum.SelectedValue)));
            }
        }

        protected void lbNext_Click1(object sender, EventArgs e)
        {
            CurrentPage += 1;
            //"CurrentPage" is global variable that content the current page index..
            BindList();
        }

        protected void lbPrev_Click1(object sender, EventArgs e)
        {
            CurrentPage -= 1;
            //"CurrentPage" is global variable that content the current page index..
            BindList();
        }
    }
}