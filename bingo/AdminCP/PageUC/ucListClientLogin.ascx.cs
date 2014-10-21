using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using bingo.BL;
using bingo.DO;

namespace bingo.AdminCP.PageUC
{
    public partial class ucListClientLogin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadClientLogin();
        }

        private void LoadClientLogin()
        {
            gvClientLogin.DataSource = new ClientLoginBL().SelectAll();
            gvClientLogin.DataBind();
        }

        protected void gvClientLogin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvClientLogin.PageIndex = e.NewPageIndex;
            LoadClientLogin();
        }

        protected void gvClientLogin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new ClientLoginBL().Delete(new ClientLoginDO { ClientLoginID = Convert.ToInt32(gvClientLogin.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvClientLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ClientLoginID = Convert.ToInt32(gvClientLogin.DataKeys[gvClientLogin.SelectedIndex].Value);
            Ultility.RedirectPage("Default.aspx?Page=ClientLogin&ClientLoginID=" + ClientLoginID.ToString());
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Ultility.RedirectPage("Default.aspx?Page=ClientLogin");
        }
    }
}