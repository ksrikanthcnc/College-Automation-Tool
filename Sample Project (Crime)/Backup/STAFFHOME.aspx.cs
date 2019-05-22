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

public partial class STAFFHOME : System.Web.UI.Page
{
    connections con = new connections();
    DataTable dt1 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.connect();
        dt1 = con.staffdetails(Session["[ID NUMBER]"].ToString());
        LBLID.Text = dt1.Rows[0][1].ToString();
        LBLNAME.Text = dt1.Rows[0][2].ToString();
        LBLNMAE.Text = dt1.Rows[0][2].ToString();
        LBLFNAME.Text = dt1.Rows[0][3].ToString();
        LBLDOB.Text = dt1.Rows[0][4].ToString();
        LBLDEPT.Text = dt1.Rows[0][5].ToString();
        LBLPHNO.Text = dt1.Rows[0][7].ToString();
        LBLPANNO.Text = dt1.Rows[0][8].ToString();
        LBLMAIL.Text = dt1.Rows[0][9].ToString();
        LBLADD.Text = dt1.Rows[0][11].ToString();
        LBLDESGNTN.Text = dt1.Rows[0][15].ToString();
       



    
    }
}
