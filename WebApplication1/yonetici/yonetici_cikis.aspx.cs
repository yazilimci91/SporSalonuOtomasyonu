using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.yonetici
{
    public partial class yonetici_cikis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["yonetici_ok"] = "no";
            Session["yonetici_adsoyad"] = "" ;
            Session["yonetici_id"] = "";
            Session["yonetici_sifre"] = "" ;

            Response.Redirect("yonetici_giris.aspx");
        }
    }
}