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

public partial class FEE_DETAILS : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    connections cn = new connections();
    //string amt;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            txtamtp0.Visible = false;
        //    string view = "select * from STUDENTREGISTRATION where [ID NUMBER]='" + txtsfd.Text + "'";
        //    SqlCommand cmd = new SqlCommand(view, con);
        //    con.Open();
        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    if (dr.HasRows)
        //    {
        //        while (dr.Read())
        //        {
        //            //txttamt.Text = dr[32].ToString();
        //            txtamtp.Text = dr[33].ToString();
        //            //txtname.Text = dr[3].ToString();
        //        }
        //    }
        //    con.Close();
            
        }
        //amt = txttamt.Text;
    }
    //protected void btnupdate_Click(object sender, EventArgs e)
    //{
    //    cn.connect();
    //    string str = cn.upfee(txtamtp.Text, txtsfd.Text);
    //    if (str == "1")
    //    {
    //        MessageBox.Show("Amount Updated");

    //    }
    //    else
    //    {
    //        MessageBox.Show("Amount Not Updated");
    //    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        cn.connect();


        int p = int.Parse(txtamtp.Text);
        string fee;
        int a, b, c;
        a = int.Parse(txtamtp0.Text);
        b = int.Parse(txttamt.Text);
        int k = a + p;
        fee = k.ToString();
        if (k <= b)
        {
            //MessageBox.Show("");
            string str = cn.upfee(fee, txtsfd.Text);
            if (str == "1")
            {
                MessageBox.Show("Amount Updated");

            }
            else
            {
                MessageBox.Show("Amount Not Updated");
            }
        }
       
        //c = b - a;
        //fee = c.ToString();


        

    }
    // string str = cn.feedetails("select  from STUDENTREGISTRATION where 
    protected void btnsbmt_Click(object sender, EventArgs e)
    {
        string view = "select * from STUDENTREGISTRATION where [ID NUMBER]='" + txtsfd.Text + "'";
        SqlCommand cmd = new SqlCommand(view, con);
        con.Open();
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                txttamt.Text = dr[32].ToString();
                txtamtp.Text = dr[33].ToString();
                txtname.Text=dr[3].ToString();        
            }
        }
        string Tamt = txttamt.Text;
        int tam = int.Parse(Tamt);
        
        string amt = txtamtp.Text;
        int am = int.Parse(amt);
        int due = tam - am;
        txtamtd.Text = due.ToString();


    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        //txtamtp.Enabled = true;
        txtamtp.Visible = false;
        txtamtp0.Visible = true;
    }
    protected void txtamtp_TextChanged(object sender, EventArgs e)
    {

        string Tamt = txttamt.Text;
        int tam = int.Parse(Tamt);
        int p = int.Parse(txtamtp.Text);
        //string fee;
        int a, b, c;
        a = int.Parse(txtamtp0.Text);
        b = int.Parse(txttamt.Text);
        int k = a + p;
        //fee = k.ToString();
        int due = tam - k;
        txtamtd.Text = due.ToString();
        
        
        
        //string view = "select * from STUDENTREGISTRATION where [ID NUMBER]='" + txtsfd.Text + "'";
        //SqlCommand cmd = new SqlCommand(view, con);
        //con.Open();
        //SqlDataReader dr;
        //dr = cmd.ExecuteReader();
        //if (dr.HasRows)
        //{
        //    while (dr.Read())
        //    {
        //        txttamt.Text = dr[32].ToString();
        //        //txtamtp.Text = dr[33].ToString();
        //        //txtname.Text = dr[3].ToString();
        //    }
        //}

        //string amt = txtamtp.Text;
        //int am = int.Parse(amt);
        //string Tamt = txttamt.Text;
        //int tam = int.Parse(Tamt);
        //int due = tam - am;
        //txtamtd.Text = due.ToString();
    }
    protected void txtamtd_TextChanged(object sender, EventArgs e)
    {

    }
}
