using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddFlight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillplane();
    }
    protected void fillplane()
    {
        Process pr = new Process();
        List<Process.plane> pl = new List<Process.plane>();
        pl = pr.getplane();
        foreach(Process.plane temp in pl)
        {
            DropDownList1.Items.Add(temp.pname);
        }

    }
    protected List<int> pid(string pname)
    {
        Process pr = new Process();
        List<int> ret = new List<int>();
        List<Process.plane> pl = new List<Process.plane>();
        pl = pr.getplane();
        foreach (Process.plane temp in pl)
        {
            if (temp.pname.Equals(pname))
            {
                ret.Add(temp.id);
                ret.Add(temp.seats);
                continue;
            }
        }
        return ret;
    }
    
    protected void Button5_Click(object sender, EventArgs e)
    {

        if (TextBox1.Text.Length < 2 || TextBox2.Text.Length < 2 || TextBox5.Text.Length < 2 || TextBox6.Text.Length < 1 || TextBox3.Text.Length < 1 || TextBox8.Text.Length < 2 || TextBox9.Text.Length < 2 || TextBox10.Text.Length < 2 || TextBox3.Text.Length < 1 || TextBox3.Text.Length < 1)
        {
            Label5.Visible = true;
            return;
        }
        /*if (int.Parse(TextBox3.Text) < 0 || int.Parse(TextBox3.Text) < 0 || int.Parse(TextBox3.Text) > 23 || int.Parse(TextBox3.Text) > 59)
        {
            Label2.Visible = true;
            return;
        }
        if (int.Parse(TextBox6.Text) < 0 || int.Parse(TextBox6.Text) < 0 || int.Parse(TextBox6.Text) > 23 || int.Parse(TextBox3.Text) > 59)
        {
            Label3.Visible = true;
            return;
        }*/

        string fn = TextBox1.Text.ToString();
        TimeSpan dt = TimeSpan.Parse(TextBox3.Text);
        DateTime dd = Convert.ToDateTime(TextBox2.Text);

        //TimeSpan at = new TimeSpan(int.Parse(TextBox6.Text), int.Parse(TextBox7.Text), 0);
        //DateTime ad = new DateTime(Calendar3.SelectedDate.Year, Calendar3.SelectedDate.Month, Calendar3.SelectedDate.Day, at.Hours, at.Minutes, at.Seconds);
        TimeSpan at = TimeSpan.Parse(TextBox6.Text);
        DateTime ad = Convert.ToDateTime(TextBox5.Text);
        float price = float.Parse(TextBox8.Text);
        string dl = TextBox9.Text;
        string al = TextBox10.Text;
        string pc = DropDownList1.SelectedValue.ToString();
        float chpr = float.Parse(TextBox11.Text);
        Process.flight fl = new Process.flight();
        fl.depT = dd;
        fl.arrT = ad;
        fl.depl = dl;
        fl.arrl = al;
        fl.flightno = fn;
        fl.regp = price;
        fl.chp = chpr;
        List<int> det = pid(pc);
        fl.planeid = det[0];
        fl.avseat = det[1];


        try
        {
            Process db = new Process();
            db.addFlight(fl);
            Response.Redirect("flight_list.aspx");
        }
        catch (Exception ex)
        {
            Label5.Visible = true;
        }
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
       // TextBox2.Text = Calendar2.SelectedDate.ToString().Substring(0, 9);
      //  Calendar2.Visible = false;

    }
    protected void Calendar3_SelectionChanged(object sender, EventArgs e)
    {
      //  TextBox5.Text = Calendar3.SelectedDate.ToString().Substring(0, 9);
      //  Calendar3.Visible = false;
    }
}