using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.BL;
using bingo.DO;
using System.Data;

namespace bingo.Module
{
    public partial class ucHomeAlbum : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            rptAnhTo.DataSource = new cmsImagesBL().SelectTop(1);
            rptAnhTo.DataBind();
            rptAlbum.DataSource = new cmsImagesBL().SelectTop(6);
            rptAlbum.DataBind();
           
        }
    }
}