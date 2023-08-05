using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection sqlCon = null;

        public SqlConnection getConnetion()
        {
            try
            {
                sqlCon = new SqlConnection("data source=DESKTOP-EIVVAPF;initial catalog=debi2; Trusted_Connection=true;");
                sqlCon.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Database" + ex);
            }
            return sqlCon;
        }

        [WebMethod]
        public string reghot(int hid, string htlname, string loc, string dsc, string pnum, string pswrd)
        {
            int result = 0;
            try
            {
                getConnetion();
                SqlCommand cmd = new SqlCommand("insert into HotelDetails values('" + hid + "','" + htlname + "','" + loc + "','" + dsc + "','" + pnum + "','" + pswrd + "');", sqlCon);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return result.ToString();
        }
        [WebMethod]
        public DataSet login(int hid, string pswrd)
        {
            DataSet logincon = new DataSet();

            try
            {
                getConnetion();
                SqlCommand cmd = new SqlCommand("Select * from HotelDetails where HotelID = '" + hid + "' and HotelPassword = '" + pswrd + "'", sqlCon);
                SqlDataAdapter lgin = new SqlDataAdapter(cmd);
                lgin.Fill(logincon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return logincon;
        }
        [WebMethod]
        public string addroom(int hid,string type, string prc,string avl,string imgid)
        {
            int added = 0;
            try
            {
                getConnetion();  
                SqlCommand cmd = new SqlCommand("insert into RoomDetail "
                  + "(HotelID,RoomType,RoomPrice,Availability,Id) values ('" + hid + "','" + type + "','" + prc + "','" + avl + "','" + imgid + "');", sqlCon);

                added = cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return added.ToString();

        }
        [WebMethod]
        public string registerRooms(int hid, string type, string prc, string avl, string imgid)
        {
            int noRecords = 0;
            
            try
            {
                getConnetion();
                SqlCommand cmd = new SqlCommand("insert into RoomDetail values('" + hid + "','" + type + "','" + prc + "','" + avl + "','" + imgid + "');", sqlCon);
                noRecords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noRecords.ToString();
        }
        [WebMethod]
        public DataSet Viewss()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnetion();
                SqlCommand cmd = new SqlCommand("Select Roomdetail.RoomID, Roomdetail.RoomType, Roomdetail.RoomPrice, Roomdetail.Availability, HotelDetails.HotelName,HotelDetails.HotelLocation,Roomdetailss.ImageData  FROM ((Roomdetail INNER JOIN RoomDetailss ON RoomDetailss.Id = Roomdetail.Id) INNER JOIN HotelDetails ON Roomdetail.HotelID =HotelDetails.HotelID);", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "rooms");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error searching available rooms" + ex);
            }
            return ds;
        
        }
        [WebMethod]
        public string Updateroom(int hid, string type, string prc, string avl)
        {
            int added = 0;
            try
            {
                getConnetion();
                //UPDATE data SET Age='28' WHERE id=201
                SqlCommand cmd = new SqlCommand("UPDATE RoomDetail SET RoomType='" + type + "',RoomPrice='" + prc + "',Availability='" + avl + "' Where RoomID='" + hid + "'", sqlCon);
               // SqlCommand cmd = new SqlCommand("UPDATE RoomDetail SET RoomType=@type,RoomPrice=@prc,Availability=@avl,Id =@imgid WHERE HotelID =@hid");
                added = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return added.ToString();

        }
        [WebMethod]
        public string DeleteR(int hid)
        {
            int added = 0;
            try
            {
                getConnetion();
               
                SqlCommand cmd = new SqlCommand("DELETE RoomDetail Where RoomID='" + hid + "'", sqlCon);
               
                added = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return added.ToString();

        }
        [WebMethod]
        public DataSet Searcc(string hname,string loc)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnetion();
               /* SELECT `locations`.`name`
      FROM `locations`
INNER JOIN `school_locations`
        ON `locations`.`id` = `school_locations`.`location_id`
INNER JOIN `schools`
        ON `school_locations`.`school_id` = `schools_id`
     WHERE `type` = 'coun';*/
                //SqlCommand cmd = new SqlCommand("Select Roomdetail.RoomType, Roomdetail.RoomPrice, HotelDetails.HotelLocation,Roomdetailss.ImageData  FROM ((Roomdetail INNER JOIN RoomDetailss ON RoomDetailss.Id = Roomdetail.Id) INNER JOIN HotelDetails ON Roomdetail.HotelID =HotelDetails.HotelID Where where HotelName like'" + hname + "%'", sqlCon);
                //SqlCommand cmd = new SqlCommand("Select HotelLocation from HotelDetails Where HotelName='" + hname + "');", sqlCon);
                SqlCommand cmd = new SqlCommand("select HotelName,HotelLocation,HotelDetails.HotelDiscription from HotelDetails where HotelName like'" + hname + "%' and HotelLocation like'" + loc + "%'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "rooms");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching available rooms" + ex);
            }
            return ds;

        }
        [WebMethod]
        public DataSet Searcc2(string hname)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnetion();

                SqlCommand cmd = new SqlCommand("select RoomDetail.RoomID,RoomDetail.RoomType,RoomDetail.RoomPrice,RoomDetail.Availability,HotelDetails.HotelName from (RoomDetail inner join HotelDetails on RoomDetail.HotelID= HotelDetails.HotelID) where HotelName like'" + hname + "%'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "rooms");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching available rooms" + ex);
            }
            return ds;

        }
        [WebMethod]
        public DataSet Searcc3(int rid)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnetion();

                SqlCommand cmd = new SqlCommand("select RoomDetail.RoomID,RoomDetailss.ImageData from (RoomDetail inner join RoomDetailss on RoomDetail.Id= RoomDetailss.Id) where RoomID like'" + rid + "%'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "rooms");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return ds;

        }

    }

}
