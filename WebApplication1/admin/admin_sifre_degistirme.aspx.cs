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
    public partial class admin_sifre_degistirme : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["sporsalonuConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public  Boolean eski_sifre_kontrol()
        {
            if (txteskiSifre.Text.TrimEnd() == Session["admin_sifre"].ToString().TrimEnd())
            {
                return false;
            }
            else
            {
                return true;
               
            }
            return false;
        }

        public void yeni_sifre() {

            if (txtYenisifre.Text.TrimEnd() == txtYenisifreTekrar.Text.TrimEnd())
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("update admin_tab set admin_sifre=@sifre   where admin_id='" + Convert.ToInt32(Session["admin_id"]) + "'", con);

                    cmd.Parameters.AddWithValue("@sifre", txtYenisifre.Text.Trim());
                    cmd.ExecuteNonQuery();

                    Label1.Visible = true;
                    Panel2.Visible = true;
                    Label1.ForeColor = Color.Black;
                    Label1.Text = "Basarili bir şekilde güncelleme yapıldı.";

                    // Response.Redirect("admin_Giris.aspx");

                }
                catch
                {
                    Response.Write("<script>alert('Eksik bir şeyler var...')</script>");
                }
                finally
                {
                    con.Close();
                    bilgileri_yeniden_cek();
                }

            }
            else
            {
                Label1.Visible = true;
                Panel2.Visible = true;
                Label1.ForeColor = Color.Red;
                Label1.Text = "boş alan bırakmayınız....";
            }
        }
        protected void sifreDegistir(object sender, EventArgs e)
        {
            if (!eski_sifre_kontrol())
            {
                yeni_sifre();
                
            }

            else
            {
                Label1.Visible = true;
                Panel2.Visible = true;
                Label1.ForeColor = Color.Red;
                Label1.Text = "Eski şifre hatalı";
            
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

        

    }
}