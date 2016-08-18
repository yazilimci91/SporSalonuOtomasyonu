using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.admin
{
    public partial class admin_cikis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["admin_ok"] = "no";
            Session["admin_adsoyad"] = "" ;
            Session["admin_id"] = "" ;
            Session["admin_tel"] = "";
            Session["admin_mail"] = "" ;
            Session["admin_spor_salonu_adi"] = "" ;
            Session["admin_spor_salonu_adres"] = "" ;
            Session["admin_kayit_tarihi"] = "" ;

            Response.Redirect("admin_giris.aspx");

        }
    }
}