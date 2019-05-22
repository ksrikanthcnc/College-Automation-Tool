using System;
using System.Data;
using System.Configuration;
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

/// <summary>
/// Summary description for connections
/// </summary>'
public class connections
{
    SqlConnection con = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    DataTable dt = new DataTable();
    DataTable dt1 = new DataTable();
    DataTable dt2 = new DataTable();
    DataTable dt5 = new DataTable();
	public connections()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void connect()
    {
        SqlConnection con = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    }

    //Student Registration
    public string streg(string REGISTRATIONNO, string IDNUMBER, string DEPARTMENT, string NAMEOFTHECANDIDATE, string PERSONALNUMBER, string FATHERSGUARDIANSNAME, string FathersPhno, string Mothersname, string MothersPhno, string dob, string fathersoccupation, string native, string tempadd, string tpin, string permadd, string ppin, string moad, string erank, string ehno, string mail, string sscinstitutionname, string sscyearofpassed, string sscaggregate, string inter1stnameofinstitute, string inter1styrpassed, string inter1styraggregate, string inter2ndnameofinstitute, string inter2ndyrpassed, string inter2ndyraggregate, string pwd, string repwd,string date ,string totamt,string paidamt)
    {
        try
        {
            string str = "insert into STUDENTREGISTRATION([REGISTRATION NO],[ID NUMBER],DEPARTMENT,[NAME OF THE CANDIDATE],[PERSONAL NUMBER],[FATHER'S/GUARDIAN'S NAME],[FATHER'S PH.NO.],[MOTHERS NAME],[MOTHER'S PH.NO.],[DATE OF BIRTH],[FATHER'S OCCUPATION],[NATIVE PLACE],[TEMPORARY ADDRESS],[T.PINCODE],[PERMANENT ADDRESS],[P.PINCODE],[MODE OF ADMISSION],[EAMCET RANK],[ENTRANCE HALL TICKET NO.],[EMAIL ID],[SSC NAME OF INSTITUTION/UNIVERSITY],[SSC YEAR OF PASSED],[SSC AGGREGATE],[INTER1ST NAME OF INSTITUTION],[INTER1ST YEAR OF PASSED],[INTER1ST AGGREGATE],[INTER2ND NAME OF INSTITUTION],[INTER2ND YEAR OF PASSED],[INTER2ND AGGREGATE],PASSWORD,REENTERPASSWORD,DATE, TOTALAMOUNT,AMOUNTPAID) values('" + REGISTRATIONNO + "','" + IDNUMBER + "','" + DEPARTMENT + "','" + NAMEOFTHECANDIDATE + "','" + PERSONALNUMBER + "','" + FATHERSGUARDIANSNAME + "','" + FathersPhno + "','" + Mothersname + "','" + MothersPhno + "','" + dob + "','" + fathersoccupation + "','" + native + "','" + tempadd + "','" + tpin + "','" + permadd + "','" + ppin + "','" + moad + "','" + erank + "','" + ehno + "','" + mail + "','" + sscinstitutionname + "','" + sscyearofpassed + "','" + sscaggregate + "','" + inter1stnameofinstitute + "','" + inter1styrpassed + "','" + inter1styraggregate + "','" + inter2ndnameofinstitute + "','" + inter2ndyrpassed + "','" + inter2ndyraggregate + "','" + pwd + "','" + repwd + "','" + date + "','" + totamt +"','"+ paidamt +"')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }

    ///Student Registration
    
    ///STAFF REGISTATION
    public string stfreg(string REGISTRATIONNO, string IDNUMBER, string name, string FATHERSGUARDIANSHUSBANDNAME, string DATEOFBIRTH, string department, string Maritalstatus, string phoneno, string pancardno, string emailid, string gender, string tempadd, string tpin, string permadd, string ppin, string qualification, string experience, string designation, string teachingexp, string publications, string industryexp, string pwd, string repwd)
    {
        try
        {
            string str = "insert into STAFFREGISTRATION(REGISTRATIONNO,[ID NUMBER],NAME,FATHERSGUARDIANSHUSBANDNAME,DATEOFBIRTH,DEPARTMENT,MARITALSTATUS,PHONENO,PANCARDNO,EMAILID,GENDER,TEMPORARYADDRESS,[T.PINCODE],PERMANENTADDRESS,[P.PINCODE],QUALIFICATION,EXPERIENCE,DESIGNATION,TEACHINGEXPERIENCE,PUBLICATIONS,INDUSTRYEXPERIENCE,PASSWORD,REENTERPASSWORD) values('" + REGISTRATIONNO + "','" + IDNUMBER + "','" + name + "','" + FATHERSGUARDIANSHUSBANDNAME + "','" + DATEOFBIRTH + "','" + department + "','" + Maritalstatus + "','" + phoneno + "','" + pancardno + "','" + emailid + "','" + gender + "','" + tempadd + "','" + tpin + "','" + permadd + "','" + ppin + "','" + qualification + "','" + experience + "','" + designation + "','" + teachingexp + "','" + publications + "','" + industryexp + "','" + pwd + "','" + repwd + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }
    
    ///STAFF REGISTATION
    
    ///CERTIFICATE ISSUES

    public string cftisus(string department, string idno, string moc, string reason, string amount)
    {
        try
        {
            string str = "insert into CERTIFICATEISSUE(DEPARTMENT, [ID NUMBER], MODEOFCERTIFICATE, REASON, AMOUNT) values('" + department + "','" + idno + "','" + moc + "','" + reason + "','" + amount + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }

    //Student Home
    public DataTable stdetails(string id)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from STUDENTREGISTRATION where [ID NUMBER]='" + id + "'", con);
        da.Fill(dt);
        return dt;
    }
    //Student Home

    //stlogin
    public string stlog(string id, string pwd)
    {
        try
        {
            string str = "select PASSWORD from STUDENTREGISTRATION where [ID NUMBER]='" + id + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            string pwd1 = cmd.ExecuteScalar().ToString();
            return pwd1;
        }
        catch (Exception e)
        {
            return "0";
        }
    }
    //stlogin
    //STAFF LOGIN
    public DataTable staffdetails(string id)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from STAFFREGISTRATION where [ID NUMBER]='" + id + "'", con);
        da.Fill(dt1);
        return dt1;
    }
    public string stafflog(string id, string pwd)
    {
        try
        {
            string str = "select PASSWORD from STAFFREGISTRATION where [ID NUMBER]='" + id + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            //con.Open();
            string pwd1 = cmd.ExecuteScalar().ToString();
            return pwd1;
        }
        catch (Exception e)
        {
            return "0";
        }
    }
    //STAFF LOGIN
    //ACCOUNTS LOGIN
 
    public DataTable accountsdetails(string id)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from STAFFREGISTRATION where [ID NUMBER]='" + id + "'", con);
        da.Fill(dt5);
        return dt5;
    }
    public string accountslog(string id, string pwd)
    {
        try
        {
            string str = "select PASSWORD from STAFFREGISTRATION where [ID NUMBER]='" + id + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            string pwd1 = cmd.ExecuteScalar().ToString();
            return pwd1;
        }
        catch (Exception e)
        {
            return "0";
        }
    }
    //ACCOUNTS LOGIN

    //ACCOUNT  NOTIFICATIONS
    public string NOTIFICATION(string notification)
    {
        try
        {
            string str = "insert into ACCOUNTNOTIFICATION(NOTIFICATION) values ('" + notification + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }
    //ACCOUNT NOTIFICATION


    //STAFF NOTIFICATIONS
    public string NOTIFICATION1(string notification)
    {
        try
        {
            string str = "insert into STAFFNOTIFICATION(NOTIFICATION) values ('" + notification + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }
    //STAFF NOTIFICATION

    //ADMIN NOTIFICATION
    public string NOTIFICATION2(string notification)
    {
        try
        {
            string str = "insert into ADMINNOTIFICATION(NOTIFICATION) values ('" + notification + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }
    //ADMIN NOTIFICATION
    
    //CERTIFICATE ISSUES

    //CERTIFICATE ISSUES



    ///FIRST YEAR SUBJECT WISE MARKS UPDATION
  /*  public DataTable getid(string dept)
    {
        SqlDataAdapter da = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + dept + "'",con);
        da.Fill(dt);
        return dt;
    }*/


    ///FIRST YEAR SUBJECT WISE MARKS UPDATION
    ///


    //CHANGE PASSWORD STAFF
    public string CHANGEPASSWORD(string id, string password, string reenterpassword)
    {
        try
        {
            string b="update STAFFREGISTRATION set PASSWORD='"+password+"',REENTERPASSWORD='"+reenterpassword+"' where [ID NUMBER]='" + id + "'";
            SqlCommand CMD = new SqlCommand(b, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }
    

    //CHANGE PASSWORD STAFF
    
    
    //CHANGE PASSWORD STUDENT

    public string CHANGEPASSWORD1(string id, string password, string reenterpassword)
    {
        try
        {
            string b = "update STUDENTREGISTRATION set PASSWORD='" + password + "',REENTERPASSWORD='" + reenterpassword + "' where [ID NUMBER]='" + id + "'";
            SqlCommand CMD = new SqlCommand(b, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }

    // CHANGE PASSWORD STUDENT

    //CHANGE PASSWORD ACCOUNTS
    public string CHANGEPASSWORD2(string id, string password, string reenterpassword)
    {
        try
        {
            string b = "update STAFFREGISTRATION set PASSWORD='" + password + "',REENTERPASSWORD='" + reenterpassword + "' where [ID NUMBER]='" + id + "'";
            SqlCommand CMD = new SqlCommand(b, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception ee)
        {
            return "0";
        }
    }

    //CHANGE PASSWORD ACCOUNTS

    //Update Fee details
    public string upfee(string amount,string ID)
    {
        try
        {
            string str = "update STUDENTREGISTRATION set AMOUNTPAID ='" + amount + "' where [ID NUMBER]='" + ID + "'";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            return "1";
        }
        catch (Exception e)
        {
            return "0";
        }
    }
}
