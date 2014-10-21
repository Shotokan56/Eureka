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
    public partial class ucNoti : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                rptNoti.DataSource = new cmsArticleBL().SelectNoti(0);
                rptNoti.DataBind();
            }
        }
    }
}