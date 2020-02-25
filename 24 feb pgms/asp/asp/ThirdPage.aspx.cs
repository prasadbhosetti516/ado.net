using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class ThirdPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DataLayer t = new DataLayer();
            int Sid = int.Parse(TextBox1.Text);
            string Sname = TextBox2.Text;
            t.StudentUpdate(Sid, Sname);

        }
    }
}