using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddPlane : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if(TextBox2.Text.Length<2|| TextBox4.Text.Length<2)
        {
            Label1.Visible = true;
            return;
        }
        Process pr = new Process();
        Process.plane pl = new Process.plane();
        pl.pmodel = TextBox4.Text;
        pl.pname = TextBox2.Text;
        pl.seats = 60;
        pr.addplane(pl);
        Response.Redirect("AddFlight.aspx");
    }
}