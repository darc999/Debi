using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace Debi
{
    public partial class Imageupload1 : System.Web.UI.Page

    {
        ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Visible = false;
               // hyperlink.Visible = false;
                //LoadImages();
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;
            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
                SqlConnection sqlCon = null;
                sqlCon = new SqlConnection("data source=DESKTOP-EIVVAPF;initial catalog=debi2; Trusted_Connection=true;");
                { 
                     SqlCommand cmd = new SqlCommand("spUploadImage", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramName = new SqlParameter()
                    {
                        ParameterName = @"Name",
                        Value = filename
                    };
                    cmd.Parameters.Add(paramName);

                    SqlParameter paramSize = new SqlParameter()
                    {
                        ParameterName = "@Size",
                        Value = fileSize
                    };
                    cmd.Parameters.Add(paramSize);

                    SqlParameter paramImageData = new SqlParameter()
                    {
                        ParameterName = "@ImageData",
                        Value = bytes
                    };
                    cmd.Parameters.Add(paramImageData);

                    SqlParameter paramNewId = new SqlParameter()
                    {
                        ParameterName = "@NewId",
                        Value = -1,
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(paramNewId);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();

                    lblMessage.Visible = true;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Upload Successful";
                    //hyperlink.NavigateUrl = "~/WebForm2.aspx?Id=" +
                       // cmd.Parameters["@NewId"].Value.ToString();
                    String IMGID = cmd.Parameters["@NewId"].Value.ToString();

                    
                    String avl = "";
                    bool check = yes1.Checked;
                    if (check)
                    {
                        avl = yes1.Text;
                    }
                    else
                    {
                        avl = no1.Text;
                    }
                    int hide = Int32.Parse(hid2.Text);

                    string retails = obj.addroom(hide, type.Text, prc.Text, avl,IMGID);
                    int n = retails.Length;
                    if (n < 0)
                        lbltx.Text = "yes";
                    else 
                    {
                        lbltx.Text = "Added";
                    }

                 }
            }

            //webserviceinsert
            

        }
        private void LoadImages()
        {
            DataSet rdr = obj.Viewss();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LoadImages(); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           /* HttpPostedFile postedFile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;
            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
            //{
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
                */String avl = "";
                bool check = yes1.Checked;
                if (check)
                {
                    avl = yes1.Text;
                }
                else
                {
                    avl = no1.Text;
                }
                int ride = Int32.Parse(rid.Text);

                string retails = obj.Updateroom(ride, type.Text, prc.Text, "yes");
                int n = retails.Length;
                if (n < 0)
                    lbltx.Text = "yes";
                else
                {
                    lbltx.Text = "Updated";
                }

           // }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int ride = Int32.Parse(rid.Text);
            string retails = obj.DeleteR(ride);
            int n = retails.Length;
            if (n < 0)
                lbltx.Text = "yes";
            else
            {
                lbltx.Text = "Delete";
            }
        }
    }
}