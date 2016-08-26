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
    public partial class Anasayfa : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["sporsalonuConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            salonSayisi();
            sonBirHaftasiKalanlarinSayisi();
            sonBirGunuKalanlarinSayisi();
        }

        public void salonSayisi()
        {

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select count(admin_id) as 'adet' from admin_tab", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    //  Response.Write("" + dr["adet"].ToString());
                    lbltoplam.Text = dr["adet"].ToString();
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

        public void sonBirHaftasiKalanlarinSayisi()
        {

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select count(*) as adet from uyeler_tab where datediff(day,GETDATE(),uye_bitis_tarihi) < 7", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    //  Response.Write("" + dr["adet"].ToString());
                    lblhafta.Text = dr["adet"].ToString();
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

        public void sonBirGunuKalanlarinSayisi()
        {

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select count(*) as adet from uyeler_tab where datediff(day,GETDATE(),uye_bitis_tarihi) <2", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    //  Response.Write("" + dr["adet"].ToString());
                    lblsongun.Text = dr["adet"].ToString();
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