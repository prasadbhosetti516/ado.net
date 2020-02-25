using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace asp
{
    public class DataLayer
    {
        DataSet ds = new DataSet();
        string constr = "";
        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["kanna"].ConnectionString;
        }


        public void InsertStudent(int Sid, string Sname, string Sgender)
        {
            // string err = "";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Sid", Sid);
                    cmd.Parameters.AddWithValue("@Sname", Sname);
                    cmd.Parameters.AddWithValue("@Sgender", Sgender);

                    cmd.CommandText = "Student_insert";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }


                catch
                {
                    //err = ex.Message;
                }
                //  return err;

            }
        }
        public void InsertCourse(int Cid, string Cname, string Caddr)
        {
            // string err = "";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Cid", Cid);
                    cmd.Parameters.AddWithValue("@Cname", Cname);
                    cmd.Parameters.AddWithValue("@Caddr", Caddr);

                    cmd.CommandText = "Course_Insert";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }


                catch
                {
                    //err = ex.Message;
                }
                //  return err;

            }
        }
        public void InsertFaculty(int Fid, string Fname, string Faddr)
        {
            // string err = "";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Fid", Fid);
                    cmd.Parameters.AddWithValue("@Fname", Fname);
                    cmd.Parameters.AddWithValue("@Faddr", Faddr);

                    cmd.CommandText = "Faculty_Insert";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }


                catch
                {
                    //err = ex.Message;
                }
                //  return err;

            }
        }
        public DataSet ShowStudent()
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string query1 = "select * from Student";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query1, con);


                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);
                    }
                    catch
                    {

                    }

                }
                return ds;
            }
        public DataSet ShowCourse()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query1 = "select * from Course";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query1, con);


                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                }
                catch
                {

                }

            }
            return ds;
        }
        public DataSet ShowFaculty()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query1 = "select * from Faculty";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query1, con);


                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                }
                catch
                {

                }

            }
            return ds;
        }
        public void StudentUpdate(int Sid, string Sname)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ThirdPage", con);
                    cmd.Parameters.AddWithValue("@Sid", Sid);
                    cmd.Parameters.AddWithValue("@Sname", Sname);
                    cmd.CommandText = "Student_Update";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }
                catch
                {

                }
            }
           

        }
        public void FacultyUpdate(int Fid, string Fname)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EleventhPage", con);
                    cmd.Parameters.AddWithValue("@Fid", Fid);
                    cmd.Parameters.AddWithValue("@Fname", Fname);
                    cmd.CommandText = "Faculty_Update";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }
                catch
                {

                }
            }


        }
        public void CourseUpdate(int Cid, string Cname)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SeventhPage", con);
                    cmd.Parameters.AddWithValue("@Cid", Cid);
                    cmd.Parameters.AddWithValue("@Cname", Cname);
                    cmd.CommandText = "Course_Update";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }
                catch
                {

                }
            }


        }


        public void DeleteStudent(int Sid)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("FourthPage",con);
                    cmd.Parameters.AddWithValue("@Sid", Sid);
                    
                    cmd.CommandText = "Student_Delete";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }
                catch
                {

                }
            }


        }
        public void DeleteFaculty(int Fid)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("TwelthPage", con);
                    cmd.Parameters.AddWithValue("@Fid", Fid);

                    cmd.CommandText = "Faculty_Delete";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }
                catch
                {

                }
            }


        }

        public void DeleteCourse(int Cid)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("FourthPage", con);
                    cmd.Parameters.AddWithValue("@Cid", Cid);

                    cmd.CommandText = "Course_Delete";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }
                catch
                {

                }
            }


        }

    }
}