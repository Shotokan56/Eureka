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
    public partial class ucLopSapKhaiGiang : System.Web.UI.UserControl
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
            rptNewClass.DataSource = new cmsCategoryBL().SelectNewClass();
            rptNewClass.DataBind();
            
        }
        protected void LoadDataNewClass(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)item.DataItem;
                int categoryID = int.Parse(drv["CategoryID"].ToString());
                Repeater rptTop = (Repeater)item.FindControl("rptTop1");
                //rptTop1.DataSource = new cmsArticleBL().SelectNewClassTop(1,categoryID);
                //rptTop1.DataBind();

                rptTop = (Repeater)item.FindControl("rptTop3");
                rptTop.DataSource = new cmsArticleBL().SelectNewClassTop(3, categoryID);
                rptTop.DataBind();
            }
        }
    }
}