using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class EleventhPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataLayer t = new DataLayer();
            int Fid = int.Parse(TextBox1.Text);
            string Fname = TextBox2.Text;
            t.FacultyUpdate(Fid, Fname);
        }
    }
}