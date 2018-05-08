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

public partial class STAFF_REGISTRATION : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    connections cn = new connections();
    protected void Page_Load(object sender, EventArgs e)
    {
        string sn, srn;
        int n, count = 0;
        // con.Open();
        sn = "select count(REGISTRATIONNO) from STAFFREGISTRATION";
        SqlCommand cmd = new SqlCommand(sn, con);
        con.Open();
        n = int.Parse(cmd.ExecuteScalar().ToString());
        if (n == 0)
        {
            count = 1;
            //string x = "Reg";
            string crn = "Reg0" + count;
            txtstfregno.Text = crn;
        }
        else
        {
            srn = "select max(REGISTRATIONNO) from STAFFREGISTRATION";
            SqlCommand cmd1 = new SqlCommand(srn, con);
            //string c = cmd1.ExecuteScalar().ToString();
            if (n <= 9)
            {

                //str1 = ss11.Substring(10, 2);
                //m = int.Parse(str1);
                //count = m + 1;
                //DateTime dt;
                //dt = DateTime.Now;
                //string yr = dt.ToString("yy");
                //string crn = yr + "PU_CSE_0" + count;
                //txtidno.Text = crn;
                string c = cmd1.ExecuteScalar().ToString();
                string ss = c.Substring(3, 2);
                int mm = int.Parse(ss);
                count = mm + 1;
                string crn1 = "Reg0" + count;
                txtstfregno.Text = crn1;
            }
            else
            {
                srn = "select max(REGISTRATIONNO) from STAFFREGISTRATION";
                SqlCommand cmd2 = new SqlCommand(srn, con);
                string d = cmd2.ExecuteScalar().ToString();
                string ss = d.Substring(3, 2);
                int mm = int.Parse(ss);
                count = mm + 1;
                string crn1 = "Reg" + count;
                txtstfregno.Text = crn1;
            }


        }

        //txtbtechaggre.Enabled = false;
        //txtbtechname.Enabled = false;
        //txtbtechspec.Enabled = false;
        //txtbtechyop.Enabled = false;
        //txtmbaaggre.Enabled = false;
        //txtmbaname.Enabled = false;
        //txtmbaspeci.Enabled = false;
        //txtmbayop.Enabled = false;
        //txtmcaaggre.Enabled = false;
        //txtmcaname.Enabled = false;
        //txtmcaspeci.Enabled = false;
        //txtmcayop.Enabled = false;
        //txtmtechaggre.Enabled = false;
        //txtmtechname.Enabled = false;
        //txtmtechspeci.Enabled = false;
        //txtmtechyop.Enabled = false;
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
  /*  protected void btnsubmit_Click(object sender, EventArgs e)
    {
        
        }*/
   /* protected void btnid_Click(object sender, EventArgs e)
    {
        
    }*/
 /*   protected void btnsubmit_Click(object sender, EventArgs e)
    {
       
    }*/
    protected void btnid_Click(object sender, EventArgs e)
    {
        if (ddldpt.SelectedItem.Text == "CSE")
        {
            txtidno.Text = "";
            //con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STAFFREGISTRATION where DEPARTMENT='" + ddldpt.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU_CSE_0" + count;
                txtidno.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STAFFREGISTRATION where DEPARTMENT='" + ddldpt.SelectedItem.Text + "'";
                SqlCommand cmd1 = new SqlCommand(srn, con);
                ss11 = cmd1.ExecuteScalar().ToString();
                if (n <= 9)
                {
                    str1 = ss11.Substring(9, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU_CSE_0" + count;
                    txtidno.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(10, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU_CSE_" + count;
                    txtidno.Text = crn;
                }

            }
        }
        if (ddldpt.SelectedItem.Text == "ECE")
        {
            txtidno.Text = "";
            //con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STAFFREGISTRATION where DEPARTMENT='" + ddldpt.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU_ECE_0" + count;
                txtidno.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STAFFREGISTRATION where DEPARTMENT='" + ddldpt.SelectedItem.Text + "'";
                SqlCommand cmd1 = new SqlCommand(srn, con);
                ss11 = cmd1.ExecuteScalar().ToString();
                if (n <= 9)
                {
                    str1 = ss11.Substring(9, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU_ECE_0" + count;
                    txtidno.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(10, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU_ECE_" + count;
                    txtidno.Text = crn;
                }

            }


        }
        if (ddldpt.SelectedItem.Text == "IT")
        {
            txtidno.Text = "";
            //con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STAFFREGISTRATION where DEPARTMENT='" + ddldpt.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU_IT_0" + count;
                txtidno.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STAFFREGISTRATION where DEPARTMENT='" + ddldpt.SelectedItem.Text + "'";
                SqlCommand cmd1 = new SqlCommand(srn, con);
                ss11 = cmd1.ExecuteScalar().ToString();
                if (n <= 9)
                {
                    str1 = ss11.Substring(8, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU_IT_0" + count;
                    txtidno.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(9, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU_IT_" + count;
                    txtidno.Text = crn;
                }

            }
        }
        if (ddldpt.SelectedItem.Text == "ACCOUNTS")
        {
            txtidno.Text = "";
            //con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STAFFREGISTRATION where DEPARTMENT='" + ddldpt.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU_AC_0" + count;
                txtidno.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STAFFREGISTRATION where DEPARTMENT='" + ddldpt.SelectedItem.Text + "'";
                SqlCommand cmd1 = new SqlCommand(srn, con);
                ss11 = cmd1.ExecuteScalar().ToString();
                if (n <= 9)
                {
                    str1 = ss11.Substring(8, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU_AC_0" + count;
                    txtidno.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(9, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU_AC_" + count;
                    txtidno.Text = crn;
                }

            }
        }


        if (ddldpt.SelectedItem.Text == "---SELECT---")
        {
            MessageBox.Show("Select Department");
            txtidno.Text = "";
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
 /*   protected void btnsbmt_Click(object sender, EventArgs e)
    {
     
    }*/
    protected void btnsbmt_Click(object sender, EventArgs e)
    {
        cn.connect();
        //string str = cn.stfreg(txtstfregno.Text, txtidno.Text, txtname.Text, txtfana.Text, txtdob.Text, ddldpt.SelectedItem.Text, ddlmasts.SelectedItem.Text, txtphno.Text, txtpanno.Text, txtemailid.Text, txtgender.Text, txttemadd.Text, txttpin.Text, txtperadd.Text, txtppin.Text, txtqua.Text, txtexp.Text, ddldesi.SelectedItem.Text, txtteach.Text, txtpub.Text, txtind.Text, txtpwd.Text, txtrepwd.Text);
        //if (str == "1")
        //{
        //    MessageBox.Show("REGISTERED SUCCESSFULLY");
        //}
        //else
        //{
        //    MessageBox.Show("NOT REGISTERED");
        //}
        if (txtidno.Text == "")
        {
            MessageBox.Show("Select Department And Click On Generate Id button to generate the Student ID");
        }
        else if (txtname.Text == "")
        {
            MessageBox.Show("Enter Candidate Name");
        }
        else if (txtfana.Text == "")
        {
            MessageBox.Show("Enter Father's/Husband's/Guardian's Name");
        }
        else if (txtdob.Text == "")
        {
            MessageBox.Show("Enter Date Of Birth");
        }
        else if (ddldpt.SelectedItem.Text == "")
        {
            MessageBox.Show("Select The Department");
        }
        else if (txtphno.Text == "")
        {
            MessageBox.Show("Enter Phone Number");
        }
        else if (txtpanno.Text == "")
        {
            MessageBox.Show("Enter PanCard Number");
        }
        else if (txtemailid.Text == "")
        {
            MessageBox.Show("Enter Valid ID");
        }
        else if (txtgender.Text == "")
        {
            MessageBox.Show("Enter Gender");
        }
        else if (txttemadd.Text == "")
        {
            MessageBox.Show("Enter Temporary Address");
        }
        else if (txtperadd.Text == "")
        {
            MessageBox.Show("Enter Permanent Address");
        }
        else if (txtpwd.Text == "")
        {
            MessageBox.Show("Enter Password");
        }
        else if (txtrepwd.Text == "")
        {
            MessageBox.Show("Re-Enter Password");
        }
        else if (txtqua.Text == "")
        {
            MessageBox.Show("Enter Qualification");
        }
        else if (txtexp.Text == "")
        {
            MessageBox.Show("Enter Experience");
        }


        else
        {
            //string str = con1.StReg(txtid.Text, ddldept.SelectedItem.Text, txtfname.Text, txtlname.Text, txtfname.Text, txtdob.Text, txtperdet.Text, txtperdet.Text, txtmail.Text, txtnationality.Text, txtrno.Text, txtmobile.Text, txttenname.Text, txttenspec.Text, txtyop.Text, txttenaggre.Text, txtintername.Text, txtintersec.Text, txtinteryop.Text, txtinteraggre.Text, txthtn.Text, txtrank.Text, txtjdt.Text, ddlcaste.SelectedItem.Text, txtallotno.Text, txtannincme.Text, txtaddmno.Text, txttop.Text, txtamtpaid.Text, txtpwd.Text, txtrepwd.Text);
            //if (str == "1")
            string str = cn.stfreg(txtstfregno.Text, txtidno.Text, txtname.Text, txtfana.Text, txtdob.Text, ddldpt.SelectedItem.Text, ddlmasts.SelectedItem.Text, txtphno.Text, txtpanno.Text, txtemailid.Text, txtgender.Text, txttemadd.Text, txttpin.Text, txtperadd.Text, txtppin.Text, txtqua.Text, txtexp.Text, ddldesi.SelectedItem.Text, txtteach.Text, txtpub.Text, txtind.Text, txtpwd.Text, txtrepwd.Text);
            if (str == "1")
            {
                string i = txtidno.Text;
                MessageBox.Show("Successfully Register");
                Response.Redirect("HOME.aspx");
                txtidno.Text = "";
                txtdob.Text = "";
                txtfana.Text = "";
                ddldpt.SelectedItem.Text = "";
                ddlmasts.SelectedItem.Text = "";
                txtgender.Text = "";
                txtname.Text = "";
                txtphno.Text = "";
                txtpanno.Text = "";
                txtemailid.Text = "";
                txttemadd.Text = "";
                txttpin.Text = "";
                txtperadd.Text = "";
                txtppin.Text = "";
                txtqua.Text = "";
                txtexp.Text = "";
                ddldesi.SelectedItem.Text = "";
                txtteach.Text = "";
                txtpub.Text = "";
                txtind.Text = "";
                txtrepwd.Text = "";
                txtpwd.Text = "";
            }
            else
            {
                MessageBox.Show("NOT REGISTERED");
            }
        }
    }
}
    