﻿using System;
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

public partial class VIEW_STUDENT_ATTENDENCE_BY_STAFF : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        pnl1year.Visible = false;
        pnl21.Visible = false;
        pnl22.Visible = false;
        pnl31.Visible = false;
        pnl32.Visible = false;
        pnl41.Visible = false;
        pnl42.Visible = false;

    }
    protected void btnsbmt_Click(object sender, EventArgs e)
    {
        if (ddldept.SelectedItem.Text == "CSE")
        {
            if (ddlyear.SelectedItem.Text == "Ist Year")
            {
                pnl1year.Visible = true;
            }
            else if (ddlyear.SelectedItem.Text == "2 - 1")
            {
                pnl21.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "2 - 2")
            {
                pnl22.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "3 - 1")
            {
                pnl31.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "3 - 2")
            {
                pnl32.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "4 - 1")
            {
                pnl41.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "4 - 2")
            {
                pnl42.Visible = true;
            }

        }
        if (ddldept.SelectedItem.Text == "IT")
        {
            if (ddlyear.SelectedItem.Text == "Ist Year")
            {
                pnl1year.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "2 - 1")
            {
                pnl21.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "2 - 2")
            {
                pnl22.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "3 - 1")
            {
                pnl31.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "3 - 2")
            {
                pnl32.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "4 - 1")
            {
                pnl41.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "4 - 2")
            {
                pnl42.Visible = true;
            }

        }
        if (ddldept.SelectedItem.Text == "ECE")
        {
            if (ddlyear.SelectedItem.Text == "Ist Year")
            {
                pnl1year.Visible = true;

            }
            if (ddlyear.SelectedItem.Text == "2 - 1")
            {
                pnl21.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "2 - 2")
            {
                pnl22.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "3 - 1")
            {
                pnl31.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "3 - 2")
            {
                pnl32.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "4 - 1")
            {
                pnl41.Visible = true;
            }
            if (ddlyear.SelectedItem.Text == "4 - 2")
            {
                pnl42.Visible = true;
            }

        }
    }
    protected void GridView8_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
