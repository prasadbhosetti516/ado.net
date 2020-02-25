using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class TenthPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataLayer d = new DataLayer();
            var llist = d.ShowFaculty();
            GridView1.DataSource = llist;
            GridView1.DataBind();
        }
    }
}