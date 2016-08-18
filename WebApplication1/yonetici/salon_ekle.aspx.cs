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
    public partial class salon_ekle : System.Web.UI.Page
    {

        string ConnectionString = ConfigurationManager.ConnectionStrings["sporsalonuConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("insert into admin_tab  values(@ad,@sifre,@salonadi,@mail,@adres,@tarih,@tel)", con);

                cmd.Parameters.AddWithValue("@ad", txtAdsoyad.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@salonadi", txtsalonAdi.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@mail", txtmail.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@adres", txtsalonadres.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@tarih", txtTarih.Text.TrimEnd());
                cmd.Parameters.AddWithValue("@tel",Convert.ToInt64( txtTel.Text.TrimEnd()));

                cmd.ExecuteNonQuery();

                Label1.Visible = true;
                Panel2.Visible = true;
                Label1.Text = "Başarılı " ;

                txtAdsoyad.Text = txtmail.Text = txtmail.Text = txtsalonAdi.Text = txtsalonadres.Text = txtTarih.Text = txtTel.Text = "";

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