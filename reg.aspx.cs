﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


public partial class reg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\kalyanamsrikanthcnc@gmail.com\\Documents\\Visual Studio 2012\\WebSites\\temp\\sri.mdf';Integrated Security=True;Connect Timeout=30;");
    connections con1 = new connections();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void k_Click(object sender, EventArgs e)
    {
        string k = con1.reg_action(fname.Text, lname.Text, uname.Text, pass.Text, cpass.Text, mobile.Text, role.SelectedItem.Text, email.Text, gender.SelectedItem.Text, place.Text);

        Response.Redirect("Default.aspx");
    }
}