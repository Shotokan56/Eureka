using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.BL;
using bingo.DO;

namespace bingo.Module
{
    public partial class ucArticle : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptTopDataSource();
        }
        protected void rptTopDataSource()
        {
            rptTop.DataSource = new cmsArticleBL().SelectArticleHome();
            rptTop.DataBind();
            ArticleLeft.DataSource = new cmsArticleBL().SelectMore(1);
            ArticleLeft.DataBind();
            ArticleRight.DataSource = new cmsArticleBL().SelectMore(2);
            ArticleRight.DataBind();

        }
    }
}