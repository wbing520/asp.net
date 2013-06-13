using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class FileUpload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button1_Click(object sender, EventArgs e)
    {
        if (fileupload1.HasFile)
        {
            try
            {
                if (fileupload1.PostedFile.ContentType == "application/pdf")
                {
                    if (fileupload1.PostedFile.ContentLength < 10012000)
                    {
                        string filename = Path.GetFileName(fileupload1.FileName);
                        fileupload1.SaveAs(Server.MapPath("~/") + filename);
                        string path = Server.MapPath("~/") + filename;
                        Label1.Text = "File uploaded successfully!" + path;
                       
                    }
                    else
                        Label1.Text = "File maximum size is 10000 Kb";
                }
                else
                    Label1.Text = "Only pdf files are accepted!";
            }
            catch (Exception exc)
            {
                Label1.Text = "The file could not be uploaded. The following error occured: " + exc.Message;
            }
        }
    }
}
    