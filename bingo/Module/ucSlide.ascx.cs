using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.DO;
using bingo.BL;
using System.Data;

namespace bingo.Module
{
    public partial class ucSlide : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptSlideDataSource();
        }
        protected void rptSlideDataSource()
        {
            rptSlide.DataSource = new SlideBL().SelectAll();
            rptSlide.DataBind();
          
        }
    }
}