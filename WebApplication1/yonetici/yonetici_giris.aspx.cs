using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.yonetici
{
    public partial class yonetici_giris : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["sporsalonuConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Boolean giris_yap()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
             
            try
            {
                SqlCommand cmd = new SqlCommand("select * from yonetici_tab where yonetici_mail='" + yoneticiMailTxt.Text.TrimEnd() + "' and yonetici_sifre='" + yoneticiSifreTxt.Text.TrimEnd() + "'", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Session["yonetici_ok"] = "yes";
                    Session["yonetici_adsoyad"] = "" + reader["yonetici_adsoyad"];
                    Session["yonetici_id"] = "" + reader["yonetici_id"];
                    Session["yonetici_sifre"] = "" + reader["yonetici_sifre"];
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                messageLbl.Visible = true;
                Panel1.Visible = true;
                messageLbl.Text = "Hata " + ex;

                return false;

            }
            finally
            {
                con.Close();

            }


        }
        protected void GirisBtn_Click(object sender, EventArgs e)
        {
            if (giris_yap())
            {
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {

                messageLbl.Visible = true;
                Panel1.Visible = true;
                messageLbl.Text = "Email veya şifre hatalı";
            }

        }
        protected void SifremiUnuttumLink_Click(object sender, EventArgs e)
        {

        }
    }
}