using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                DataLayer a = new DataLayer();
                var llist = a.ShowStudent();
                GridView1.DataSource = llist;
                GridView1.DataBind();
            }
        }
    }
}