using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.BL;
using bingo.DO;

namespace bingo
{
    public partial class LopKhaiGiang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loaddata();
            }
        }

        private void loaddata()
        {


            cmsArticleDO obj = new cmsArticleDO() { ArticleID = int.Parse(Request.QueryString["ID"].ToString()) };
            obj = new cmsArticleBL().Select(obj);
            rightnews.Text = obj.ArticleDetail.ToString();
            Page.Title = obj.Title.ToString();

        }
    }
}