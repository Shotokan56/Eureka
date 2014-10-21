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
using bingo.DO;
using bingo.BL;

namespace bingo.AdminCP.PageUC
{
    public partial class ucClientLogin : System.Web.UI.UserControl
    {
        ClientLoginDO objuser = new ClientLoginDO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ClientLoginID"] != null)
            {
                //objuser.ClientLoginID = int.Parse(Request.QueryString["UserID"]);
                int id = int.Parse(Request.QueryString["ClientLoginID"]);
                initForm(id);
            }

        }

        private void initForm(int id)
        {
            objuser = new ClientLoginBL().Select(new ClientLoginDO {ClientLoginID = id });
            txtClientName.Text = objuser.ClientName;
            txtPassword.Text = objuser.Password;
            txtUsername.Text = objuser.Username;
            //txtDetailInfo.Text = objuser.DetailInfo;
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objuser.ClientLoginID <= 0)
            {
                new ClientLoginBL().Insert(objuser);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListClientLogin");
            }
            else
            {
                new ClientLoginBL().Update(objuser);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListClientLogin");
            }

        }

        private void setobject()
        {
            objuser.Username = txtUsername.Text;
            objuser.Password = txtPassword.Text;
            objuser.ClientName = txtClientName.Text;
            //objuser.DetailInfo = txtDetailInfo.Text;

        }
    }
}