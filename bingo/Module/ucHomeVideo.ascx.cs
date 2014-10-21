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
    public partial class ucHomeVideo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string video = new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue;
            //video = "http://youtube.com/embed/" + video.Substring(video.IndexOf('=') + 1);
            //this.ifVideo.Attributes.Add("src", video);
        }
    }
}