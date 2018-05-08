using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

public partial class staff_student : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\kalyanamsrikanthcnc@gmail.com\\Documents\\Visual Studio 2012\\WebSites\\temp\\sri.mdf';Integrated Security=True;Connect Timeout=30;");
    connections con1 = new connections();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string k = con1.student_marks_action(uname.Text, c1.Text, c2.Text, c3.Text, c4.Text, c5.Text, c6.Text, attendence.Text);
        Response.Redirect("staff.aspx");
    }
}