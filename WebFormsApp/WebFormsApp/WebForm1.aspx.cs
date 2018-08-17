using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void OnServerClick(object sender, EventArgs e)
        {
            lblTxt.InnerText = txtName.Value;
        }

        protected void Redirect(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Transfer(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx");
        }
    }
}