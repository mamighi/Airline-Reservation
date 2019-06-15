using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FlightList : System.Web.UI.Page
{
    List<Process.flight> fl;
    protected void Page_Load(object sender, EventArgs e)
    {
        

            getfilghts();
        generat();
    }
    protected void getfilghts()
    {
        Process pr= new Process();
        fl=pr.getflights();
    }

    protected void generat()
    {
        string status,sold;
        if (RadioButton1.Checked) status = "All";
        else if (RadioButton2.Checked) status = "Future";
        else status = "past";
        if (RadioButton6.Checked) sold = "All";
        else if (RadioButton4.Checked) sold = "Sold";
        else sold = "Ava";

        List<Process.flight> tfl = new List<Process.flight>();
        DateTime today = DateTime.Now;
        if(status.Equals("All") && sold.Equals("All"))
        {
            tfl = fl;
        }
        else if(status.Equals("All"))
        {
            if(sold.Equals("Sold"))
            {
                foreach(Process.flight temp in fl)
                {
                    if (temp.avseat == 0)
                        tfl.Add(temp);
                }
            }
            else
            {
                foreach (Process.flight temp in fl)
                {
                    if (temp.avseat > 0)
                        tfl.Add(temp);
                }
            }

        }

        else if (status.Equals("Future"))
        {
            if (sold.Equals("Sold"))
            {
                foreach (Process.flight temp in fl)
                {
                    if (temp.avseat == 0 && temp.depT>today)
                        tfl.Add(temp);
                }
            }
            else
            {
                foreach (Process.flight temp in fl)
                {
                    if (temp.avseat > 0 && temp.depT > today)
                        tfl.Add(temp);
                }
            }

        }
        else
        {
            if (sold.Equals("Sold"))
            {
                foreach (Process.flight temp in fl)
                {
                    if (temp.avseat == 0 && temp.depT < today)
                        tfl.Add(temp);
                }
            }
            else
            {
                foreach (Process.flight temp in fl)
                {
                    if (temp.avseat > 0 && temp.depT < today)
                        tfl.Add(temp);
                }
            }

        }
        table(tfl);
    }
    private void table(List<Process.flight> tfl)
    {
        int i=0;
        foreach (Process.flight temp in tfl)
        {
            TableRow row = new TableRow();
            row.Height = 25;
            if(i%2==0)
                row.BackColor=System.Drawing.Color.White;
            else
                row.BackColor=System.Drawing.Color.Silver;
            

            i++;
            TableCell check = new TableCell();
            RadioButton ch = new RadioButton();
            check.Controls.Add(ch);
            ch.GroupName = "c";
            check.BorderStyle = BorderStyle.Solid;
            check.HorizontalAlign = HorizontalAlign.Center;
            check.VerticalAlign = VerticalAlign.Middle;

            TableCell id = new TableCell();
            id.Text = temp.flightId.ToString();
            id.BorderStyle = BorderStyle.Solid;
            id.HorizontalAlign = HorizontalAlign.Center;
            id.VerticalAlign = VerticalAlign.Middle;

            TableCell dt = new TableCell();
            dt.Text = temp.depT.ToString();
            dt.BorderStyle = BorderStyle.Solid;
            dt.HorizontalAlign = HorizontalAlign.Center;
            dt.VerticalAlign = VerticalAlign.Middle;

            TableCell dl = new TableCell();
            dl.Text = temp.depl.ToString();
            dl.BorderStyle = BorderStyle.Solid;
            dl.HorizontalAlign = HorizontalAlign.Center;
            dl.VerticalAlign = VerticalAlign.Middle;

            TableCell at = new TableCell();
            at.Text = temp.arrT.ToString();
            at.BorderStyle = BorderStyle.Solid;
            at.HorizontalAlign = HorizontalAlign.Center;
            at.VerticalAlign = VerticalAlign.Middle;

            TableCell al = new TableCell();
            al.Text = temp.arrl.ToString();
            al.BorderStyle = BorderStyle.Solid;
            al.HorizontalAlign = HorizontalAlign.Center;
            al.VerticalAlign = VerticalAlign.Middle;

            TableCell fn = new TableCell();
            fn.Text = temp.flightno.ToString();
            fn.BorderStyle = BorderStyle.Solid;
            fn.HorizontalAlign = HorizontalAlign.Center;
            fn.VerticalAlign = VerticalAlign.Middle;

            TableCell reg = new TableCell();
            reg.Text = temp.regp.ToString();
            reg.BorderStyle = BorderStyle.Solid;
            reg.HorizontalAlign = HorizontalAlign.Center;
            reg.VerticalAlign = VerticalAlign.Middle;

            TableCell chp = new TableCell();
            chp.Text = temp.chp.ToString();
            chp.BorderStyle = BorderStyle.Solid;
            chp.HorizontalAlign = HorizontalAlign.Center;
            chp.VerticalAlign = VerticalAlign.Middle;

            TableCell pid = new TableCell();
            pid.Text = temp.planeid.ToString();
            pid.BorderStyle = BorderStyle.Solid;
            pid.HorizontalAlign = HorizontalAlign.Center;
            pid.VerticalAlign = VerticalAlign.Middle;

            TableCell av = new TableCell();
            av.Text = temp.avseat.ToString();
            av.BorderStyle = BorderStyle.Solid;
            av.HorizontalAlign = HorizontalAlign.Center;
            av.VerticalAlign = VerticalAlign.Middle;

            row.Cells.Add(check);
            row.Cells.Add(id);
            row.Cells.Add(dt);
            row.Cells.Add(dl);
            row.Cells.Add(at);
            row.Cells.Add(al);
            row.Cells.Add(fn);
            row.Cells.Add(reg);
            row.Cells.Add(chp);
            row.Cells.Add(pid);
            row.Cells.Add(av);
            Table1.Rows.Add(row);

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int fid=0;
        bool flag = false;
        for(int i=1; i< Table1.Rows.Count; i++)
        {
            RadioButton check= new RadioButton();
            check=(RadioButton) Table1.Rows[i].Cells[0].Controls[0];
            if(check.Checked)
            {
                fid=Int32.Parse(Table1.Rows[i].Cells[1].Text);
                flag=true;
                continue;
            }
        }
        if(!flag)
        {
            Label4.Visible=true;
            return;
        }
        Process pros = new Process();
        pros.cancelfl(fid);


    }
}