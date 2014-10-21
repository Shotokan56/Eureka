using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.BL;
using System.Data;

namespace bingo
{
    public partial class TaiLieu : System.Web.UI.Page
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
            rptlop.DataSource = new cmsCategoryBL().SelectClassTaiLieu(); 
            rptlop.DataBind();

        }
        protected void LoadDataLop(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)item.DataItem;
                int categoryID = int.Parse(drv["CategoryID"].ToString());
                Repeater rptTaiLieu = (Repeater)item.FindControl("rptTaiLieu");
                rptTaiLieu.DataSource = new cmsArticleBL().SelectTL(categoryID);
                rptTaiLieu.DataBind();

              
            }
        }
    }
}