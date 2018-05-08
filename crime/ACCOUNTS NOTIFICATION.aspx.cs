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

public partial class ACCOUNTS_NOTIFICATION : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    connections cn = new connections();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnpost_Click(object sender, EventArgs e)
    {
        cn.connect();
        string NOTIFICATION;
        ////NOTIFICATION = txtntf;
        string str = cn.NOTIFICATION(txtntf.Text);
        if (str == "1")
        {
            MessageBox.Show("successfully posted");
        }
        else
        {
            MessageBox.Show("NOT posted");
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtntf.Text = "";
    }
}
