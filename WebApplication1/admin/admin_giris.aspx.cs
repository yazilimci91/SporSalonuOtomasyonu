using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.admin
{
    public partial class admin_giris : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["sporsalonuConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GirisBtn_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
             
            try
            {
                SqlCommand cmd = new SqlCommand("select * from admin_tab where admin_mail='" + adminMailTxt.Text.TrimEnd() + "' and admin_sifre='" + adminSifreTxt.Text.TrimEnd() + "'", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Session["guncellendimi"] = "no";
                    Session["admin_ok"] = "yes";
                    Session["admin_adsoyad"] = "" + reader["admin_adsoyad"];
                    Session["admin_id"] = "" + reader["admin_id"];
                    Session["admin_tel"] = "" + reader["admin_tel"];
                    Session["admin_sifre"] = "" + reader["admin_sifre"];
                    Session["admin_mail"] = "" + reader["admin_mail"];
                    Session["admin_spor_salonu_adi"] = "" + reader["admin_spor_salonu_adi"];
                    Session["admin_spor_salonu_adres"] = "" + reader["admin_spor_salonu_adres"];
                    Session["admin_kayit_tarihi"] = "" + reader["admin_kayit_tarihi"];

                    messageLbl.Visible = true;
                    Panel1.Visible = true;
                    messageLbl.ForeColor = Color.Black;
                    messageLbl.Text = "Basarili";

                    Response.Redirect("Anasayfa.aspx");
                }
                else
                {
                    messageLbl.Visible = true;
                    Panel1.Visible = true;
                    messageLbl.ForeColor = Color.Red;
                    messageLbl.Text = "Email veya şifre hatalı";
                }



            }
            catch (Exception ex)
            {
                messageLbl.Visible = true;
                Panel1.Visible = true;
                messageLbl.Text = "Hata " + ex;

            }
            finally
            {
                con.Close();
                //Response.Redirect("admin_bilgileri_guncelle.aspx");
            }


        }
        protected void SifremiUnuttumLink_Click(object sender, EventArgs e)
        {

        }

        protected void adminMailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void adminSifreTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}