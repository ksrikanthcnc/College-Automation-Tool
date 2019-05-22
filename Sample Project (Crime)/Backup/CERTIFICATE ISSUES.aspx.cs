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

public partial class CERTIFICATE_ISSUES : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    connections cn = new connections();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        cn.connect();
        string str = cn.cftisus(ddldpt.SelectedItem.Text,txtidno.Text,ddlmoc.SelectedItem.Text,txtmultiline.Text,txtamount.Text);
        if (str == "1")
        {
            MessageBox.Show("CERTIFICATE ISSUED");
        }
        else
        {
            MessageBox.Show("NOT ISSUED");
        }
    }
    protected void ddlmoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlmoc.SelectedItem.Text == "10TH XEROX")
        {
            txtamount.Text = "10";
        }
        else if (ddlmoc.SelectedItem.Text == "INTER XEROX")
        {
            txtamount.Text = "10";
        }
        else if (ddlmoc.SelectedItem.Text == "COURSE COMPLETION CERTIFICATE")
        {
            txtamount.Text = "1400";
        }
        else if (ddlmoc.SelectedItem.Text == "DUPLICATE ID CARD")
        {
            txtamount.Text = "100";
        }
        else if (ddlmoc.SelectedItem.Text == "DUPLICATE HALL TICKET")
        {
            txtamount.Text = "100";
        }
        else if (ddlmoc.SelectedItem.Text == "BONAFIED")
        {
            txtamount.Text = "10";
        }
        else if (ddlmoc.SelectedItem.Text == "CUSTODIAN")
        {
            txtamount.Text = "30";
        }
        else if (ddlmoc.SelectedItem.Text == "TRANSFER CERTIFICATE")
        {
            txtamount.Text = "100";
        }
        else if (ddlmoc.SelectedItem.Text == "--SELECT--")
        {
            txtamount.Text = "";
        }

    }
    protected void btncncl_Click(object sender, EventArgs e)
    {
        ddldpt.SelectedItem.Text="";
        txtidno.Text = "";
        ddlmoc.SelectedItem.Text = "";
        txtmultiline.Text = "";
        txtamount.Text = "";

    }
}
