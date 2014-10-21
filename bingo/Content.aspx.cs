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
    public partial class Content : System.Web.UI.Page
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

            cmsCategoryDO obj = new cmsCategoryDO() { CategoryID = int.Parse(Request.QueryString["ID"].ToString()) };
            obj = new cmsCategoryBL().Select(obj);
            rightnews.Text = obj.DetailContent.ToString();
            //title.InnerText = obj.Title.ToString();
            Page.Title = obj.Title.ToString();
            
        }
    }
}