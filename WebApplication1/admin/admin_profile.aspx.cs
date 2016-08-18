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
    public partial class admin_profile : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["sporsalonuConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bilgileri_yeniden_cek();

            if (Session["admin_ok"] == "yes")
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
                SqlCommand cmd = new SqlCommand("select * from admin_tab where admin_id='" + Convert.ToInt32(Session["admin_id"]) + "'", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Session["admin_adsoyad"] = reader["admin_adsoyad"];
                    Session["admin_mail"] = reader["admin_mail"];
                    Session["admin_tel"] = reader["admin_tel"];
                    Session["admin_sifre"] = reader["admin_sifre"];

                    txtAdsoyad.Text = "" + Session["admin_adsoyad"].ToString();
                    txtMail.Text = "" + Session["admin_mail"].ToString();
                    txtTel.Text = "" + Session["admin_tel"].ToString();
                    lblSalonAdi.Text = "" + Session["admin_spor_salonu_adi"];
                    lbladres.Text = "" + Session["admin_spor_salonu_adres"];
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
                    if (txtTel.Text != "")
                    {
                        SqlConnection con = new SqlConnection(ConnectionString);
                        con.Open();
                        try
                        {
                            SqlCommand cmd = new SqlCommand("update admin_tab set admin_adsoyad=@adsoyad,   admin_mail=@mail,  admin_tel=@tel  where admin_id='" + Convert.ToInt32(Session["admin_id"]) + "'", con);

                            cmd.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text.Trim());
                            cmd.Parameters.AddWithValue("@mail", txtMail.Text.Trim());
                            cmd.Parameters.AddWithValue("@tel", Convert.ToInt64(txtTel.Text.Trim()));
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
                        Label1.Text = "Telefon alanı boş bırakmazsınız.";
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