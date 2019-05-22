using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

public partial class delete_reg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=SRIKA\\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;");
    connections con1 = new connections();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string k = con1.delete_reg_action(uname.Text);
        Response.Redirect("admin.aspx");
    }
}