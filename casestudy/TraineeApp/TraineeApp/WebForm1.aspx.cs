using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TraineeDataLayer tdl = new TraineeDataLayer();
           
            int tid = int.Parse(TextBox1.Text);
            string tname =(TextBox2.Text);
            string location = (TextBox3.Text);
           string techdomain =(TextBox4.Text);
           DateTime startdate =Convert.ToDateTime(TextBox5.Text);
            tdl.insert(tid, tname, location, techdomain,startdate);
            
        }
    }
}