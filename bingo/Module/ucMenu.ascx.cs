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
    public partial class ucMenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptTopMenu.DataSource = new cmsCategoryBL().SelectByParent(0);
                rptTopMenu.DataBind();
            }

        }
        protected void rptTopMenu_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
            DataRowView itemData = (DataRowView)e.Item.DataItem;
            HyperLink hplMenu = (HyperLink)e.Item.FindControl("hplMenu");
            if (hplMenu != null)
            {
                hplMenu.NavigateUrl = ReturnTypeLink(itemData["CategoryID"].ToString());
                hplMenu.Text = itemData["Title"].ToString();
                hplMenu.ToolTip = itemData["Title"].ToString();

            }
        }

        public string ReturnTypeLink(string s)
        {
            int i = int.Parse(s);
            if (new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).CategoryTypeID == 1)
            {
                return "/Album/" + i.ToString() + "/" + Ultility.Change_AV(new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).Title);
            }
            if (new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).CategoryTypeID == 0)
            {
                return "/Video/" + i.ToString() + "/" + Ultility.Change_AV(new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).Title);
            }
            if (new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).CategoryTypeID == 3)
            {
                return "/bai-viet/" + i.ToString() + "/" + Ultility.Change_AV(new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).Title);
            }
            if (new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).CategoryTypeID == 4)
            {
                return "/Tai-Lieu/" + Ultility.Change_AV(new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).Title);
            }
            else
            {
                return "/Danh-Muc/" + i.ToString() + "/" + Ultility.Change_AV(new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = i }).Title);
            }
        }
    }
}