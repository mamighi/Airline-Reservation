using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string m_val;
    public string linkpage;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["user"] == null || Session["user"].ToString().Equals(""))
        {
            linkpage = "SignUp.aspx";
            m_val = "Register";
            Button2.Visible = false;
        }
        else
        {
            uli.Visible = false;
            m_val = "My Reservations";
            linkpage="ReservationHistory.aspx";
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Process pr = new Process();
        char r = pr.login(user_name.Value.ToString(), Password.Value.ToString());
        if(r=='w')
        {
            return;
        }
        else if(r=='a')
        {
            Session["user"] = user_name.Value.ToString();
            Response.Redirect("FlightList.aspx");
        }
        else if(r=='u')
        {
            Session["user"] = user_name.Value.ToString();
            Response.Redirect("Default.aspx");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        Response.Redirect("Default.aspx");
    }
}
