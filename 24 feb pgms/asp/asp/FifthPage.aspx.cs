using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class FifthPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataLayer d = new DataLayer();
            int Cid = int.Parse(TextBox1.Text);
            string Cname = (TextBox2.Text);
            string Caddr = (TextBox3.Text);

            d.InsertCourse(Cid, Cname, Caddr);
        }
    }
}