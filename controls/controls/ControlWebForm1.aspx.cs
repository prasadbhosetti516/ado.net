using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controls
{
    public partial class ControlWebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string data = "";
            string firstname = txtName.Text;
            string middlename = txtName.Text;
            string lastname = txtName.Text;
            string DOB = Calendar1.SelectedDate.ToString();
            string Gender = RadioButtonList1.SelectedItem.Value.ToString();
            string hobby = "";
            if(CheckBoxList1.Items[0].Selected)
            {
                hobby += "\n" + CheckBoxList1.Items[0].Value;
            }

            if (CheckBoxList1.Items[1].Selected)
            {
                hobby += "\n" + CheckBoxList1.Items[1].Value;
            }

            if (CheckBoxList1.Items[2].Selected)
            {
                hobby += "\n" + CheckBoxList1.Items[2].Value;
            }

            if (CheckBoxList1.Items[3].Selected)
            {
                hobby += "\n" + CheckBoxList1.Items[3].Value;
            }

            if (CheckBoxList1.Items[4].Selected)
            {
                hobby += "\n" + CheckBoxList1.Items[4].Value;
            }
            string education = DropDownList1.SelectedValue;
            data += "firstname is:"+firstname + "\n" + "middla name is:"+middlename +
                "\n" +"lastname is:" +lastname + "\n" + "gender is:"+Gender + "\n" + 
                "hobbies are:"+hobby + "\n" + "education details are"+education;
            Label6.Text = data;

        }
    }
}