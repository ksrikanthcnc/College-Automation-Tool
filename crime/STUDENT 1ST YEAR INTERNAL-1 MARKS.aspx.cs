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

public partial class STUDENT_1ST_YEAR_INTERNAL_1_MARKS : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=LAHARI-FA7430FA; Initial catalog=CollegeAutomationTool;Integrated Security=true;");
    connections cn = new connections();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {


            string srn, sn, ss11, st1;
            int n, coun = 0, m;
            sn = "select count ([ID NUMBER]) from FSTYEARSTUDENTEXAMINATIONDETAILS";
            SqlCommand cmd = new SqlCommand(sn, con);
            con.Open();
            n = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            if (n == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION ", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "STUDENTREGISTRATION");
                int a = ds.Tables[0].Rows.Count;
                string[] b = new string[10000];
                for (int i = 0; i < a; i++)
                {
                    b[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string id = b[i].ToString();
                    string str12 = "insert into FSTYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id + "')";
                    SqlCommand cmd12 = new SqlCommand(str12, con);
                    con.Open();
                    //cmd12.ExecuteScalar().ToString();
                    cmd12.ExecuteNonQuery().ToString();
                    con.Close();
                }
            }
            //2-1
            /*string srn11, sn11, ss1111, st111;
            int n11, coun11 = 0, m11;
            sn11 = "select count ([ID NUMBER]) from TWOONEYEARSTUDENTEXAMINATIONDETAILS";
            SqlCommand cmd11 = new SqlCommand(sn11, con);
            con.Open();
            n11 = int.Parse(cmd11.ExecuteScalar().ToString());
            con.Close();
            if (n11 == 0)
            {

                SqlDataAdapter da11 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION ", con);
                DataSet ds11 = new DataSet();
                da11.Fill(ds11, "STUDENTREGISTRATION");
                int a11 = ds11.Tables[0].Rows.Count;
                string[] b11 = new string[10000];
                for (int i = 0; i < a11; i++)
                {

                    b11[i] = ds11.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x1 = b11[i];
                    //int m11 = int.Parse(x);
                    string str121 = x1.Substring(0, 2);
                    int m111 = int.Parse(str121);

                    DateTime dt111 = DateTime.Now;
                    string d111 = dt111.ToString("yy");
                    int m121 = int.Parse(d111);
                    int diff11 = m121 - m111;
                    string si1 = diff11.ToString();
                    if (si1 == "1")
                    {



                        // b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                        string id11 = b11[i].ToString();
                        string str1211 = "insert into TWOONEYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id11 + "')";
                        SqlCommand cmd1211 = new SqlCommand(str1211, con);
                        con.Open();
                        //cmd12.ExecuteScalar().ToString();
                        cmd1211.ExecuteNonQuery().ToString();
                        con.Close();
                    }
                    if (si1 == "2")
                    {
                        string id11 = b11[i].ToString();
                        string str1211 = "insert into TWOONEYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id11 + "')";
                        SqlCommand cmd1211 = new SqlCommand(str1211, con);
                        con.Open();
                        //cmd12.ExecuteScalar().ToString();
                        cmd1211.ExecuteNonQuery().ToString();
                        con.Close();
                    }
                }


                //2-1
                //2-2
                string srn1, sn1, ss111, st11;
                int n1, coun1 = 0, m1;
                sn1 = "select count ([ID NUMBER]) from TWOTWOYEARSTUDENTEXAMINATIONDETAILS";
                SqlCommand cmd1 = new SqlCommand(sn1, con);
                con.Open();
                n1 = int.Parse(cmd1.ExecuteScalar().ToString());
                con.Close();
                if (n1 == 0)
                {



                    SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION ", con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "STUDENTREGISTRATION");
                    int a1 = ds1.Tables[0].Rows.Count;
                    string[] b1 = new string[10000];
                    for (int i = 0; i < a1; i++)
                    {

                        b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                        string x = b1[i];
                        //int m11 = int.Parse(x);
                        string str12 = x.Substring(0, 2);
                        int m12 = int.Parse(str12);

                        DateTime dt11 = DateTime.Now;
                        string d11 = dt11.ToString("yy");
                        int p1 = int.Parse(d11);
                        int diff1 = m12 - p1;
                        string si = diff1.ToString();
                        if (si == "1")
                        {



                            // b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                            string id1 = b1[i].ToString();
                            string str121 = "insert into TWOTWOYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id1 + "')";
                            SqlCommand cmd121 = new SqlCommand(str121, con);
                            con.Open();
                            //cmd12.ExecuteScalar().ToString();
                            cmd121.ExecuteNonQuery().ToString();
                            con.Close();
                        }
                        if (si == "2")
                        {
                            string id1 = b1[i].ToString();
                            string str121 = "insert into TWOTWOYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id1 + "')";
                            SqlCommand cmd121 = new SqlCommand(str121, con);
                            con.Open();
                            //cmd12.ExecuteScalar().ToString();
                            cmd121.ExecuteNonQuery().ToString();
                            con.Close();
                        }
                    }


                    //2-2

                    //3-1

                    string srn111, sn111, ss11111, st1111;
                    int n111, coun111 = 0, m111;
                    sn111 = "select count ([ID NUMBER]) from THREEONEYEARSTUDENTEXAMINATIONDETAILS";
                    SqlCommand cmd111 = new SqlCommand(sn111, con);
                    con.Open();
                    n111 = int.Parse(cmd111.ExecuteScalar().ToString());
                    con.Close();
                    if (n111 == 0)
                    {
                        SqlDataAdapter da111 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION ", con);
                        DataSet ds111 = new DataSet();
                        da111.Fill(ds111, "STUDENTREGISTRATION");
                        int a111 = ds111.Tables[0].Rows.Count;
                        string[] b111 = new string[10000];
                        for (int i = 0; i < a111; i++)
                        {

                            b111[i] = ds111.Tables[0].Rows[i].ItemArray[0].ToString();
                            string x11 = b111[i];
                            //int m11 = int.Parse(x);
                            string str1211 = x11.Substring(0, 2);
                            int m1111 = int.Parse(str1211);

                            DateTime dt1111 = DateTime.Now;
                            string d1111 = dt1111.ToString("yy");
                            int m1211 = int.Parse(d1111);
                            int diff111 = m1211 - m1111;
                            string si11 = diff111.ToString();
                            if (si11 == "1")
                            {



                                // b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                                string id111 = b111[i].ToString();
                                string str12111 = "insert into THREEONEYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id111 + "')";
                                SqlCommand cmd12111 = new SqlCommand(str12111, con);
                                con.Open();
                                //cmd12.ExecuteScalar().ToString();
                                cmd12111.ExecuteNonQuery().ToString();
                                con.Close();
                            }
                            if (si11 == "2")
                            {
                                string id111 = b111[i].ToString();
                                string str12111 = "insert into THREEONEYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id111 + "')";
                                SqlCommand cmd12111 = new SqlCommand(str12111, con);
                                con.Open();
                                //cmd12.ExecuteScalar().ToString();
                                cmd12111.ExecuteNonQuery().ToString();
                                con.Close();
                            }
                        }



                        //3-1*/
                        
          

        }
        else
        {
        //                //string id1,id2;
                        ////con.Open();
                        //SqlDataAdapter da = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION ", con);
                        //DataSet ds = new DataSet();
                        //da.Fill(ds, "STUDENTREGISTRATION");
                        //int a = ds.Tables[0].Rows.Count;
                        //string[] b = new string[10000];
                        //for (int i = 0; i < a; i++)
                        //{
                        //    b[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        //    id1 = b[i].ToString();
                        //    string sp = "SELECT [ID NUMBER] FROM FSTYEARSTUDENTEXAMINATIONDETAILS WHERE [ID NUMBER]='" + id1 + "'";
                        //    SqlCommand cmdq = new SqlCommand(sp, con);
                        //    con.Open();
                        //    id2 = cmdq.ExecuteScalar().ToString();
                        //    if (id2 == id1)
                        //    {

                        //    }
                        //    else
                        //    {
                        //        string st12 = "insert into FSTYEARSTUDENTEXAMINATIONDETAILS ([ID NUMBER]) values ('" + id1 + "')";
                        //        SqlCommand cmd32 = new SqlCommand(st12, con);
                        //        cmd32.ExecuteNonQuery().ToString();
                        //    }
                        //    /*SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from FSTYEARSTUDENTEXAMINATIONDETAILS", con);
                        //    DataSet ds1 = new DataSet();
                        //    da1.Fill(ds1, "FSTYEARSTUDENTEXAMINATIONDETAILS");
                        //    int a1 = ds.Tables[0].Rows.Count;
                        //    string[] b2=new string[10000];
                        //    for (int i1 = 0; i1 < a1; i1++)
                        //    {
                        //        b2[i1] = ds.Tables[0].Rows[i1].ItemArray[0].ToString();
                        //        //id2=DropDownList1.Items.Add(b2[
                        //        id2 = b2[i1].ToString();
                        //        if (id1 == id2)
                        //        {
                        //            //break;
                        //        }
                        //        else
                        //        {
                        //            //string id3;
                        //            //SqlDataAdapter da3 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION ", con);
                        //            //DataSet ds3 = new DataSet();
                        //            //da3.Fill(ds3, "STUDENTREGISTRATION");
                        //            //int a3 = ds3.Tables[0].Rows.Count;
                        //            //string[] b3 = new string[10000];
                        //            //for (int i3 = 0; i3 < a3; i++)
                        //            //{
                        //            //    b3[i3] = ds3.Tables[0].Rows[i3].ItemArray[0].ToString();
                        //            //    id3 = b3[i3].ToString();

                        //            //    if (id2 == id3)
                        //            //    {

                        //            //    }
                        //            //    else
                        //                {
                        //                    string st12 = "insert into FSTYEARSTUDENTEXAMINATIONDETAILS ([ID NUMBER]) values ('" + id3 + "')";
                        //                    SqlCommand cmd32 = new SqlCommand(st12, con);
                        //                    cmd32.ExecuteNonQuery().ToString();
                        //                }
                        //            //}
                        //        }
                        //    }*/

                        //    //string str12 = "insert into FSTYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id + "')";
                        //    //SqlCommand cmd12 = new SqlCommand(str12, con);
                        //    //con.Open();
                        //    //cmd12.ExecuteScalar().ToString();
                        //    //cmd12.ExecuteNonQuery().ToString();


                        //    con.Close();


                        //    //string v = "select [ID NUMBER] from FSTYEARSTUDENTEXAMINATIONDETAILS where [ID NUMBER]='" + id1 + "'";
                        //    //SqlCommand cmd2 = new SqlCommand(v, con);
                        //    //SqlDataReader dr;
                        //    //con.Open();
                        //    //dr = cmd2.ExecuteReader();
                        //    ////con.Close();
                        //    //if (dr.HasRows)
                        //    //{

                        //    //}
                        //    //    //con.Close();
                        //    //else
                        //    //{
                        //    //    con.Close();
                        //    //    string st = "insert into FSTYEARSTUDENTEXAMINATIONDETAILS([ID NUMBER]) values ('" + id1 + "')";
                        //    //    SqlCommand cmd3 = new SqlCommand(st, con);
                        //    //    con.Open();
                        //    //    cmd3.ExecuteNonQuery().ToString();
                        //    //    //MessageBox.Show("INSERTED");
                        //    //    con.Close();
                        //    //}
       //}

                    //string v = "select";
                    //SqlCommand cmd=
                    //    SqlDataReader dr;
                    //dr=cmd.ExecuteReader();
                    //if(dr.HAS
                    //    while(DR.rEAD()
        }


                pnlfirstyr.Visible = false;

                //plnfirstsub.Visible = false;
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                

            

    }
    protected void btnsbmt_Click(object sender, EventArgs e)
    {
        cn.connect();
        if (ddldept.SelectedItem.Text == "--SELECT--")
        {
            MessageBox.Show("Select Department");
        }
        else if (ddlyear.SelectedItem.Text == "--SELECT--")
        {
            MessageBox.Show("Select Year");
        }



        else if (ddldept.SelectedItem.Text == "CSE")
        {
            if (ddlyear.SelectedItem.Text == "Ist Year")
            {
                ddl1yrsub.Visible = true;
                //dt = cn.getid(ddldept.SelectedItem.Text);
                SqlDataAdapter da = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "STUDENTREGISTRATION");
                int a = ds.Tables[0].Rows.Count;


                string[] b = new string[10000];
                for (int i = 0; i < a; i++)
                {
                    b[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b[i];
                    string str = x.Substring(0, 2);
                    int m = int.Parse(str);
                    DateTime dt = DateTime.Now;
                    string d = dt.ToString("yy");
                    int m1 = int.Parse(d);
                    int diff = m1 - m;
                    if (diff <= 0)
                    {

                        if (i == 0)
                        {
                            txtidno0.Text = x;
                        }
                        else if (i == 1)
                        {
                            txtidno1.Text = x;
                        }
                        else if (i == 2)
                        {
                            txtidno2.Text = x;

                        }
                        else if (i == 3)
                        {
                            txtidno3.Text = x;
                        }
                        else if (i == 4)
                        {
                            txtidno4.Text = x;
                        }
                        else if (i == 5)
                        {
                            txtidno5.Text = x;
                        }
                        else if (i == 6)
                        {
                            txtidno6.Text = x;
                        }
                        else if (i == 7)
                        {
                            txtidno7.Text = x;
                        }
                        else if (i == 8)
                        {
                            txtidno8.Text = x;
                        }
                        else if (i == 9)
                        {
                            txtidno9.Text = x;
                        }
                        else if (i == 10)
                        {
                            txtidno10.Text = x;
                        }
                        else if (i == 11)
                        {
                            txtidno11.Text = x;
                        }
                        else if (i == 12)
                        {
                            txtidno12.Text = x;
                        }
                        else if (i == 13)
                        {
                            txtidno13.Text = x;
                        }
                        else if (i == 14)
                        {
                            txtidno14.Text = x;
                        }
                        else if (i == 15)
                        {
                            txtidno15.Text = x;
                        }
                        else if (i == 16)
                        {
                            txtidno16.Text = x;
                        }
                        else if (i == 17)
                        {
                            txtidno17.Text = x;
                        }
                        else if (i == 18)
                        {
                            txtidno18.Text = x;
                        }
                        else if (i == 19)
                        {
                            txtidno19.Text = x;
                        }
                        else if (i == 20)
                        {
                            txtidno20.Text = x;
                        }
                        else if (i == 21)
                        {
                            txtidno21.Text = x;
                        }
                        else if (i == 22)
                        {
                            txtidno22.Text = x;
                        }
                        else if (i == 23)
                        {
                            txtidno23.Text = x;
                        }
                        else if (i == 24)
                        {
                            txtidno24.Text = x;
                        }
                        else if (i == 25)
                        {
                            txtidno25.Text = x;
                        }
                        else if (i == 26)
                        {
                            txtidno26.Text = x;
                        }
                        else if (i == 27)
                        {
                            txtidno27.Text = x;
                        }
                        else if (i == 28)
                        {
                            txtidno28.Text = x;
                        }
                        else if (i == 29)
                        {
                            txtidno29.Text = x;
                        }
                        else if (i == 30)
                        {
                            txtidno30.Text = x;
                        }


                    }
                    else if (diff == 1)
                    {
                        string month = dt.ToString("MM");
                        int mon = int.Parse(month);
                        int x1 = mon - 1;
                        if (x1 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = x;
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = x;
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = x;

                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = x;
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = x;
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = x;
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = x;
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = x;
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = x;
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = x;
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = x;
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = x;
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = x;
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = x;
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = x;
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = x;
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = x;
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = x;
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = x;
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = x;
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = x;
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = x;
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = x;
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = x;
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = x;
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = x;
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = x;
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = x;
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = x;
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = x;
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = x;
                            }

                        }
                    }

                    //int m = int.Parse(b[i]);
                }
                //plnfirstsub.Visible = true;
                //pnlcse.Visible = false;
                //pnlece.Visible = false;
                //pnlit.Visible = false;

                pnlfirstyr.Visible = true;
                //pnlfirstyr.Visible = true;
                pnl1yr.Visible = true;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

            }
            else if (ddlyear.SelectedItem.Text == "2 - 1")
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 1)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            pnl22cse.Visible = true;
                            //pnlfirstyr.Visible = true;
                            //pnl1yr.Visible = true;
                            //pnlcse.Visible = true;
                            //ddl21csesub.Visible = true;
                            // ddl22csesub.Visible = false;
                            // ddl31csesub.Visible = false;
                            // ddl32csesub.Visible = false;
                            // ddl41csesub.Visible = false;
                            // ddl42csesub.Visible = false;
                        }
                    }
                    else if (diff1 == 2)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                                //string anusha = "insert into TWOTWOYEARSTUDENTATTENDENCE ([ID NUMBER]) values ('" + b1[i].ToString() + "')";

                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                        }
                        //pnlfirstyr.Visible = true;
                    }
                }

                pnl1yr.Visible = false;
                pnl21cse.Visible = true;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;

                //string[] b = new string[10000];

                pnlfirstyr.Visible = true;
            }
            else if (ddlyear.SelectedItem.Text == "2 - 2")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds11 = new DataSet();
                da1.Fill(ds11, "STUDENTREGISTRATION");
                int a11 = ds11.Tables[0].Rows.Count;
                string[] b11 = new string[10000];
                for (int i = 0; i < a11; i++)
                {
                    b11[i] = ds11.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b11[i];
                    //int m111= int.Parse(x);
                    string str121 = x.Substring(0, 2);
                    int m111 = int.Parse(str121);

                    DateTime dt111 = DateTime.Now;
                    string d111 = dt111.ToString("yy");
                    int m121 = int.Parse(d111);
                    int diff11 = m121 - m111;
                    if (diff11 == 1)
                    {
                        DateTime dtx = DateTime.Now;
                        string month11 = dtx.ToString("MM");
                        int mon21 = int.Parse(month11);
                        int x21 = mon21 - 1;
                        if (x21 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b11[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b11[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b11[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b11[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b11[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b11[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b11[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b11[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b11[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b11[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b11[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b11[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b11[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b11[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b11[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b11[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b11[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b11[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b11[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b11[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b11[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b11[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b11[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b11[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b11[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b11[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b11[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b11[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b11[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b11[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b11[i];
                            }


                            //pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff11 == 2)
                    {
                        DateTime dtx11 = DateTime.Now;
                        string month21 = dtx11.ToString("MM");
                        int x31 = int.Parse(month21);
                        int x41 = x31 - 1;
                        if (x41 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b11[i];
                                //txtidno0.Text = b11[i] ;
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b11[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b11[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b11[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b11[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b11[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b11[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b11[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b11[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b11[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b11[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b11[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b11[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b11[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b11[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b11[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b11[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b11[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b11[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b11[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b11[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b11[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b11[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b11[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b11[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b11[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b11[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b11[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b11[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b11[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b11[i];
                            }



                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = true;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;
            }
            else if (ddlyear.SelectedItem.Text == "3 - 1")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 2)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 3)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            pnl31cse.Visible = true;
                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = true;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;
            }
            else if (ddlyear.SelectedItem.Text == "3 - 2")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 2)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 3)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = true;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;
            }
            else if (ddlyear.SelectedItem.Text == "4 - 1")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 3)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 4)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }




                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = true;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;
            }
            else if (ddlyear.SelectedItem.Text == "4 - 2")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 3)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 4)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }




                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = true;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;
            }

        }
        else if (ddldept.SelectedItem.Text == "ECE")
        {
            if (ddlyear.SelectedItem.Text == "Ist Year")
            {
                //dt = cn.getid(ddldept.SelectedItem.Text);
                SqlDataAdapter da = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "STUDENTREGISTRATION");
                int a = ds.Tables[0].Rows.Count;


                string[] b = new string[10000];
                for (int i = 0; i < a; i++)
                {
                    b[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b[i];
                    string str = x.Substring(0, 2);
                    int m = int.Parse(str);
                    DateTime dt = DateTime.Now;
                    string d = dt.ToString("yy");
                    int m1 = int.Parse(d);
                    int diff = m1 - m;
                    if (diff <= 0)
                    {

                        if (i == 0)
                        {
                            txtidno0.Text = x;
                        }
                        else if (i == 1)
                        {
                            txtidno1.Text = x;
                        }
                        else if (i == 2)
                        {
                            txtidno2.Text = x;

                        }
                        else if (i == 3)
                        {
                            txtidno3.Text = x;
                        }
                        else if (i == 4)
                        {
                            txtidno4.Text = x;
                        }
                        else if (i == 5)
                        {
                            txtidno5.Text = x;
                        }
                        else if (i == 6)
                        {
                            txtidno6.Text = x;
                        }
                        else if (i == 7)
                        {
                            txtidno7.Text = x;
                        }
                        else if (i == 8)
                        {
                            txtidno8.Text = x;
                        }
                        else if (i == 9)
                        {
                            txtidno9.Text = x;
                        }
                        else if (i == 10)
                        {
                            txtidno10.Text = x;
                        }
                        else if (i == 11)
                        {
                            txtidno11.Text = x;
                        }
                        else if (i == 12)
                        {
                            txtidno12.Text = x;
                        }
                        else if (i == 13)
                        {
                            txtidno13.Text = x;
                        }
                        else if (i == 14)
                        {
                            txtidno14.Text = x;
                        }
                        else if (i == 15)
                        {
                            txtidno15.Text = x;
                        }
                        else if (i == 16)
                        {
                            txtidno16.Text = x;
                        }
                        else if (i == 17)
                        {
                            txtidno17.Text = x;
                        }
                        else if (i == 18)
                        {
                            txtidno18.Text = x;
                        }
                        else if (i == 19)
                        {
                            txtidno19.Text = x;
                        }
                        else if (i == 20)
                        {
                            txtidno20.Text = x;
                        }
                        else if (i == 21)
                        {
                            txtidno21.Text = x;
                        }
                        else if (i == 22)
                        {
                            txtidno22.Text = x;
                        }
                        else if (i == 23)
                        {
                            txtidno23.Text = x;
                        }
                        else if (i == 24)
                        {
                            txtidno24.Text = x;
                        }
                        else if (i == 25)
                        {
                            txtidno25.Text = x;
                        }
                        else if (i == 26)
                        {
                            txtidno26.Text = x;
                        }
                        else if (i == 27)
                        {
                            txtidno27.Text = x;
                        }
                        else if (i == 28)
                        {
                            txtidno28.Text = x;
                        }
                        else if (i == 29)
                        {
                            txtidno29.Text = x;
                        }
                        else if (i == 30)
                        {
                            txtidno30.Text = x;
                        }

                    }
                    else if (diff == 1)
                    {
                        string month = dt.ToString("MM");
                        int mon = int.Parse(month);
                        int x1 = mon - 1;
                        if (x1 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = x;
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = x;
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = x;

                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = x;
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = x;
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = x;
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = x;
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = x;
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = x;
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = x;
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = x;
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = x;
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = x;
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = x;
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = x;
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = x;
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = x;
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = x;
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = x;
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = x;
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = x;
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = x;
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = x;
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = x;
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = x;
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = x;
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = x;
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = x;
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = x;
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = x;
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = x;
                            }

                        }
                    }

                    //int m = int.Parse(b[i]);
                }
                pnl1yr.Visible = true;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;


            }
            else if (ddlyear.SelectedItem.Text == "2 - 1")
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 1)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            //pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 2)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            //pnlfirstyr.Visible = true;
                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = true;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

                //string[] b = new string[10000];


            }
            else if (ddlyear.SelectedItem.Text == "2 - 2")
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 1)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 2)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            //pnlfirstyr.Visible = true;
                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = true;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

            }
            else if (ddlyear.SelectedItem.Text == "3 - 1")
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 2)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            //pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 3)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            //pnlfirstyr.Visible = true;
                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = true;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;


            }
            else if (ddlyear.SelectedItem.Text == "3 - 2")
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 2)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            //pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 3)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            //pnlfirstyr.Visible = true;
                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = true;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;



            }
            else if (ddlyear.SelectedItem.Text == "4 - 1")
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 3)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 4)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            //pnlfirstyr.Visible = true;
                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = true;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;


            }
            else if (ddlyear.SelectedItem.Text == "4 - 2")
            {

                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 3)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            //pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 4)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            // pnlfirstyr.Visible = true;
                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = true;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

            }
        }

        //IT
        else if (ddldept.SelectedItem.Text == "IT")
        {
            if (ddlyear.SelectedItem.Text == "Ist Year")
            {
                //dt = cn.getid(ddldept.SelectedItem.Text);
                SqlDataAdapter da = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "STUDENTREGISTRATION");
                int a = ds.Tables[0].Rows.Count;


                string[] b = new string[10000];
                for (int i = 0; i < a; i++)
                {
                    b[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b[i];
                    string str = x.Substring(0, 2);
                    int m = int.Parse(str);
                    DateTime dt = DateTime.Now;
                    string d = dt.ToString("yy");
                    int m1 = int.Parse(d);
                    int diff = m1 - m;
                    if (diff <= 0)
                    {

                        if (i == 0)
                        {
                            txtidno0.Text = x;
                        }
                        else if (i == 1)
                        {
                            txtidno1.Text = x;
                        }
                        else if (i == 2)
                        {
                            txtidno2.Text = x;

                        }
                        else if (i == 3)
                        {
                            txtidno3.Text = x;
                        }
                        else if (i == 4)
                        {
                            txtidno4.Text = x;
                        }
                        else if (i == 5)
                        {
                            txtidno5.Text = x;
                        }
                        else if (i == 6)
                        {
                            txtidno6.Text = x;
                        }
                        else if (i == 7)
                        {
                            txtidno7.Text = x;
                        }
                        else if (i == 8)
                        {
                            txtidno8.Text = x;
                        }
                        else if (i == 9)
                        {
                            txtidno9.Text = x;
                        }
                        else if (i == 10)
                        {
                            txtidno10.Text = x;
                        }
                        else if (i == 11)
                        {
                            txtidno11.Text = x;
                        }
                        else if (i == 12)
                        {
                            txtidno12.Text = x;
                        }
                        else if (i == 13)
                        {
                            txtidno13.Text = x;
                        }
                        else if (i == 14)
                        {
                            txtidno14.Text = x;
                        }
                        else if (i == 15)
                        {
                            txtidno15.Text = x;
                        }
                        else if (i == 16)
                        {
                            txtidno16.Text = x;
                        }
                        else if (i == 17)
                        {
                            txtidno17.Text = x;
                        }
                        else if (i == 18)
                        {
                            txtidno18.Text = x;
                        }
                        else if (i == 19)
                        {
                            txtidno19.Text = x;
                        }
                        else if (i == 20)
                        {
                            txtidno20.Text = x;
                        }
                        else if (i == 21)
                        {
                            txtidno21.Text = x;
                        }
                        else if (i == 22)
                        {
                            txtidno22.Text = x;
                        }
                        else if (i == 23)
                        {
                            txtidno23.Text = x;
                        }
                        else if (i == 24)
                        {
                            txtidno24.Text = x;
                        }
                        else if (i == 25)
                        {
                            txtidno25.Text = x;
                        }
                        else if (i == 26)
                        {
                            txtidno26.Text = x;
                        }
                        else if (i == 27)
                        {
                            txtidno27.Text = x;
                        }
                        else if (i == 28)
                        {
                            txtidno28.Text = x;
                        }
                        else if (i == 29)
                        {
                            txtidno29.Text = x;
                        }
                        else if (i == 30)
                        {
                            txtidno30.Text = x;
                        }

                    }
                    else if (diff == 1)
                    {
                        string month = dt.ToString("MM");
                        int mon = int.Parse(month);
                        int x1 = mon - 1;
                        if (x1 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = x;
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = x;
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = x;

                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = x;
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = x;
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = x;
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = x;
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = x;
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = x;
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = x;
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = x;
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = x;
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = x;
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = x;
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = x;
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = x;
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = x;
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = x;
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = x;
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = x;
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = x;
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = x;
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = x;
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = x;
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = x;
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = x;
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = x;
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = x;
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = x;
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = x;
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = x;
                            }

                        }
                    }

                    //int m = int.Parse(b[i]);
                }
                pnl1yr.Visible = true;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

            }
            else if (ddlyear.SelectedItem.Text == "2 - 1")
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 1)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 2)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            // pnlfirstyr.Visible = true;
                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = true; ;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;


                //string[] b = new string[10000];


            }
            else if (ddlyear.SelectedItem.Text == "2 - 2")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds11 = new DataSet();
                da1.Fill(ds11, "STUDENTREGISTRATION");
                int a11 = ds11.Tables[0].Rows.Count;
                string[] b11 = new string[10000];
                for (int i = 0; i < a11; i++)
                {
                    b11[i] = ds11.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b11[i];
                    //int m111= int.Parse(x);
                    string str121 = x.Substring(0, 2);
                    int m111 = int.Parse(str121);

                    DateTime dt111 = DateTime.Now;
                    string d111 = dt111.ToString("yy");
                    int m121 = int.Parse(d111);
                    int diff11 = m121 - m111;
                    if (diff11 == 1)
                    {
                        DateTime dtx = DateTime.Now;
                        string month11 = dtx.ToString("MM");
                        int mon21 = int.Parse(month11);
                        int x21 = mon21 - 1;
                        if (x21 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b11[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b11[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b11[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b11[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b11[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b11[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b11[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b11[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b11[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b11[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b11[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b11[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b11[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b11[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b11[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b11[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b11[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b11[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b11[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b11[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b11[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b11[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b11[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b11[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b11[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b11[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b11[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b11[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b11[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b11[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b11[i];
                            }


                            //pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff11 == 2)
                    {
                        DateTime dtx11 = DateTime.Now;
                        string month21 = dtx11.ToString("MM");
                        int x31 = int.Parse(month21);
                        int x41 = x31 - 1;
                        if (x41 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b11[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b11[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b11[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b11[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b11[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b11[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b11[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b11[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b11[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b11[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b11[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b11[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b11[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b11[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b11[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b11[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b11[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b11[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b11[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b11[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b11[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b11[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b11[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b11[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b11[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b11[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b11[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b11[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b11[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b11[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b11[i];
                            }

                            //pnlfirstyr.Visible = true;
                            //pnlfirstyr.Visible = false;

                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = true;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

            }
            else if (ddlyear.SelectedItem.Text == "3 - 1")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 2)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            //pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 3)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }




                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = true;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

            }
            else if (ddlyear.SelectedItem.Text == "3 - 2")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 2)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }

                            //pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 3)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }




                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = true;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

            }
            else if (ddlyear.SelectedItem.Text == "4 - 1")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 3)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 4)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = true;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = false;
                pnlfirstyr.Visible = true;

            }
            else if (ddlyear.SelectedItem.Text == "4 - 2")
            {
                //pnlfirstyr.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select [ID NUMBER] from STUDENTREGISTRATION where DEPARTMENT='" + ddldept.SelectedItem.Text + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "STUDENTREGISTRATION");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[10000];
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    string x = b1[i];
                    //int m11 = int.Parse(x);
                    string str12 = x.Substring(0, 2);
                    int m11 = int.Parse(str12);

                    DateTime dt11 = DateTime.Now;
                    string d11 = dt11.ToString("yy");
                    int m12 = int.Parse(d11);
                    int diff1 = m12 - m11;
                    if (diff1 == 3)
                    {
                        DateTime dtx = DateTime.Now;
                        string month1 = dtx.ToString("MM");
                        int mon2 = int.Parse(month1);
                        int x2 = mon2 - 1;
                        if (x2 > 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }


                            // pnlfirstyr.Visible = true;
                        }
                    }
                    else if (diff1 == 4)
                    {
                        DateTime dtx1 = DateTime.Now;
                        string month2 = dtx1.ToString("MM");
                        int x3 = int.Parse(month2);
                        int x4 = x3 - 1;
                        if (x4 <= 7)
                        {
                            if (i == 0)
                            {
                                txtidno0.Text = b1[i];
                            }
                            else if (i == 1)
                            {
                                txtidno1.Text = b1[i];
                            }
                            else if (i == 2)
                            {
                                txtidno2.Text = b1[i];
                            }
                            else if (i == 3)
                            {
                                txtidno3.Text = b1[i];
                            }
                            else if (i == 4)
                            {
                                txtidno4.Text = b1[i];
                            }
                            else if (i == 5)
                            {
                                txtidno5.Text = b1[i];
                            }
                            else if (i == 6)
                            {
                                txtidno6.Text = b1[i];
                            }
                            else if (i == 7)
                            {
                                txtidno7.Text = b1[i];
                            }
                            else if (i == 8)
                            {
                                txtidno8.Text = b1[i];
                            }
                            else if (i == 9)
                            {
                                txtidno9.Text = b1[i];
                            }
                            else if (i == 10)
                            {
                                txtidno10.Text = b1[i];
                            }
                            else if (i == 11)
                            {
                                txtidno11.Text = b1[i];
                            }
                            else if (i == 12)
                            {
                                txtidno12.Text = b1[i];
                            }
                            else if (i == 13)
                            {
                                txtidno13.Text = b1[i];
                            }
                            else if (i == 14)
                            {
                                txtidno14.Text = b1[i];
                            }
                            else if (i == 15)
                            {
                                txtidno15.Text = b1[i];
                            }
                            else if (i == 16)
                            {
                                txtidno16.Text = b1[i];
                            }
                            else if (i == 17)
                            {
                                txtidno17.Text = b1[i];
                            }
                            else if (i == 18)
                            {
                                txtidno18.Text = b1[i];
                            }
                            else if (i == 19)
                            {
                                txtidno19.Text = b1[i];
                            }
                            else if (i == 20)
                            {
                                txtidno20.Text = b1[i];
                            }
                            else if (i == 21)
                            {
                                txtidno21.Text = b1[i];
                            }
                            else if (i == 22)
                            {
                                txtidno22.Text = b1[i];
                            }
                            else if (i == 23)
                            {
                                txtidno23.Text = b1[i];
                            }
                            else if (i == 24)
                            {
                                txtidno24.Text = b1[i];
                            }
                            else if (i == 25)
                            {
                                txtidno25.Text = b1[i];
                            }
                            else if (i == 26)
                            {
                                txtidno26.Text = b1[i];
                            }
                            else if (i == 27)
                            {
                                txtidno27.Text = b1[i];
                            }
                            else if (i == 28)
                            {
                                txtidno28.Text = b1[i];
                            }
                            else if (i == 29)
                            {
                                txtidno29.Text = b1[i];
                            }
                            else if (i == 30)
                            {
                                txtidno30.Text = b1[i];
                            }



                        }
                    }
                }
                pnl1yr.Visible = false;
                pnl21cse.Visible = false;
                pnl21ece.Visible = false;
                pnl21it.Visible = false;
                pnl22cse.Visible = false;
                pnl22ece.Visible = false;
                pnl22it.Visible = false;
                pnl31cse.Visible = false;
                pnl31ece.Visible = false;
                pnl31it.Visible = false;
                pnl32cse.Visible = false;
                pnl32ece.Visible = false;
                pnl32it.Visible = false;
                pnl41cse.Visible = false;
                pnl41ece.Visible = false;
                pnl41it.Visible = false;
                pnl42cse.Visible = false;
                pnl42ece.Visible = false;
                pnl42it.Visible = true;
                pnlfirstyr.Visible = true;

            }
        }
       

    }


    //protected void Button1_Click(object sender, EventArgs e)
    //{

    //}
    //protected void Button1_Click(object sender, EventArgs e)
    //{

    //}
     protected void Button1_Click(object sender, EventArgs e)
    {
        if (ddldept.SelectedItem.Text == "--SELECT--")
        {
            MessageBox.Show("Select DEPARTMENT");
        }
        if (ddlyear.SelectedItem.Text == "--SELECT--")
        {
            MessageBox.Show("Select Year/Semester");
        }
        if (ddlyear.SelectedItem.Text == "Ist Year")
        {
            string stid,id, name, internal1theory, internal1objective, internal1assignment, internal2theory, internal2objective, internal2assignment, internal3theory, internal3objective, internal3assignment, external, labinternal1, labinternal2, labexternal;
            for (int i = 0; i <= 50; i++)
            {
                if (ddl1yrsub.SelectedItem.Text == "ENGLISH")
                {
                 
                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                   
                }

                else if (ddl1yrsub.SelectedItem.Text == "C- LANGUAGE")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;
		string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT2='" + ddl1yrsub.SelectedItem.Text + "',[SUB2 THEORY1]='" + internal1theory + "',[SUB2 OBJECTIVE1]='" + internal1objective + "',[SUB2 ASSIGNMENT1]='" + internal1assignment + "',[SUB2 THEORY2]='" + internal2theory + "',[SUB2 OBJECTIVE2]='" + internal2objective + "',[SUB2 ASSIGNMENT2]='" + internal2assignment + "',[SUB2 THEORY3]='" + internal3theory + "',[SUB2 OBJECTIVE3]='" + internal3objective + "',[SUB2 ASSIGNMENT3]='" + internal3assignment + "',[SUB2 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                  
                }

                else if (ddl1yrsub.SelectedItem.Text == "EP")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT3='" + ddl1yrsub.SelectedItem.Text + "',[SUB3 THEORY1]='" + internal1theory + "',[SUB3 OBJECTIVE1]='" + internal1objective + "',[SUB3 ASSIGNMENT1]='" + internal1assignment + "',[SUB3 THEORY2]='" + internal2theory + "',[SUB3 OBJECTIVE2]='" + internal2objective + "',[SUB3 ASSIGNMENT2]='" + internal2assignment + "',[SUB3 THEORY3]='" + internal3theory + "',[SUB3 OBJECTIVE3]='" + internal3objective + "',[SUB3 ASSIGNMENT3]='" + internal3assignment + "',[SUB3 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                   
                }

                else if (ddl1yrsub.SelectedItem.Text == "EC")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        //con.Open();
                       SqlCommand cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        //con.Open();
                       SqlCommand cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT4='" + ddl1yrsub.SelectedItem.Text + "',[SUB4 THEORY1]='" + internal1theory + "',[SUB4 OBJECTIVE1]='" + internal1objective + "',[SUB4 ASSIGNMENT1]='" + internal1assignment + "',[SUB4 THEORY2]='" + internal2theory + "',[SUB4 OBJECTIVE2]='" + internal2objective + "',[SUB4 ASSIGNMENT2]='" + internal2assignment + "',[SUB4 THEORY3]='" + internal3theory + "',[SUB4 OBJECTIVE3]='" + internal3objective + "',[SUB4 ASSIGNMENT3]='" + internal3assignment + "',[SUB4 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    
                }

                else if (ddl1yrsub.SelectedItem.Text == "MM")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT5='" + ddl1yrsub.SelectedItem.Text + "',[SUB5 THEORY1]='" + internal1theory + "',[SUB5 OBJECTIVE1]='" + internal1objective + "',[SUB5 ASSIGNMENT1]='" + internal1assignment + "',[SUB5 THEORY2]='" + internal2theory + "',[SUB5 OBJECTIVE2]='" + internal2objective + "',[SUB5 ASSIGNMENT2]='" + internal2assignment + "',[SUB5 THEORY3]='" + internal3theory + "',[SUB5 OBJECTIVE3]='" + internal3objective + "',[SUB5 ASSIGNMENT3]='" + internal3assignment + "',[SUB5 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                   
                }

                else if (ddl1yrsub.SelectedItem.Text == "M1")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT6='" + ddl1yrsub.SelectedItem.Text + "',[SUB6 THEORY1]='" + internal1theory + "',[SUB6 OBJECTIVE1]='" + internal1objective + "',[SUB6 ASSIGNMENT1]='" + internal1assignment + "',[SUB6 THEORY2]='" + internal2theory + "',[SUB6 OBJECTIVE2]='" + internal2objective + "',[SUB6 ASSIGNMENT2]='" + internal2assignment + "',[SUB6 THEORY3]='" + internal3theory + "',[SUB6 OBJECTIVE3]='" + internal3objective + "',[SUB6 ASSIGNMENT3]='" + internal3assignment + "',[SUB6 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                  
                }

                else if (ddl1yrsub.SelectedItem.Text == "EDP")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;
		string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT7='" + ddl1yrsub.SelectedItem.Text + "',[SUB7 THEORY1]='" + internal1theory + "',[SUB7 OBJECTIVE1]='" + internal1objective + "',[SUB7 ASSIGNMENT1]='" + internal1assignment + "',[SUB7 THEORY2]='" + internal2theory + "',[SUB7 OBJECTIVE2]='" + internal2objective + "',[SUB7 ASSIGNMENT2]='" + internal2assignment + "',[SUB7 THEORY3]='" + internal3theory + "',[SUB7 OBJECTIVE3]='" + internal3objective + "',[SUB7 ASSIGNMENT3]='" + internal3assignment + "',[SUB7 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    
                }

                else if (ddlfistlab.SelectedItem.Text == "C-LAB")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB1= '" + ddlfistlab.SelectedItem.Text + "',[LAB1 INTERNAL1]='" + labinternal1 + "', [LAB1 INTERNAL2]='" + labinternal2 + "',[LAB1 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    
                }

                else if (ddlfistlab.SelectedItem.Text == "PHYSICS/CHEMISTRY")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                         string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB2= '" + ddlfistlab.SelectedItem.Text + "',[LAB2 INTERNAL1]='" + labinternal1 + "', [LAB2 INTERNAL2]='" + labinternal2 + "',[LAB2 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                   
                }

                else if (ddlfistlab.SelectedItem.Text == "IT WORKSHOP")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                      string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                    {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB3= '" + ddlfistlab.SelectedItem.Text + "',[LAB3 INTERNAL1]='" + labinternal1 + "', [LAB3 INTERNAL2]='" + labinternal2 + "',[LAB3 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                  
                }
                else if (ddlfistlab.SelectedItem.Text == "ELCS")
                {

                    if (i == 0)
                    {
                        stid = txtidno0.Text;
                        name = txtname0.Text;
                        internal1theory = txtI1S1.Text;
                        internal1objective = txtI1O1.Text;
                        internal1assignment = txtI1A1.Text;
                        internal2theory = txtI12S1.Text;
                        internal2objective = txtI2O1.Text;
                        internal2assignment = txtI2A1.Text;
                        internal3theory = txtI13S1.Text;
                        internal3objective = txtI3O1.Text;
                        internal3assignment = txtI3A1.Text;
                        external = txtSE1.Text;
                        labinternal1 = txtI1L1.Text;
                        labinternal2 = txtI2L1.Text;
                        labexternal = txtLE1.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 1)
                    {
                        stid = txtidno1.Text;
                        name = txtname1.Text;
                        internal1theory = txtI1S2.Text;
                        internal1objective = txtI1O2.Text;
                        internal1assignment = txtI1A2.Text;
                        internal2theory = txtI12S2.Text;
                        internal2objective = txtI2O2.Text;
                        internal2assignment = txtI2A2.Text;
                        internal3theory = txtI13S2.Text;
                        internal3objective = txtI3O2.Text;
                        internal3assignment = txtI3A2.Text;
                        external = txtSE2.Text;
                        labinternal1 = txtI1L2.Text;
                        labinternal2 = txtI2L2.Text;
                        labexternal = txtLE2.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        ////con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }

                    else if (i == 2)
                    {
                        stid = txtidno2.Text;
                        name = txtname2.Text;
                        internal1theory = txtI1S3.Text;
                        internal1objective = txtI1O3.Text;
                        internal1assignment = txtI1A3.Text;
                        internal2theory = txtI12S3.Text;
                        internal2objective = txtI2O3.Text;
                        internal2assignment = txtI2A3.Text;
                        internal3theory = txtI13S3.Text;
                        internal3objective = txtI3O3.Text;
                        internal3assignment = txtI3A3.Text;
                        external = txtSE3.Text;
                        labinternal1 = txtI1L3.Text;
                        labinternal2 = txtI2L3.Text;
                        labexternal = txtLE3.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 3)
                    {
                        stid = txtidno3.Text;
                        name = txtname3.Text;
                        internal1theory = txtI1S4.Text;
                        internal1objective = txtI1O4.Text;
                        internal1assignment = txtI1A4.Text;
                        internal2theory = txtI12S4.Text;
                        internal2objective = txtI2O4.Text;
                        internal2assignment = txtI2A4.Text;
                        internal3theory = txtI13S4.Text;
                        internal3objective = txtI3O4.Text;
                        internal3assignment = txtI3A4.Text;
                        external = txtSE4.Text;
                        labinternal1 = txtI1L4.Text;
                        labinternal2 = txtI2L4.Text;
                        labexternal = txtLE4.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 4)
                    {
                        stid = txtidno4.Text;
                        name = txtname4.Text;
                        internal1theory = txtI1S5.Text;
                        internal1objective = txtI1O5.Text;
                        internal1assignment = txtI1A5.Text;
                        internal2theory = txtI12S5.Text;
                        internal2objective = txtI2O5.Text;
                        internal2assignment = txtI2A5.Text;
                        internal3theory = txtI13S5.Text;
                        internal3objective = txtI3O5.Text;
                        internal3assignment = txtI3A5.Text;
                        external = txtSE5.Text;
                        labinternal1 = txtI1L5.Text;
                        labinternal2 = txtI2L5.Text;
                        labexternal = txtLE5.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
//                        con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 5)
                    {
                        stid = txtidno5.Text;
                        name = txtname5.Text;
                        internal1theory = txtI1S6.Text;
                        internal1objective = txtI1O6.Text;
                        internal1assignment = txtI1A6.Text;
                        internal2theory = txtI12S6.Text;
                        internal2objective = txtI2O6.Text;
                        internal2assignment = txtI2A6.Text;
                        internal3theory = txtI13S6.Text;
                        internal3objective = txtI3O6.Text;
                        internal3assignment = txtI3A6.Text;
                        external = txtSE6.Text;
                        labinternal1 = txtI1L6.Text;
                        labinternal2 = txtI2L6.Text;
                        labexternal = txtLE6.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 6)
                    {
                        stid = txtidno6.Text;
                        name = txtname6.Text;
                        internal1theory = txtI1S7.Text;
                        internal1objective = txtI1O7.Text;
                        internal1assignment = txtI1A7.Text;
                        internal2theory = txtI12S7.Text;
                        internal2objective = txtI2O7.Text;
                        internal2assignment = txtI2A7.Text;
                        internal3theory = txtI13S7.Text;
                        internal3objective = txtI3O7.Text;
                        internal3assignment = txtI3A7.Text;
                        external = txtSE7.Text;
                        labinternal1 = txtI1L7.Text;
                        labinternal2 = txtI2L7.Text;
                        labexternal = txtLE7.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 7)
                    {
                        stid = txtidno7.Text;
                        name = txtname7.Text;
                        internal1theory = txtI1S8.Text;
                        internal1objective = txtI1O8.Text;
                        internal1assignment = txtI1A8.Text;
                        internal2theory = txtI12S8.Text;
                        internal2objective = txtI2O8.Text;
                        internal2assignment = txtI2A8.Text;
                        internal3theory = txtI13S8.Text;
                        internal3objective = txtI3O8.Text;
                        internal3assignment = txtI3A8.Text;
                        external = txtSE8.Text;
                        labinternal1 = txtI1L8.Text;
                        labinternal2 = txtI2L8.Text;
                        labexternal = txtLE8.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 8)
                    {
                        stid = txtidno8.Text;
                        name = txtname8.Text;
                        internal1theory = txtI1S9.Text;
                        internal1objective = txtI1O9.Text;
                        internal1assignment = txtI1A9.Text;
                        internal2theory = txtI12S9.Text;
                        internal2objective = txtI2O9.Text;
                        internal2assignment = txtI2A9.Text;
                        internal3theory = txtI13S9.Text;
                        internal3objective = txtI3O9.Text;
                        internal3assignment = txtI3A9.Text;
                        external = txtSE9.Text;
                        labinternal1 = txtI1L9.Text;
                        labinternal2 = txtI2L9.Text;
                        labexternal = txtLE9.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 9)
                    {
                        stid = txtidno9.Text;
                        name = txtname9.Text;
                        internal1theory = txtI1S10.Text;
                        internal1objective = txtI1O10.Text;
                        internal1assignment = txtI1A10.Text;
                        internal2theory = txtI12S10.Text;
                        internal2objective = txtI2O10.Text;
                        internal2assignment = txtI2A10.Text;
                        internal3theory = txtI13S10.Text;
                        internal3objective = txtI3O10.Text;
                        internal3assignment = txtI3A10.Text;
                        external = txtSE10.Text;
                        labinternal1 = txtI1L10.Text;
                        labinternal2 = txtI2L10.Text;
                        labexternal = txtLE10.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 10)
                    {
                        stid = txtidno10.Text;
                        name = txtname10.Text;
                        internal1theory = txtI1S11.Text;
                        internal1objective = txtI1O11.Text;
                        internal1assignment = txtI1A11.Text;
                        internal2theory = txtI12S11.Text;
                        internal2objective = txtI2O11.Text;
                        internal2assignment = txtI2A11.Text;
                        internal3theory = txtI13S11.Text;
                        internal3objective = txtI3O11.Text;
                        internal3assignment = txtI3A11.Text;
                        external = txtSE11.Text;
                        labinternal1 = txtI1L11.Text;
                        labinternal2 = txtI2L11.Text;
                        labexternal = txtLE11.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 11)
                    {
                        stid = txtidno11.Text;
                        name = txtname11.Text;
                        internal1theory = txtI1S12.Text;
                        internal1objective = txtI1O12.Text;
                        internal1assignment = txtI1A12.Text;
                        internal2theory = txtI12S12.Text;
                        internal2objective = txtI2O12.Text;
                        internal2assignment = txtI2A12.Text;
                        internal3theory = txtI13S12.Text;
                        internal3objective = txtI3O12.Text;
                        internal3assignment = txtI3A12.Text;
                        external = txtSE12.Text;
                        labinternal1 = txtI1L12.Text;
                        labinternal2 = txtI2L12.Text;
                        labexternal = txtLE12.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 12)
                    {
                        stid = txtidno12.Text;
                        name = txtname12.Text;
                        internal1theory = txtI1S13.Text;
                        internal1objective = txtI1O13.Text;
                        internal1assignment = txtI1A13.Text;
                        internal2theory = txtI12S13.Text;
                        internal2objective = txtI2O13.Text;
                        internal2assignment = txtI2A13.Text;
                        internal3theory = txtI13S13.Text;
                        internal3objective = txtI3O13.Text;
                        internal3assignment = txtI3A13.Text;
                        external = txtSE13.Text;
                        labinternal1 = txtI1L13.Text;
                        labinternal2 = txtI2L13.Text;
                        labexternal = txtLE13.Text;

                     string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 13)
                    {
                        stid = txtidno13.Text;
                        name = txtname13.Text;
                        internal1theory = txtI1S14.Text;
                        internal1objective = txtI1O14.Text;
                        internal1assignment = txtI1A14.Text;
                        internal2theory = txtI12S14.Text;
                        internal2objective = txtI2O14.Text;
                        internal2assignment = txtI2A14.Text;
                        internal3theory = txtI13S14.Text;
                        internal3objective = txtI3O14.Text;
                        internal3assignment = txtI3A14.Text;
                        external = txtSE14.Text;
                        labinternal1 = txtI1L14.Text;
                        labinternal2 = txtI2L14.Text;
                        labexternal = txtLE14.Text;

                     string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 14)
                    {
                        stid = txtidno14.Text;
                        name = txtname14.Text;
                        internal1theory = txtI1S15.Text;
                        internal1objective = txtI1O15.Text;
                        internal1assignment = txtI1A15.Text;
                        internal2theory = txtI12S15.Text;
                        internal2objective = txtI2O15.Text;
                        internal2assignment = txtI2A15.Text;
                        internal3theory = txtI13S15.Text;
                        internal3objective = txtI3O15.Text;
                        internal3assignment = txtI3A15.Text;
                        external = txtSE15.Text;
                        labinternal1 = txtI1L15.Text;
                        labinternal2 = txtI2L15.Text;
                        labexternal = txtLE15.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 15)
                    {
                        stid = txtidno15.Text;
                        name = txtname15.Text;
                        internal1theory = txtI1S16.Text;
                        internal1objective = txtI1O16.Text;
                        internal1assignment = txtI1A16.Text;
                        internal2theory = txtI12S16.Text;
                        internal2objective = txtI2O16.Text;
                        internal2assignment = txtI2A16.Text;
                        internal3theory = txtI13S16.Text;
                        internal3objective = txtI3O16.Text;
                        internal3assignment = txtI3A16.Text;
                        external = txtSE16.Text;
                        labinternal1 = txtI1L16.Text;
                        labinternal2 = txtI2L16.Text;
                        labexternal = txtLE16.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 16)
                    {
                        stid = txtidno16.Text;
                        name = txtname16.Text;
                        internal1theory = txtI1S17.Text;
                        internal1objective = txtI1O17.Text;
                        internal1assignment = txtI1A17.Text;
                        internal2theory = txtI12S17.Text;
                        internal2objective = txtI2O17.Text;
                        internal2assignment = txtI2A17.Text;
                        internal3theory = txtI13S17.Text;
                        internal3objective = txtI3O17.Text;
                        internal3assignment = txtI3A17.Text;
                        external = txtSE17.Text;
                        labinternal1 = txtI1L17.Text;
                        labinternal2 = txtI2L17.Text;
                        labexternal = txtLE17.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 17)
                    {
                        stid = txtidno17.Text;
                        name = txtname17.Text;
                        internal1theory = txtI1S18.Text;
                        internal1objective = txtI1O18.Text;
                        internal1assignment = txtI1A18.Text;
                        internal2theory = txtI12S18.Text;
                        internal2objective = txtI2O18.Text;
                        internal2assignment = txtI2A18.Text;
                        internal3theory = txtI13S18.Text;
                        internal3objective = txtI3O18.Text;
                        internal3assignment = txtI3A18.Text;
                        external = txtSE18.Text;
                        labinternal1 = txtI1L18.Text;
                        labinternal2 = txtI2L18.Text;
                        labexternal = txtLE18.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 18)
                    {
                        stid = txtidno18.Text;
                        name = txtname18.Text;
                        internal1theory = txtI1S19.Text;
                        internal1objective = txtI1O19.Text;
                        internal1assignment = txtI1A19.Text;
                        internal2theory = txtI12S19.Text;
                        internal2objective = txtI2O19.Text;
                        internal2assignment = txtI2A19.Text;
                        internal3theory = txtI13S19.Text;
                        internal3objective = txtI3O19.Text;
                        internal3assignment = txtI3A19.Text;
                        external = txtSE19.Text;
                        labinternal1 = txtI1L19.Text;
                        labinternal2 = txtI2L19.Text;
                        labexternal = txtLE19.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 19)
                    {
                        stid = txtidno19.Text;
                        name = txtname19.Text;
                        internal1theory = txtI1S20.Text;
                        internal1objective = txtI1O20.Text;
                        internal1assignment = txtI1A20.Text;
                        internal2theory = txtI12S20.Text;
                        internal2objective = txtI2O20.Text;
                        internal2assignment = txtI2A20.Text;
                        internal3theory = txtI13S20.Text;
                        internal3objective = txtI3O20.Text;
                        internal3assignment = txtI3A20.Text;
                        external = txtSE20.Text;
                        labinternal1 = txtI1L20.Text;
                        labinternal2 = txtI2L20.Text;
                        labexternal = txtLE20.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                       // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 20)
                    {
                        stid = txtidno20.Text;
                        name = txtname20.Text;
                        internal1theory = txtI1S21.Text;
                        internal1objective = txtI1O21.Text;
                        internal1assignment = txtI1A21.Text;
                        internal2theory = txtI12S21.Text;
                        internal2objective = txtI2O21.Text;
                        internal2assignment = txtI2A21.Text;
                        internal3theory = txtI13S21.Text;
                        internal3objective = txtI3O21.Text;
                        internal3assignment = txtI3A21.Text;
                        external = txtSE21.Text;
                        labinternal1 = txtI1L21.Text;
                        labinternal2 = txtI2L21.Text;
                        labexternal = txtLE21.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                       // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 21)
                    {
                        stid = txtidno21.Text;
                        name = txtname21.Text;
                        internal1theory = txtI1S22.Text;
                        internal1objective = txtI1O22.Text;
                        internal1assignment = txtI1A22.Text;
                        internal2theory = txtI12S22.Text;
                        internal2objective = txtI2O22.Text;
                        internal2assignment = txtI2A22.Text;
                        internal3theory = txtI13S22.Text;
                        internal3objective = txtI3O22.Text;
                        internal3assignment = txtI3A22.Text;
                        external = txtSE22.Text;
                        labinternal1 = txtI1L22.Text;
                        labinternal2 = txtI2L22.Text;
                        labexternal = txtLE22.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                      //  con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 22)
                    {
                        stid = txtidno22.Text;
                        name = txtname22.Text;
                        internal1theory = txtI1S23.Text;
                        internal1objective = txtI1O23.Text;
                        internal1assignment = txtI1A23.Text;
                        internal2theory = txtI12S23.Text;
                        internal2objective = txtI2O23.Text;
                        internal2assignment = txtI2A23.Text;
                        internal3theory = txtI13S23.Text;
                        internal3objective = txtI3O23.Text;
                        internal3assignment = txtI3A23.Text;
                        external = txtSE23.Text;
                        labinternal1 = txtI1L23.Text;
                        labinternal2 = txtI2L23.Text;
                        labexternal = txtLE23.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 23)
                    {
                        stid = txtidno23.Text;
                        name = txtname23.Text;
                        internal1theory = txtI1S24.Text;
                        internal1objective = txtI1O24.Text;
                        internal1assignment = txtI1A24.Text;
                        internal2theory = txtI12S24.Text;
                        internal2objective = txtI2O24.Text;
                        internal2assignment = txtI2A24.Text;
                        internal3theory = txtI13S24.Text;
                        internal3objective = txtI3O24.Text;
                        internal3assignment = txtI3A24.Text;
                        external = txtSE24.Text;
                        labinternal1 = txtI1L24.Text;
                        labinternal2 = txtI2L24.Text;
                        labexternal = txtLE24.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                       // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 24)
                    {
                        stid = txtidno24.Text;
                        name = txtname24.Text;
                        internal1theory = txtI1S25.Text;
                        internal1objective = txtI1O25.Text;
                        internal1assignment = txtI1A25.Text;
                        internal2theory = txtI12S25.Text;
                        internal2objective = txtI2O25.Text;
                        internal2assignment = txtI2A25.Text;
                        internal3theory = txtI13S25.Text;
                        internal3objective = txtI3O25.Text;
                        internal3assignment = txtI3A25.Text;
                        external = txtSE25.Text;
                        labinternal1 = txtI1L25.Text;
                        labinternal2 = txtI2L25.Text;
                        labexternal = txtLE25.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                       // con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 25)
                    {
                        stid = txtidno25.Text;
                        name = txtname25.Text;
                        internal1theory = txtI1S26.Text;
                        internal1objective = txtI1O26.Text;
                        internal1assignment = txtI1A26.Text;
                        internal2theory = txtI12S26.Text;
                        internal2objective = txtI2O26.Text;
                        internal2assignment = txtI2A26.Text;
                        internal3theory = txtI13S26.Text;
                        internal3objective = txtI3O26.Text;
                        internal3assignment = txtI3A26.Text;
                        external = txtSE26.Text;
                        labinternal1 = txtI1L26.Text;
                        labinternal2 = txtI2L26.Text;
                        labexternal = txtLE26.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 26)
                    {
                        stid = txtidno26.Text;
                        name = txtname26.Text;
                        internal1theory = txtI1S27.Text;
                        internal1objective = txtI1O27.Text;
                        internal1assignment = txtI1A27.Text;
                        internal2theory = txtI12S27.Text;
                        internal2objective = txtI2O27.Text;
                        internal2assignment = txtI2A27.Text;
                        internal3theory = txtI13S27.Text;
                        internal3objective = txtI3O27.Text;
                        internal3assignment = txtI3A27.Text;
                        external = txtSE27.Text;
                        labinternal1 = txtI1L27.Text;
                        labinternal2 = txtI2L27.Text;
                        labexternal = txtLE27.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 27)
                    {
                        stid = txtidno27.Text;
                        name = txtname27.Text;
                        internal1theory = txtI1S28.Text;
                        internal1objective = txtI1O28.Text;
                        internal1assignment = txtI1A28.Text;
                        internal2theory = txtI12S28.Text;
                        internal2objective = txtI2O28.Text;
                        internal2assignment = txtI2A28.Text;
                        internal3theory = txtI13S28.Text;
                        internal3objective = txtI3O28.Text;
                        internal3assignment = txtI3A28.Text;
                        external = txtSE28.Text;
                        labinternal1 = txtI1L28.Text;
                        labinternal2 = txtI2L28.Text;
                        labexternal = txtLE28.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 28)
                    {
                        stid = txtidno28.Text;
                        name = txtname28.Text;
                        internal1theory = txtI1S29.Text;
                        internal1objective = txtI1O29.Text;
                        internal1assignment = txtI1A29.Text;
                        internal2theory = txtI12S29.Text;
                        internal2objective = txtI2O29.Text;
                        internal2assignment = txtI2A29.Text;
                        internal3theory = txtI13S29.Text;
                        internal3objective = txtI3O29.Text;
                        internal3assignment = txtI3A29.Text;
                        external = txtSE29.Text;
                        labinternal1 = txtI1L29.Text;
                        labinternal2 = txtI2L29.Text;
                        labexternal = txtLE29.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 29)
                   {
                        stid = txtidno29.Text;
                        name = txtname29.Text;
                        internal1theory = txtI1S30.Text;
                        internal1objective = txtI1O30.Text;
                        internal1assignment = txtI1A30.Text;
                        internal2theory = txtI12S30.Text;
                        internal2objective = txtI2O30.Text;
                        internal2assignment = txtI2A30.Text;
                        internal3theory = txtI13S30.Text;
                        internal3objective = txtI3O30.Text;
                        internal3assignment = txtI3A30.Text;
                        external = txtSE30.Text;
                        labinternal1 = txtI1L30.Text;
                        labinternal2 = txtI2L30.Text;
                        labexternal = txtLE30.Text;

                       string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                    else if (i == 30)
                    {
                        stid = txtidno30.Text;
                        name = txtname30.Text;
                        internal1theory = txtI1S31.Text;
                        internal1objective = txtI1O31.Text;
                        internal1assignment = txtI1A31.Text;
                        internal2theory = txtI12S31.Text;
                        internal2objective = txtI2O31.Text;
                        internal2assignment = txtI2A31.Text;
                        internal3theory = txtI13S31.Text;
                        internal3objective = txtI3O31.Text;
                        internal3assignment = txtI3A31.Text;
                        external = txtSE31.Text;
                        labinternal1 = txtI1L31.Text;
                        labinternal2 = txtI2L31.Text;
                        labexternal = txtLE31.Text;

                        string str = "update FSTYEARSTUDENTEXAMINATIONDETAILS set DEPARTMENT='" + ddldept.SelectedItem.Text + "',YEAR='" + ddlyear.SelectedItem.Text + "',NAME= '" + name + "',SUBJECT1='" + ddl1yrsub.SelectedItem.Text + "',[SUB1 THEORY1]='" + internal1theory + "',[SUB1 OBJECTIVE1]='" + internal1objective + "',[SUB1 ASSIGNMENT1]='" + internal1assignment + "',[SUB1 THEORY2]='" + internal2theory + "',[SUB1 OBJECTIVE2]='" + internal2objective + "',[SUB1 ASSIGNMENT2]='" + internal2assignment + "',[SUB1 THEORY3]='" + internal3theory + "',[SUB1 OBJECTIVE3]='" + internal3objective + "',[SUB1 ASSIGNMENT3]='" + internal3assignment + "',[SUB1 EXTERNAL]='" + external + "',LAB4= '" + ddlfistlab.SelectedItem.Text + "',[LAB4 INTERNAL1]='" + labinternal1 + "', [LAB4 INTERNAL2]='" + labinternal2 + "',[LAB4 EXTERNAL]='" + labexternal + "' where [ID NUMBER]='" + stid + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        //con.Open();
                        cmd.ExecuteNonQuery().ToString();
                    }
                   
                }
                
             }
            MessageBox.Show("successfully updated");

         }
         
   
    
        
     }










    
    
    




}


    
   
                        
