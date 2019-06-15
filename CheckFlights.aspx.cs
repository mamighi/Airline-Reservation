using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckFlights : System.Web.UI.Page
{
    List<Process.flight> fl;
    Process.flight selected;
    bool check;
    public int ad, ch,number;
    float total;
    string seats;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Process pr = new Process();
        if (Session["User"] == null)
        {
            RadioButton1.Visible = false;
            RadioButton2.Visible = false;

            HyperLink2.Visible = true;
            Button2.Visible = false;
        }
        else
            Label17.Text = pr.getcno(Session["User"].ToString().TrimEnd());
        check = false;
        Label18.Visible = false;

        selected = new Process.flight();
        fl = pr.getflights();
        if (!IsPostBack)
        {
            
            confirm.Visible = false;
            SEL.Visible = false;
            fillDep();
           
        }
        else
        {
            if (Session["S"] != null)
            {
                string test = Session["S"].ToString();
                string function = "setSelected('" + Session["S"].ToString().Trim() + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", function, true);
 
            }
        }
    }
    protected void fillDep()
    {
        DropDownList1.Items.Clear();
        DropDownList1.Items.Add("NONE");
        foreach(Process.flight temp in fl)
        {
            bool check=true;
            DateTime now = System.DateTime.Now;
            if(now<temp.depT)
            {
                for (int i = 0; i < DropDownList1.Items.Count;i++ )
                {
                    if (DropDownList1.Items[i].ToString().Equals(temp.depl))
                        check = false;
                }
                if (check)
                {
                    DropDownList1.Items.Add(temp.depl);
                    selected.depl = temp.depl;
                }
                
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("NONE");
        foreach(Process.flight temp in fl)
        {
            bool check = true;
            if(temp.depl.Equals(DropDownList1.SelectedItem.ToString().TrimEnd()))
            {
                for (int i = 0; i < DropDownList2.Items.Count;i++ )
                {
                    if (DropDownList2.Items[i].ToString().Equals(temp.arrl))
                        check = false;
                }
                if(check)
                {
                    DropDownList2.Items.Add(temp.arrl);
                    selected.arrl = temp.arrl;
                }
            }
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        foreach(Process.flight temp in fl)
        {
            if(temp.depl.Equals(DropDownList1.SelectedItem.ToString().TrimEnd()) && temp.arrl.Equals(DropDownList2.SelectedItem.ToString().TrimEnd() ))
            {
                ListBox1.Items.Add(temp.depT.ToString());

            }
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach(Process.flight temp in fl)
        {
            if(temp.depl.Equals(DropDownList1.SelectedItem.ToString().TrimEnd()) && temp.arrl.Equals(DropDownList2.SelectedItem.ToString().TrimEnd() ) && temp.depT==DateTime.Parse(ListBox1.SelectedItem.ToString()))
            {
                selected = temp;
                check = true;
            }
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Label18.Visible = false;
        foreach (Process.flight temp in fl)
        {
            if (temp.depl.Equals(DropDownList1.SelectedItem.ToString().TrimEnd()) && temp.arrl.Equals(DropDownList2.SelectedItem.ToString().TrimEnd()) && temp.depT == DateTime.Parse(ListBox1.SelectedItem.ToString()))
            {
                selected = temp;
                check = true;
            }
        }
        if (check == true)
        {
            Label13.Text = selected.arrT.ToString();
            Label14.Text = selected.regp.ToString() + " RM";
            Label15.Text = selected.chp.ToString() + " RM";
            ad = Int32.Parse(DropDownList3.SelectedItem.ToString());
            ch = Int32.Parse(DropDownList4.SelectedItem.ToString());
            total = ad * selected.regp + ch * selected.chp;
            Label16.Text = total.ToString() + " RM";
            confirm.Visible = true;
            SEL.Visible = true;
        }
        else
            Label18.Visible = true;
        int flightId = selected.flightId;
       
        Process pr = new Process();
       // int flightId = Int32.Parse(Session["selected"].ToString().Trim());
        string seats = pr.getOccSeats(flightId);
        string function = "set('" + seats + "');";
        ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", function, true);
        number=Int32.Parse(DropDownList4.SelectedItem.ToString())+ Int32.Parse(DropDownList3.SelectedItem.ToString());

    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

        Label11.Visible = false;
        Label12.Visible = false;
        Label17.Visible = false;
        Button3.Visible = false;
        TextBox1.Visible = false;

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Label11.Visible = true;
        Label12.Visible = true;
        Label17.Visible = true;
        Button3.Visible = true;
        TextBox1.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox1.ReadOnly = false;
        TextBox1.Enabled = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        foreach (Process.flight temp in fl)
        {
            if (temp.depl.Equals(DropDownList1.SelectedItem.ToString().TrimEnd()) && temp.arrl.Equals(DropDownList2.SelectedItem.ToString().TrimEnd()) && temp.depT == DateTime.Parse(ListBox1.SelectedItem.ToString()))
            {
                selected = temp;
                check = true;
            }
        }
        string seats = Text1.Value;
        string[] t = seats.Split(',');
        if(t.Length!=number)
        {
            Label18.Text="Please choose the seats";
            Label18.Visible = true;
            return;
        }
        Process pr = new Process();
        Process.reservation res = new Process.reservation();
        res.fid = selected.flightId;
        res.chno = Int32.Parse(DropDownList4.SelectedItem.ToString());
        res.regno = Int32.Parse(DropDownList3.SelectedItem.ToString());
        res.total = res.regno * selected.regp + res.chno * selected.chp; ;
        res.us = Session["user"].ToString().TrimEnd();
        string status = "";
        string cardno="";
        if (RadioButton1.Checked)
        {
            status = "BOOKED";
            if (TextBox1.Text.Length > 2)
                cardno = TextBox1.Text;
            else
                cardno = Label17.Text;
        }
        else
        {
            status = "RESERVED";

        }
        res.st = status;
        res.cardno = cardno;
        pr.newResrvation(res);
        pr.dedav(ad + ch, res.fid);
        int idres = pr.getLastResId();
        pr.addOccSeat(seats, res.fid, idres);
        
        Response.Redirect("ReservationHistory.aspx");

    }
}