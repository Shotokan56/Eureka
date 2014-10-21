using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bingo.DO;
using bingo.BL;

namespace bingo.AdminCP.PageUC
{
    public partial class ucUser : System.Web.UI.UserControl
    {
        sysUserDO objuser = new sysUserDO();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["UserID"] != null)
            {
                int id = int.Parse(Request.QueryString["UserID"]);
                initForm(id);
            }
            else
            {
                btSave.Text = "Thêm";
                btSave.CommandName = "them";
            }
        }

        private void initForm(int id)
        {
            objuser.UserID = id;
            objuser = new sysUserBL().Select(objuser);
            txtEmail.Text = objuser.Email;
            txtPassword.Text = "";
            txtUsername.Text = objuser.Username;
            cbActive.Checked = objuser.IsActive;
            if (objuser.UserType == 1) cbAdmin.Checked = true;
            txtFullname.Text = objuser.FullName;
            txtYahoo.Text = objuser.YahooIM;
            txtAddress.Text = objuser.Address;
            btSave.Text = "Lưu";
            btSave.CommandName = "luu";
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            sysUserDO obj = setobject();
            if (objuser.UserID <= 0)
            {
                new sysUserBL().Insert(obj);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListUser");
            }
            else
            {
                new sysUserBL().Update(obj);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListUser");
            }

        }

        private sysUserDO setobject()
        {
            sysUserDO obj = new sysUserDO();
            obj.UserID = objuser.UserID;
            obj.Username = txtUsername.Text;
            if (!string.IsNullOrEmpty(txtPassword.Text))
                obj.Password = Functions.EncryptMd5(txtPassword.Text);
            obj.Email = txtEmail.Text;
            obj.IsActive = cbActive.Checked;
            if (cbAdmin.Checked) obj.UserType = 1;
            obj.Address = txtAddress.Text;
            obj.YahooIM = txtYahoo.Text;
            txtFullname.Text = txtFullname.Text;
            return obj;
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=ListUser");
        }
       
    }
}