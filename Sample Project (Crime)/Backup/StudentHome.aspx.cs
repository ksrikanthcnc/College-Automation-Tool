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

public partial class StudentHome : System.Web.UI.Page
{
    connections con = new connections();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.connect();
        dt = con.stdetails(Session["[ID NUMBER]"].ToString());
        LBLADD.Text = dt.Rows[0][12].ToString();
        LBLDEPT.Text = dt.Rows[0][2].ToString();
        LBLDOB.Text = dt.Rows[0][9].ToString();
        LBLFNAME.Text = dt.Rows[0][5].ToString();
        LBLID.Text = dt.Rows[0][1].ToString();
        LBLMAIL.Text = dt.Rows[0][19].ToString();
        LBLMNAME.Text = dt.Rows[0][7].ToString();
        LBLMOD.Text = dt.Rows[0][16].ToString();
        LBLNAME.Text = dt.Rows[0][3].ToString();
        LBLNMAE.Text = dt.Rows[0][3].ToString();
        LBLPHNO.Text = dt.Rows[0][4].ToString();
}
}
