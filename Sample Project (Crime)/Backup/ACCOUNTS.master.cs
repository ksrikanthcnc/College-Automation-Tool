﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class ACCOUNTS : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime dt;
        dt = DateTime.Now;
        txtdate.Text = dt.ToString("dd/MM/yyyy");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}