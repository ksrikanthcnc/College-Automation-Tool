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
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class STUDENT_REGISTRATION : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    connections cn = new connections();
    protected void Page_Load(object sender, EventArgs e)
    
    {
        if (IsPostBack == false)
        {
            string srn, sn, ss11, st1;
            int n, count = 0, m;
            sn = "select count([REGISTRATION NO]) from STUDENTREGISTRATION";
            SqlCommand cmd = new SqlCommand(sn, con);
            con.Open();
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                txtregno.Text = "Reg" + "-" + "01";
            }
            else
            {
                srn = "select max([REGISTRATION NO]) from STUDENTREGISTRATION";
                SqlCommand cmd1 = new SqlCommand(srn, con);
                string reg = cmd1.ExecuteScalar().ToString();
                
                if (n < 9)
                {
                    string cc = reg.Substring(4, 2);
                    int m1 = int.Parse(cc);
                    count = m1 + 1;
                    txtregno.Text = "Reg" + "-" + "0" + count;
                }
                else if (n < 99)
                {
                    string cc = reg.Substring(4, 2);
                    int m1 = int.Parse(cc);
                    count = m1 + 1;
                    txtregno.Text = "Reg" + "-" + count;
                }
                else
                {
                    string srn1 = "select max([REGISTRATION NO]) from STUDENTREGISTRATION";
                    SqlCommand cmd2 = new SqlCommand(srn1, con);
                    string reg1 = cmd2.ExecuteScalar().ToString();
                    string cc1 = reg.Substring(5, 2);
                    int m11 = int.Parse(cc1);
                    count = m11 + 1;
                }

            }
            
            
        }
        
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }
    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtm2ndinter_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox13_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    /*protected void btnsubmit_Click(object sender, EventArgs e)
    {
        //cn.connect();
        //string str = cn.streg(txtregno.Text, txtid.Text, ddldept.SelectedItem.Text, txtname.Text, txtperno.Text, txtfname.Text, txtfphno.Text, txtmphno.Text, txtdb.Text, txtfoc.Text, txtnapl.Text, txttmpadd.Text, txtpinco.Text, txtperadd.Text, txtppinco.Text, ddlmoa.SelectedItem.Text, txteamra.Text, txthaltickno.Text, txtmailid.Text,txtpwd.Text,txtrepwd.Text);
        //if (str == "1")
        //{
        //    MessageBox.Show("REGISTERED SUCCESSFULLY");
        //}
        //else
        //{
        //  MessageBox.Show("NOT REGISTERED");
        //}
        cn.connect();
        if (txtid.Text == "")
        {
            MessageBox.Show("Select Department And Click On Generate Id button to generate the Student ID");
        }
        if (txtname.Text == "")
        {
            MessageBox.Show("Enter Candidate Name");
        }
        if (txtfname.Text == "")
        {
            MessageBox.Show("Enter Father's Name");
        }
        if (txtfphno.Text == "")
        {
            MessageBox.Show("Enter Father's Phone Number");
        }
        if (txtmname.Text == "")
        {
            MessageBox.Show("Enter Mother's Name");
        }
        if (txtmphno.Text == "")
        {
            MessageBox.Show("Enter Mother's Phone Number");
        }
        if (txtdb.Text == "")
        {
            MessageBox.Show("Enter Valid DOB");
        }
        if (txttmpadd.Text == "")
        {
            MessageBox.Show("Enter Temporary Address");
        }
        if (txtperadd.Text == "")
        {
            MessageBox.Show("Enter Permanent Address");
        }
        if (ddlmoa.SelectedItem.Text == "--select--")
        {
            MessageBox.Show("Select Mode Of Admission");
        }
        if (txteamra.Text == "")
        {
            MessageBox.Show("Enter Eamcet Rank");
        }
        if (txtmailid.Text == "")
        {
            MessageBox.Show("Enter Valid MailID");
        }
        if (txtpwd.Text == "")
        {
            MessageBox.Show("Enter Password");
        }
        if (txtrepwd.Text == "")
        {
            MessageBox.Show("Re-Enter Password");
        }

        else
        {
            //string str = con1.StReg(txtid.Text, ddldept.SelectedItem.Text, txtfname.Text, txtlname.Text, txtfname.Text, txtdob.Text, txtperdet.Text, txtperdet.Text, txtmail.Text, txtnationality.Text, txtrno.Text, txtmobile.Text, txttenname.Text, txttenspec.Text, txtyop.Text, txttenaggre.Text, txtintername.Text, txtintersec.Text, txtinteryop.Text, txtinteraggre.Text, txthtn.Text, txtrank.Text, txtjdt.Text, ddlcaste.SelectedItem.Text, txtallotno.Text, txtannincme.Text, txtaddmno.Text, txttop.Text, txtamtpaid.Text, txtpwd.Text, txtrepwd.Text);
            //if (str == "1")
            string str = cn.streg(txtregno.Text, txtid.Text, ddldept.SelectedItem.Text, txtname.Text, txtperno.Text, txtfname.Text, txtfphno.Text, txtmname.Text, txtmphno.Text, txtdb.Text, txtfoc.Text, txtnapl.Text, txttmpadd.Text, txtpinco.Text, txtperadd.Text, txtppinco.Text, ddlmoa.SelectedItem.Text, txteamra.Text, txthaltickno.Text, txtmailid.Text, txtbssc.Text, txtpssc.Text, txtsscm.Text, txtb1stinter.Text, txtp1stinter.Text, txt1stinterm.Text, txtb2ndinter.Text, txtp2ndinter.Text, txt2ndinterm.Text, txtpwd.Text, txtrepwd.Text);
            if (str == "1")
            {
                string i = txtid.Text;
                MessageBox.Show("Successfully Register the student Of Id");
                Response.Redirect("HOME.aspx");
                txtid.Text = "";
                //txtaddmno.Text = "";
                //txtallotno.Text = "";
                //txtamtpaid.Text = "";
                //txtannincme.Text = "";
                //txtbalnce.Text = "";
                txtdb.Text = "";
                txtfname.Text = "";
                txtmname.Text = "";
                txtentmar.Text = "";
                //txtgender.Text = "";
                txthaltickno.Text = "";
                txtp2ndinter.Text = "";
                txtp1stinter.Text = "";
                txtpssc.Text = "";
                txtb2ndinter.Text = "";
                txtbssc.Text = "";
                txtb1stinter.Text = "";
                txtsscm.Text = "";
                txt1stinterm.Text = "";
                txt2ndinterm.Text = "";
                txtentmar.Text = "";
                txtname.Text = "";
                txtmailid.Text = "";
                txtppinco.Text = "";
                txtpinco.Text = "";
                txtnapl.Text = "";
                txteamra.Text = "";
                txtregno.Text = "";
                txttmpadd.Text = "";
                txtperadd.Text = "";
                txtperno.Text = "";
                txtfphno.Text = "";
                txtfoc.Text = "";
                txtmphno.Text = "";
                txtrepwd.Text = "";
                txtpwd.Text = "";
            }
        }
    }*/
    protected void btnid_Click(object sender, EventArgs e)
    {
        if (ddldept.SelectedItem.Text == "CSE")
        {
            txtid.Text = "";
            con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU1A050" + count;
                txtid.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
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
                    string crn = yr + "PU1A050" + count;
                    txtid.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(8, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU1A05" + count;
                    txtid.Text = crn;
                }

            }


        }
        if (ddldept.SelectedItem.Text == "ECE")
        {
            txtid.Text = "";
            con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU1A040" + count;
                txtid.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
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
                    string crn = yr + "PU1A040" + count;
                    txtid.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(8, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU1A04" + count;
                    txtid.Text = crn;
                }

            }


        }
        if (ddldept.SelectedItem.Text == "IT")
        {
            txtid.Text = "";
            con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU1A020" + count;
                txtid.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
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
                    string crn = yr + "PU1A020" + count;
                    txtid.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(8, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU1A02" + count;
                    txtid.Text = crn;
                }

            }
        }
        if (ddldept.SelectedItem.Text == "--SELECT--")
        {
            MessageBox.Show("Select Department");
            txtid.Text = "";
        }
        
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        cn.connect();
        DateTime dt;
        dt = DateTime.Now;
        txtdt.Text = dt.ToString("dd/MM/yyyy");
        if (txtid.Text == "")
        {
            MessageBox.Show("Select Department And Click On Generate Id button to generate the Student ID");
        }
        if (txtname.Text == "")
        {
            MessageBox.Show("Enter Candidate Name");
        }
        if (txtfname.Text == "")
        {
            MessageBox.Show("Enter Father's Name");
        }
        if (txtfphno.Text == "")
        {
            MessageBox.Show("Enter Father's Phone Number");
        }
        if (txtmname.Text == "")
        {
            MessageBox.Show("Enter Mother's Name");
        }
        if (txtmphno.Text == "")
        {
            MessageBox.Show("Enter Mother's Phone Number");
        }
        if (txtdb.Text == "")
        {
            MessageBox.Show("Enter Valid DOB");
        }
        if (txttmpadd.Text == "")
        {
            MessageBox.Show("Enter Temporary Address");
        }
        if (txtperadd.Text == "")
        {
            MessageBox.Show("Enter Permanent Address");
        }
        if (ddlmoa.SelectedItem.Text == "--select--")
        {
            MessageBox.Show("Select Mode Of Admission");
        }
        if (txteamra.Text == "")
        {
            MessageBox.Show("Enter Eamcet Rank");
        }
        if (txtmailid.Text == "")
        {
            MessageBox.Show("Enter Valid MailID");
        }
        if (txtpwd.Text == "")
        {
            MessageBox.Show("Enter Password");
        }
        if (txtrepwd.Text == "")
        {
            MessageBox.Show("Re-Enter Password");
        }

        else
        {
            //string str = con1.StReg(txtid.Text, ddldept.SelectedItem.Text, txtfname.Text, txtlname.Text, txtfname.Text, txtdob.Text, txtperdet.Text, txtperdet.Text, txtmail.Text, txtnationality.Text, txtrno.Text, txtmobile.Text, txttenname.Text, txttenspec.Text, txtyop.Text, txttenaggre.Text, txtintername.Text, txtintersec.Text, txtinteryop.Text, txtinteraggre.Text, txthtn.Text, txtrank.Text, txtjdt.Text, ddlcaste.SelectedItem.Text, txtallotno.Text, txtannincme.Text, txtaddmno.Text, txttop.Text, txtamtpaid.Text, txtpwd.Text, txtrepwd.Text);
            //if (str == "1")
            string str = cn.streg(txtregno.Text, txtid.Text, ddldept.SelectedItem.Text, txtname.Text, txtperno.Text, txtfname.Text, txtfphno.Text, txtmname.Text, txtmphno.Text, txtdb.Text, txtfoc.Text, txtnapl.Text, txttmpadd.Text, txtpinco.Text, txtperadd.Text, txtppinco.Text, ddlmoa.SelectedItem.Text, txteamra.Text, txthaltickno.Text, txtmailid.Text, txtbssc.Text, txtpssc.Text, txtsscm.Text, txtb1stinter.Text, txtp1stinter.Text, txt1stinterm.Text, txtb2ndinter.Text, txtp2ndinter.Text, txt2ndinterm.Text, txtpwd.Text, txtrepwd.Text, txtdt.Text,txttamt.Text,txtpamt.Text);
            if (str == "1")
            {
                string i = txtid.Text;
                MessageBox.Show("Successfully Register the student Of Id");
                Response.Redirect("HOME.aspx");
                txtid.Text = "";
                //txtaddmno.Text = "";
                //txtallotno.Text = "";
                //txtamtpaid.Text = "";
                //txtannincme.Text = "";
                //txtbalnce.Text = "";
                txtdb.Text = "";
                txtfname.Text = "";
                txtmname.Text = "";
                txtentmar.Text = "";
                //txtgender.Text = "";
                txthaltickno.Text = "";
                txtp2ndinter.Text = "";
                txtp1stinter.Text = "";
                txtpssc.Text = "";
                txtb2ndinter.Text = "";
                txtbssc.Text = "";
                txtb1stinter.Text = "";
                txtsscm.Text = "";
                txt1stinterm.Text = "";
                txt2ndinterm.Text = "";
                txtentmar.Text = "";
                txtname.Text = "";
                txtmailid.Text = "";
                txtppinco.Text = "";
                txtpinco.Text = "";
                txtnapl.Text = "";
                txteamra.Text = "";
                txtregno.Text = "";
                txttmpadd.Text = "";
                txtperadd.Text = "";
                txtperno.Text = "";
                txtfphno.Text = "";
                txtfoc.Text = "";
                txtmphno.Text = "";
                txtrepwd.Text = "";
                txtpwd.Text = "";
            }
        }
    }
    protected void txtsscm_TextChanged(object sender, EventArgs e)
    {

    }

    /*
     
     
     <script runat="server">

</script>

     
     
     */
}
    /*protected void btnid_Click(object sender, EventArgs e)
    
        {
        if (ddldept.SelectedItem.Text == "CSE")
        {
            txtid.Text = "";
            con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU1A050" + count;
                txtid.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
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
                    string crn = yr + "PU1A050" + count;
                    txtid.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(8, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU1A05" + count;
                    txtid.Text = crn;
                }

            }

                     
        }
        if (ddldept.SelectedItem.Text == "ECE")
        {
            txtid.Text = "";
            con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU1A040" + count;
                txtid.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
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
                    string crn = yr + "PU1A040" + count;
                    txtid.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(8, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU1A04" + count;
                    txtid.Text = crn;
                }

            }


        }
        if (ddldept.SelectedItem.Text == "IT")
        {
            txtid.Text = "";
            con.Open();
            string sn, srn, ss11, str1;
            int n, count = 0, m;
            sn = "select count([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
            SqlCommand cmd = new SqlCommand(sn, con);
            n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                count = 1;
                DateTime dt1;
                dt1 = DateTime.Now;
                string yr1 = dt1.ToString("yy");
                string crn1 = yr1 + "PU1A020" + count;
                txtid.Text = crn1;
            }
            else
            {
                srn = "select max([ID NUMBER]) from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'";
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
                    string crn = yr + "PU1A020" + count;
                    txtid.Text = crn;
                }
                else
                {
                    str1 = ss11.Substring(8, 2);
                    m = int.Parse(str1);
                    count = m + 1;
                    DateTime dt;
                    dt = DateTime.Now;
                    string yr = dt.ToString("yy");
                    string crn = yr + "PU1A02" + count;
                    txtid.Text = crn;
                }

            }
        }
        if (ddldept.SelectedItem.Text == "--SELECT--")
        {
            MessageBox.Show("Select Department");
            txtid.Text = "";
        }
    }*/



