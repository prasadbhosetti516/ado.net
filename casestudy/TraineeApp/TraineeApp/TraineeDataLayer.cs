using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TraineeApp
{
    public class TraineeDataLayer
    {
        DataSet ds = new DataSet();
        string constr = "";
        public TraineeDataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["Trainee"].ConnectionString;
        }


        public void insert(int tid, string tname, string location, string techdomain, DateTime startdate)
        {
           // string err = "";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.Parameters.AddWithValue("@tname", tname);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@techdomain", techdomain);
                    cmd.Parameters.AddWithValue("@startdate", startdate);
                    cmd.CommandText = "Trainee_insert";
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

        public DataSet getallrecords()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query1 = "select * from Trainee";
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

        public void update(int tid,string tname)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("WebForm",con);
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.Parameters.AddWithValue("@tname", tname);
                    cmd.CommandText = "Trainee_update";
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

