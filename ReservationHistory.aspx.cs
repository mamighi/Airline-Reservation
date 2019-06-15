using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReservationHistory : System.Web.UI.Page
{
    List<Process.reservation> res;
    protected void Page_Load(object sender, EventArgs e)
    {
        Process pros = new Process();
        res = pros.getReservation();
        generate();
    }
    protected void generate()
    {
        string st;
        if (RadioButton1.Checked) st = "All";
        else if (RadioButton2.Checked) st = "RESERVED";
        else if (RadioButton3.Checked) st = "BOOKED";
        else st = "Canceled";
        List<Process.reservation> rtem = new List<Process.reservation>();
        if(st.Equals("All"))
        {
            foreach(Process.reservation temp in res)
            {
                if (temp.us.Equals(Session["user"].ToString().TrimEnd()))
                    rtem.Add(temp);
            }

        }
        else
        {
            foreach (Process.reservation temp in res)
            {
                if (temp.us.Equals(Session["user"].ToString().TrimEnd()) && temp.st.TrimEnd().ToUpper().Equals(st))
                    rtem.Add(temp);
            }

        }
        table(rtem);
    }



    protected void table(List<Process.reservation> rtemp)
    {
        int i = 0;
        foreach (Process.reservation temp in rtemp)
        {
            TableRow row = new TableRow();
            row.Height = 25;
            if (i % 2 == 0)
                row.BackColor = System.Drawing.Color.White;
            else
                row.BackColor = System.Drawing.Color.Silver;
            i++;

            TableCell check = new TableCell();
            RadioButton ch = new RadioButton();
            check.Controls.Add(ch);
            ch.GroupName = "c";
            check.BorderStyle = BorderStyle.Solid;
            check.HorizontalAlign = HorizontalAlign.Center;
            check.VerticalAlign = VerticalAlign.Middle;



            TableCell id = new TableCell();
            id.Text = temp.id.ToString();
            id.BorderStyle = BorderStyle.Solid;
            id.HorizontalAlign = HorizontalAlign.Center;
            id.VerticalAlign = VerticalAlign.Middle;

            TableCell fid = new TableCell();
            fid.Text = temp.fid.ToString();
            fid.BorderStyle = BorderStyle.Solid;
            fid.HorizontalAlign = HorizontalAlign.Center;
            fid.VerticalAlign = VerticalAlign.Middle;

            TableCell reg = new TableCell();
            reg.Text = temp.regno.ToString();
            reg.BorderStyle = BorderStyle.Solid;
            reg.HorizontalAlign = HorizontalAlign.Center;
            reg.VerticalAlign = VerticalAlign.Middle;

            TableCell chn = new TableCell();
            chn.Text = temp.chno.ToString();
            chn.BorderStyle = BorderStyle.Solid;
            chn.HorizontalAlign = HorizontalAlign.Center;
            chn.VerticalAlign = VerticalAlign.Middle;

            TableCell st = new TableCell();
            st.Text = temp.st.ToString();
            st.BorderStyle = BorderStyle.Solid;
            st.HorizontalAlign = HorizontalAlign.Center;
            st.VerticalAlign = VerticalAlign.Middle;

            TableCell car = new TableCell();
            car.Text = temp.cardno.ToString();
            car.BorderStyle = BorderStyle.Solid;
            car.HorizontalAlign = HorizontalAlign.Center;
            car.VerticalAlign = VerticalAlign.Middle;

            TableCell pr = new TableCell();
            pr.Text = temp.total.ToString();
            pr.BorderStyle = BorderStyle.Solid;
            pr.HorizontalAlign = HorizontalAlign.Center;
            pr.VerticalAlign = VerticalAlign.Middle;
            row.Cells.Add(check);
            row.Cells.Add(id);
            row.Cells.Add(fid);
//            row.Cells.Add(cos);
            row.Cells.Add(reg);
            row.Cells.Add(chn);
            row.Cells.Add(st);
            row.Cells.Add(car);
            row.Cells.Add(pr);
            Table1.Rows.Add(row);
        }
    }
    protected void changest(string newst)
    {
        Label3.Visible = false;
        int rid=0;
        bool flag=false;
        string st=" ";
        for (int i=1; i<Table1.Rows.Count;i++)
        {
            RadioButton ch = new RadioButton();
            ch = (RadioButton) Table1.Rows[i].Cells[0].Controls[0];
            if(ch.Checked)
            {
                rid = Int32.Parse(Table1.Rows[i].Cells[1].Text);
                st = Table1.Rows[i].Cells[5].Text;
                flag = true;
                continue;
            }
        }
        if(!flag)
        {
            Label3.Text = "Please select a reservation";
            Label3.Visible = true;
            return;
        }
        if(!st.TrimEnd().Equals("RESERVED"))
        {
            Label3.Text = "You can Book and Cancel, Reserved status";
            Label3.Visible = true;
            return;
        }

        Process pros = new Process();
        pros.changest(rid, newst);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        changest("BOOKED");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        changest("CANCELED");
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
       
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
     
    }
}