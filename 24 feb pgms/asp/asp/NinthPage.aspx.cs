using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class NinthPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataLayer d = new DataLayer();
            int Fid = int.Parse(TextBox1.Text);
         string Fname =(TextBox2.Text);
           string Faddr = (TextBox3.Text);
            d.InsertFaculty(Fid, Fname, Faddr);
        }
    }
}