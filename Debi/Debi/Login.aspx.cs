using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Debi
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UN.Text))
            {
                rslt.Text = "USERNAME IS EMPTY";
            }
            else if (String.IsNullOrEmpty(PW.Text))
            {
                rslt.Text = "PASSWORD IS EMPTY";
            }
            else
            {

                int hotid = Int32.Parse(UN.Text);
                String pass = PW.Text;
                DataSet login = obj.login(hotid, pass);
                if (login != null)
                {
                    rslt.Text = "Ok";
                    Response.Redirect("Imageupload1.aspx");
                }

                else
                {
                    rslt.Text = "Wrong Password";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HotelDetails.aspx");
        }
    }
}