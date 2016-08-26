using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.admin
{
    public partial class musteri_Ekle : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["sporsalonuConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            try
            {
                 
                SqlCommand cmd = new SqlCommand("insert into uyeler_tab(uye_adsoyad,uye_tc,uye_sifre,uye_mail,uye_tel,uye_kayit_tarihi,uye_bitis_tarihi,admin_id)  values(@ad,@tc,@sifre,@mail,@tel,@ktarih,@btarih,@admin)", con);

                cmd.Parameters.AddWithValue("@ad", txtAdsoyad.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@tc",Convert.ToInt64( txtTc.Text.TrimEnd()));
                cmd.Parameters.AddWithValue("@mail", txtMail.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@btarih", txtBitisTarihi.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@ktarih", txtTarih.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@tel", Convert.ToInt64(txtTel.Text.TrimEnd()));
                cmd.Parameters.AddWithValue("@admin", Convert.ToInt32(Session["admin_id"]));

                cmd.ExecuteNonQuery();

                Label1.Visible = true;
                Panel2.Visible = true;
                Label1.Text = "Başarılı ";

                txtAdsoyad.Text = txtSifre.Text = txtTc.Text = txtBitisTarihi.Text = txtTarih.Text = txtMail.Text = txtTel.Text = "";

            }
            catch (Exception ex)
            {
                Label1.Visible = true;
                Panel2.Visible = true;
                Label1.Text = "Hata " + ex;

            }
            finally
            {
                con.Close();

            }
        }
    }
}