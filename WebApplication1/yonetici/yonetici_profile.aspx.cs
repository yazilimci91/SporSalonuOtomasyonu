using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient; 

namespace WebApplication1.yonetici
{
   
    public partial class yonetici_profile : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["sporsalonuConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bilgileri_yeniden_cek();

            if (Session["yonetici_ok"] == "yes")
            {
                // bilgileri_yeniden_cek();
            }

            else
            {
                Response.Redirect("admin_giris.aspx");
            }
        }


        public void bilgileri_yeniden_cek()
        {

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from yonetici_tab where yonetici_id='" + Convert.ToInt32(Session["yonetici_id"]) + "'", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Session["yonetici_adsoyad"] = "" + reader["yonetici_adsoyad"];
                    Session["yonetici_id"] = "" + reader["yonetici_id"];
                    Session["yonetici_sifre"] = "" + reader["yonetici_sifre"];
                    Session["yonetici_mail"] = "" + reader["yonetici_mail"];


                    txtAdsoyad.Text = "" + Session["yonetici_adsoyad"].ToString();
                    txtMail.Text = "" + Session["yonetici_mail"].ToString();
                    lblSalonAdi.Text = "" + Session["yonetici_adsoyad"] + " HOŞGELDİNİZ";
                }

            }
            catch
            {


            }
            finally
            {
                con.Close();

            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (txtAdsoyad.Text != "")
            {
                if (txtMail.Text != "")
                {
                     
                        SqlConnection con = new SqlConnection(ConnectionString);
                        con.Open();
                        try
                        {
                            SqlCommand cmd = new SqlCommand("update yonetici_tab set yonetici_adsoyad=@adsoyad,   yonetici_mail=@mail   where yonetici_id='" + Convert.ToInt32(Session["yonetici_id"]) + "'", con);

                            cmd.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text.Trim());
                            cmd.Parameters.AddWithValue("@mail", txtMail.Text.Trim()); 
                            cmd.ExecuteNonQuery();

                            Label1.Visible = true;
                            Panel2.Visible = true;
                            Label1.Text = "Basarili bir şekilde güncelleme yapıldı.";


                            bilgileri_yeniden_cek();

                        }
                        catch
                        {
                            Response.Write("<script>alert('Eksik bir şeyler var...')</script>");
                        }
                        finally
                        {
                            con.Close();
                        }
                     
                   }

                else
                {
                    Label1.Visible = true;
                    Panel2.Visible = true;
                    Label1.Text = "Email boş bırakmazsınız.";
                }
            }

            else
            {
                Label1.Visible = true;
                Panel2.Visible = true;
                Label1.Text = "Ad Soyad boş bırakmazsınız.";
            }
        }

    }
}