using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                TraineeDataLayer t = new TraineeDataLayer();
                int tid = int.Parse(TextBox1.Text);
                string tname = TextBox2.Text;
                t.update(tid, tname);
            }
        }
    }
}