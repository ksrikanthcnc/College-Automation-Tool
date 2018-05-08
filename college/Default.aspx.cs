using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\kalyanamsrikanthcnc@gmail.com\\Documents\\Visual Studio 2012\\WebSites\\temp\\sri.mdf';Integrated Security=True;Connect Timeout=30;");
    connections con = new connections();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        con.connect();
        Session["ID"] = uname.Text;
        string str = con.login(uname.Text, password.Text);
        if (password.Text == str)
        {
            string str1 = con.logrole(uname.Text);
            if (str1 == "Student")
                Response.Redirect("student.aspx");
            else if (str1 == "Staff")
                Response.Redirect("staff.aspx");
            else if (str1 == "Accountant")
                Response.Redirect("accountant.aspx");
            else if (str1 == "Admin")
                Response.Redirect("admin.aspx");
        }
    }
}