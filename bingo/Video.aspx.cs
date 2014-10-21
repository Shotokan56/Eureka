using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.DO;
using System.Data;
using bingo.BL;
using System.Web.UI.HtmlControls;

namespace bingo
{
    public partial class Video : System.Web.UI.Page
    {

        cmsCategoryDO objCat = new cmsCategoryDO();
        int pageSize = 6;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
               
                hdfPage.Value = "1";// trang số 1
                this.BindrptOtherNews();
            }

         

            Page.Title = "Video English";
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
            dtConten = new cmsImagesBL().Selectvideobypage(page,pageSize);
            if ((dtConten.Rows.Count > 0) && (dtConten != null))
            {
                int pageMax = 0;
                int countRow = 0;
                rptVideo.DataSource = dtConten;
                rptVideo.DataBind();
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