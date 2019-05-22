using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for connection
/// </summary>
public class connections
{
	SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\kalyanamsrikanthcnc@gmail.com\\Documents\\Visual Studio 2012\\WebSites\\temp\\sri.mdf';Integrated Security=True;Connect Timeout=30;");

    public connections()
	{
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\kalyanamsrikanthcnc@gmail.com\\Documents\\Visual Studio 2012\\WebSites\\temp\\sri.mdf';Integrated Security=True;Connect Timeout=30;");
    }
    
    public void connect()
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\kalyanamsrikanthcnc@gmail.com\\Documents\\Visual Studio 2012\\WebSites\\temp\\sri.mdf';Integrated Security=True;Connect Timeout=30;");
    }

    //REG table
    public string reg_action(string fname, string lname, string uname, string pass, string cpass, string mobile, string role, string email, string gender, string place)
    {
        {
            string str = "insert into reg([fname],[lname],[uname],[pass],[mobile],[role],[email],[gender],[place]) values('" + fname + "','"+lname+ "','"+uname+ "','"+pass+ "','"+mobile+ "','"+role+ "','"+email+ "','"+gender+ "','"+place+ "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
    }

    public string update_reg_action(string fname, string lname, string uname, string pass, string cpass, string mobile, string role, string email, string gender, string place)
    {
        {
            string upd = "update reg set fname='" + fname + "',lname='" + lname + "',uname='" + uname + "',pass='" + pass + "',mobile='" + mobile + "',role='" + role + "',email='" + email + "',gender='" + gender + "',place='" + place+ "' where uname='"+uname+ "'" ;
            SqlCommand CMD = new SqlCommand(upd, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
    }

    public string delete_reg_action(string uname)
    {
        {
            string upd = "delete from reg where uname='" + uname + "'";
            SqlCommand CMD = new SqlCommand(upd, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
    }


    public string view_reg_action(string fname, string lname, string uname, string pass, string cpass, string mobile, string role, string email, string gender, string place)
    {
        {
            string upd = "select * from reg where uname='" + uname + "'";
            SqlCommand CMD = new SqlCommand(upd, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
    }
    //TUITION table
    public string tution_in(string uname,string sem, string amount, string date, string du)
    {
        {
            string str = "insert into tution([uname],[sem],[amount],[date],[du]) values('"+uname+"','" + sem + "','" + amount + "','" + date + "','" + du + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
    }
    public string hostel_in(string uname,string sem, string hostel,string amount, string date, string du)
    {
        {
            string str = "insert into hostel([uname],[sem],[hostel],[amount],[date],[du]) values('"+uname+"','" + sem + "','" + hostel+ "','" + amount + "','" + date + "','" + du + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
    }


    public string logrole(string uname)
    {
        string str = "select role from reg where [uname]='" + uname + "'";
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        string pwd1 = cmd.ExecuteScalar().ToString();
        con.Close();
        return pwd1;    
    }
    //staff_tt
    public string staff_tt_action(string uname, string one, string two, string three, string four)
    {
        {
            string str = "insert into staff_tt([uname],[1st],[2nd],[3rd],[4th]) values('" + uname + "','" + one + "','" + two + "','" + three + "','" + four + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
    }

    public string staff_ps_action(string uname, string month, string gross, string cuts, string net)
    {
        {
            string str = "insert into staff_ps([uname],[month],[gross],[cuts],[net]) values('" + uname + "','" + month + "','" + gross + "','" + cuts + "','" + net + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
    }

    public string student_marks_action(string uname, string c1, string c2, string c3, string c4, string c5, string c6,string attendence)
    {
        {
            string str = "insert into student_marks([uname],[c1],[c2],[c3],[c4],[c5],[c6],[attendence]) values('" + uname + "','" + c1 + "','" + c2 + "','" + c3 + "','" + c4 + "','" + c5 + "','" + c6 + "','"+attendence+"')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }
 
    }

    public string student_sem_reg(string uname, string sem, string cgpa, string branch)
    {
        {
            string str = "insert into student_sem_reg([uname],[sem],[cgpa],[branch]) values('" + uname + "','" + sem + "','" + cgpa + "','" + branch + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }

    }

    public string login(string uname, string pass)
    {
        string str = "select pass from reg where [uname]='" + uname + "'";
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        string pwd1 = cmd.ExecuteScalar().ToString();
        con.Close();
        return pwd1;
    }

    public string place(string uname, string cgpa, string comp, string link)
    {
        {
            string str = "insert into Place([uname],[cgpa],[comp],[link]) values('" + uname + "','" + cgpa + "','" + comp + "','" + link + "')";
            SqlCommand CMD = new SqlCommand(str, con);
            con.Open();
            CMD.ExecuteNonQuery().ToString();
            con.Close();
            return "1";
        }

    }
}