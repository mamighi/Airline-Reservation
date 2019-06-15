using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        if (!TextBox2.Text.Equals(TextBox3.Text))
        {
            Label2.Visible = true;
            return;
        }
        if (TextBox1.Text.Length < 2 || TextBox2.Text.Length < 2 || TextBox4.Text.Length < 2 || TextBox5.Text.Length < 2 || TextBox6.Text.Length < 2 || TextBox7.Text.Length < 2 || TextBox8.Text.Length < 2)
        {
            Label1.Visible = true;
            return;
        }
        Process.user us = new Process.user();
        us.usename = TextBox1.Text;
        us.pass = TextBox2.Text;
        us.fn = TextBox4.Text;
        us.ln = TextBox5.Text;
        us.email = TextBox6.Text;
        us.ph = TextBox7.Text;
        us.gender = DropDownList1.SelectedItem.ToString();
        us.cn = TextBox8.ToString();
        us.ulev = "admin";
        Process pr = new Process();
        pr.adduser(us);
        Response.Redirect("Default.aspx");
    }
}