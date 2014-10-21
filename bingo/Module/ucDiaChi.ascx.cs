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
    public partial class ucDiaChi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var obj = new sysConfigBL().Select(new sysConfigDO {ConfigID=3});
            ConfigName.Text = obj.ConfigName.ToString();
            ConfigValue.Text = obj.ConfigValue.ToString();
        }
    }
}