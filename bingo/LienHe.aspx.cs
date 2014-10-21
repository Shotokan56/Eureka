using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using bingo.DO;
using bingo.BL;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Configuration;
using System.Web.UI.HtmlControls;


namespace bingo
{
    public partial class LienHe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Liên hệ - Eureka" ;
        }
        private string mailbody()
        {
            string body = "";

            body += "<h2>Thông tin liên hệ từ khách hàng: " + txtTen.Text + "</h2>";
            body += "<h4>Thông tin khách hàng</h4>";
            body += "<table>";

            body += "<tr><td style='width:150px;'>Tiêu đề:</td><td style='font-weight:bold;padding-left:5px;'>" + txtSub.Text + " " + "</td></tr>";
            body += "<tr><td style='width:150px;'>Người gửi: </td><td style='font-weight:bold;padding-left:5px;'>" + txtTen.Text + " " + "</td></tr>";
            body += "<tr><td style='width:150px;'>Email:</td><td style='font-weight:bold;padding-left:5px;'>" + txtEmail.Text + " " + "</td></tr>";
            body += "<tr><td style='width:150px;'>Số điện thoại:</td><td style='font-weight:bold;padding-left:5px;'>" + txtsdt.Text + "</td></tr>";
            body += "</table>";

            body += "<h4>Nội dung </h4>";
            body += "<p style='font-style:italic; color: #a43a42;font-weight:bold;'>" + txtND.Text + "</p>";
            body += "<p> Ngày gửi:" + DateTime.Now + "</p>";


            body += "<br /><br /><br /><p style='font-weight:bold;font-size:15px;'> Đây là email tự động từ website http://bec-mi.com. Vui lòng không trả lời thư này!</p>";

            return body;
        }
        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            Ultility.sendsMail(txtTen.Text, mailbody(), txtSub.Text);
            Ultility.Alert("Chúng tôi đã nhận được phản hồi của bạn. Xin cảm ơn!", "/Default.aspx");
        }
    }
}
