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

public partial class STAFF_CHANGE_PASSWORD : System.Web.UI.Page
{
    connections con = new connections();
    DataTable dt1 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.connect();
        dt1 = con.staffdetails(Session["[ID NUMBER]"].ToString());
        txtid.Text = dt1.Rows[0][1].ToString();
    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        con.connect();
        string f = con.CHANGEPASSWORD(txtid.Text, txtpwd.Text, txtrepwd.Text);
        if (f == "1")
        {
            MessageBox.Show("successfully updated");
        }
        else
        {
            MessageBox.Show("Error");
        }

    }
}
