using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.DO;
using bingo.BL;

namespace bingo
{
    public partial class DeThi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptDeThi.DataSource = new cmsArticleBL().SelectNoti(0);
                rptDeThi.DataBind();
            }
        }
    }
}