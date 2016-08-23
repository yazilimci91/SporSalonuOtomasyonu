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
    }
}