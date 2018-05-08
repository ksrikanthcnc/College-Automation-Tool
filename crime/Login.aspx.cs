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

public partial class Login : System.Web.UI.Page
{
    SqlConnection con1 = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    connections con = new connections();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsin_Click(object sender, EventArgs e)
    {
        con.connect();
        Session["[ID NUMBER]"] = txtidno.Text;
        string str = con.stlog(txtidno.Text, txtpwd.Text);
        if (txtpwd.Text == str)
        {
            Response.Redirect("StudentHome.aspx");
        }
        else
        {
            string str1 = con.stafflog(txtidno.Text, txtpwd.Text);
            if (txtpwd.Text == str1)
            {
                string dept = "select DEPARTMENT from STAFFREGISTRATION where [ID NUMBER]='" + txtidno.Text + "'";
                SqlCommand CMD = new SqlCommand(dept, con1);
                con1.Open();
                //string str2 = CMD.ExecuteNonQuery().ToString();
                string str2 = CMD.ExecuteScalar().ToString();
                //string str2 = CMD.ExecuteScalar().ToString();
                

                if (str2 == "ACCOUNTS")
                {
                    Response.Redirect("ACCOUNTSHOME.aspx");
                }
                else if (str2 == "CSE" || str2 == "IT" || str2 == "ECE")
                {
                    Response.Redirect("STAFFHOME.aspx");
                }
            }
            else if (txtidno.Text == "BITSW")
            {
                if (txtpwd.Text == "BITSWADMIN")
                {
                    Response.Redirect("HOME.aspx");
                }
            }
        }
    }
}
