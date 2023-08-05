using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Debi
{
    public partial class WebForm1 : System.Web.UI.Page
       


    {
        ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            int hide = Int32.Parse(hid.Text);
            string hdetails = obj.reghot( hide,htlname.Text,loc.Text, dsc.Text , pnum.Text,pswrd.Text );
            int n = hdetails.Length;
           // if (n < 0)
                //lbltx.Text = "yes";
            //else {
                //lbltx.Text = "REGISTERED";
           // }
            Response.Redirect("Imageupload1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            hid.Text = String.Empty;
            pswrd.Text = String.Empty;
            htlname.Text = String.Empty;
            loc.Text = String.Empty;
            dsc.Text = String.Empty;
            pnum.Text = String.Empty;

        }
    }
}