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
    public partial class ucListAlbum : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvAlbumDataSource();
        }
        protected void gvAlbumDataSource()
        {
            gvAlbum.DataSource = new cmsAlbumBL().SelectAll();
            gvAlbum.DataBind();
        }
        protected void gvAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            int AlbumID = int.Parse(gvAlbum.DataKeys[gvAlbum.SelectedIndex].Value.ToString());
            Response.Redirect("Default.aspx?Page=Album&AlbumID=" + AlbumID.ToString());
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=Album");
        }

        protected void gvAlbum_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int AnhBaiViet = Convert.ToInt32(gvAlbum.DataKeys[e.RowIndex].Value.ToString());
            if (AnhBaiViet != 4 || AnhBaiViet !=5)
            {
                try
                {
                    XoaAnh(sender, e);
                    new cmsAlbumBL().Delete(new cmsAlbumDO { AlbumID = Convert.ToInt32(gvAlbum.DataKeys[e.RowIndex].Value) });
                    Functions.Alert("Xóa thành công!", Request.Url.ToString());
                }
                catch (Exception i)
                {
                    Functions.Alert(i.Message, Request.Url.ToString());
                }
                Functions.Alert("Xóa thành công", "Default.aspx?Page=ListAlbum");
            }
            else
            {
                Functions.Alert("Không thể xóa Album này", "Default.aspx?Page=ListAlbum");
            }
        }
        private void XoaAnh(object sender, GridViewDeleteEventArgs e)
        {
            //xóa ảnh đại diện album
            cmsAlbumDO album = new cmsAlbumBL().Select(new cmsAlbumDO { AlbumID = Convert.ToInt32(gvAlbum.DataKeys[e.RowIndex].Value) });
            string duongdan = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), album.CoverImg);
            if (System.IO.File.Exists(duongdan))
            {
                System.IO.File.Delete(duongdan);
            }
            //xóa ảnh trong album
            DataTable dtb = new cmsImagesBL().SelectByAlbumID(Convert.ToInt32(gvAlbum.DataKeys[e.RowIndex].Value));// lấy ra datatable
            foreach (DataRow dr in dtb.Rows)
            {
                //Xóa FIle
                string duongdanimg = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), dr["ImgFile"].ToString());
                if (System.IO.File.Exists(duongdanimg))
                {
                    System.IO.File.Delete(duongdanimg);
                }
                //xóa trong CSDL
                new cmsImagesBL().Delete(new cmsImagesDO { ImageID = Convert.ToInt32(dr["ImageID"].ToString()) });
            }

        }

 
    }
}