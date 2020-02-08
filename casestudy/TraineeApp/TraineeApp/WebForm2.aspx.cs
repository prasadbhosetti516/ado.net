using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                TraineeDataLayer a = new TraineeDataLayer();
                var llist = a.getallrecords();
                GridView1.DataSource = llist;
                GridView1.DataBind();
            }
        }
    }
}