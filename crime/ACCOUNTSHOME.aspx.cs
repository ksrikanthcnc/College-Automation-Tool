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


public partial class ACCOUNTSHOME : System.Web.UI.Page
{
    connections con = new connections();
    DataTable dt5 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.connect();
        dt5 = con.staffdetails(Session["[ID NUMBER]"].ToString());
        LBLADD.Text = dt5.Rows[0][11].ToString();
        LBLDEPT.Text = dt5.Rows[0][5].ToString();
        LBLDOB.Text = dt5.Rows[0][4].ToString();
        LBLFNAME.Text = dt5.Rows[0][3].ToString();
        LBLID.Text = dt5.Rows[0][1].ToString();
        LBLMAIL.Text = dt5.Rows[0][9].ToString();
        LBLPANNO.Text = dt5.Rows[0][8].ToString();
        LBLDESGNTN.Text = dt5.Rows[0][15].ToString();
        LBLNAME.Text = dt5.Rows[0][2].ToString();
        LBLNMAE.Text = dt5.Rows[0][2].ToString();
        LBLPHNO.Text = dt5.Rows[0][7].ToString();
    
    }
}
