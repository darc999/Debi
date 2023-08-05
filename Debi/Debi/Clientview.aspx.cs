using System;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text;
using System.Drawing;


namespace Debi
{

    public partial class Clientview : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
        SqlConnection sqlCon = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //String name1 = name.Text;

        }

        protected void search_Click(object sender, EventArgs e)
        {
            


           /* String name1 = name.Text;
            

            try
            {

                sqlCon = new SqlConnection("data source=DESKTOP-EIVVAPF;initial catalog=debi2; Trusted_Connection=true;");
                sqlCon.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Database" + ex);
            }
            SqlCommand cmd = new SqlCommand("SELECT RoomDetail.RoomType,RoomDetail.RoomPrice,RoomDetail.Availability,HotelDetails.HotelLocation From RoomDetail Inner join HotelDetails on RoomDetail.HotelID= HotelDetails.HotelID Where HotelName='" + name1 + "' and HotelLocation='"+location.Text+"'", sqlCon);
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                   
                    cmd.Connection = sqlCon;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            /*SqlCommand con = new SqlCommand("SELECT RoomDetail.Image Where HotelName='" + name1 + "' and HotelLocation='" + location.Text + "'", sqlCon);
            SqlDataReader rdr = cmd.ExecuteReader();*/
            /*GridView2.DataSource = rdr;
            GridView2.DataBind();*/
           /* using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }*/


            DataSet rdr = obj.Searcc(name.Text,location.Text);
            GridView1.DataSource = rdr;
            GridView1.DataBind();

        }
        private void LoadImages()
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet rdr = obj.Searcc2(name2.Text);
            GridView2.DataSource = rdr;
            GridView2.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int rid2 = Int32.Parse(roomidd.Text);
            DataSet rdr = obj.Searcc3(rid2);
            GridView3.DataSource = rdr;
            GridView3.DataBind();
        }

        
    }
}