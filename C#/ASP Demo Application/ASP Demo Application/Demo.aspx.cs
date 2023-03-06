using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Demo_Application
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load( object sender, EventArgs e )
        {

        }

        protected void SubmitBtn_Click( object sender, EventArgs e )
        {
            Response.Write( NameTxtbox.Text + "</br>" );

            Response.Write( LocationLstbox.SelectedItem.Text + "</br>" );

            NameLbl.Visible = false;
            NameTxtbox.Visible = false;
            LocationLstbox.Visible = false;
            CChkBox.Visible = false;
            ASPChkBox.Visible = false;
            FemaleRadioBtn.Visible = false;
            MaleRadioBtn.Visible = false;
            SubmitBtn.Visible = false;
        }
    }
}