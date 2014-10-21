using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.DO;
using System.Web.UI.HtmlControls;
using System.Data;
using bingo.BL;

namespace bingo
{
    public partial class Album_Image : System.Web.UI.Page
    {
        cmsCategoryDO objCat = new cmsCategoryDO();
        int pageSize = 6;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable dtCategory = new DataTable("dtCategory");
                objCat.CategoryID = int.Parse(Request.QueryString["ID"].ToString());

                dtCategory = new cmsAlbumBL().SelectAll();


                if ((dtCategory.Rows.Count > 0) && (dtCategory != null))
                {
                    Session["Title"] = dtCategory.Rows[0]["Title"].ToString();
                    Page.Title = Session["Title"].ToString();

                    HtmlMeta metaDesc = new HtmlMeta();
                    metaDesc.Name = "description";
                    metaDesc.Content = dtCategory.Rows[0]["Description"].ToString();
                    Page.Header.Controls.Add(metaDesc);

                    HtmlMeta metaKey = new HtmlMeta();
                    metaKey.Name = "keywords";
                    metaKey.Content = dtCategory.Rows[0]["Description"].ToString();
                    Page.Header.Controls.Add(metaKey);

                }
                else
                {
                    Page.Title = "Bingo Album";
                }

                hdfPage.Value = "1";// trang số 1
                this.BindrptOtherNews();
            }

            //if (Session["Title"] != null)
            //{
            //    Page.Title = Session["Title"].ToString();
            //}

            Page.Title = "BNGO ALBUM";
        }

        protected string FriendlyUrl(string strTitle)
        {
            return Ultility.Change_AV(strTitle);
        }

        public void BindrptOtherNews()
        {
            DataTable dtConten = new DataTable("dtConten");
            int page = 0;
            page = int.Parse(hdfPage.Value.ToString());
            dtConten = new cmsAlbumBL().SelectbyPage(page, pageSize);
            if ((dtConten.Rows.Count > 0) && (dtConten != null))
            {
                int pageMax = 0;
                int countRow = 0;
                rptAlbum.DataSource = dtConten;
                rptAlbum.DataBind();
                if (dtConten.Rows[0]["CountRow"] != null)
                {
                    countRow = int.Parse(dtConten.Rows[0]["CountRow"].ToString());
                }
                if (countRow % pageSize == 0)
                {
                    pageMax = countRow / pageSize;
                }
                else
                {
                    pageMax = (countRow / pageSize) + 1;
                }
                if ((page == 1) && (page != pageMax))
                {
                    PreviousPage.Visible = false;
                    NextPage.Visible = true;
                }
                else if ((page != 1) && (page == pageMax))
                {
                    PreviousPage.Visible = true;
                    NextPage.Visible = false;
                }
                else if ((page == 1) && (page == pageMax))
                {
                    PreviousPage.Visible = false;
                    NextPage.Visible = false;
                }
                else
                {
                    PreviousPage.Visible = true;
                    NextPage.Visible = true;
                }
            }
            else
            {
                PreviousPage.Visible = false;
                NextPage.Visible = false;
            }
        }

        protected void NextPage_Click(object sender, EventArgs e)
        {
            hdfPage.Value = Convert.ToString(int.Parse(hdfPage.Value.ToString()) + 1);
            this.BindrptOtherNews();
        }

        protected void PreviousPage_Click(object sender, EventArgs e)
        {
            if (hdfPage.Value != "1")
            {
                hdfPage.Value = Convert.ToString(int.Parse(hdfPage.Value.ToString()) - 1);
            }
            this.BindrptOtherNews();
        }
    }
}