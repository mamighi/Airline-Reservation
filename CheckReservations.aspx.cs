using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckReservations : System.Web.UI.Page
{
    List<Process.reservation> res;
    List<Process.flight> fl;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            getRes();
        generate();
    }
    protected void getRes()
    {
        Process pros = new Process();
        res = new List<Process.reservation>();
        res = pros.getReservation();
        fl = pros.getflights();
        DropDownList1.Items.Add("All");
        foreach(Process.flight temp in fl)
        {
            DropDownList1.Items.Add(temp.flightno);
        }
    }
    protected void generate()
    {
        string status;
        if (RadioButton2.Checked) status = "Reserved";
        else if (RadioButton3.Checked) status = "Booked";
        else if (RadioButton4.Checked) status = "Canceled";
        else status = "All";

        try
        {
            if (DropDownList1.SelectedItem.ToString().Equals("All"))
            {
                if (RadioButton1.Checked)
                {
                    List<Process.reservation> rtemp = res;
                    table(rtemp);
                }
                else
                {
                    List<Process.reservation> rtemp = new List<Process.reservation>();
                    foreach (Process.reservation temp in res)
                    {
                        if (temp.st.Equals(status))
                            rtemp.Add(temp);
                    }
                    table(rtemp);
                }
            }
            else
            {
                if (status.Equals("All"))
                {
                    List<Process.reservation> rtemp = new List<Process.reservation>();
                    foreach (Process.reservation temp in res)
                    {
                        if (temp.fid == Int32.Parse(DropDownList1.SelectedItem.ToString()))
                            rtemp.Add(temp);
                    }
                    table(rtemp);
                }
                else
                {
                    List<Process.reservation> rtemp = new List<Process.reservation>();
                    foreach (Process.reservation temp in res)
                    {
                        if (temp.fid == Int32.Parse(DropDownList1.SelectedItem.ToString()) && temp.st.Equals(status))
                            rtemp.Add(temp);
                    }
                    table(rtemp);
                }
            }
        }
        catch (Exception ex) { }
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

            TableCell cos = new TableCell();
            cos.Text = temp.us;
            cos.BorderStyle = BorderStyle.Solid;
            cos.HorizontalAlign = HorizontalAlign.Center;
            cos.VerticalAlign = VerticalAlign.Middle;

            TableCell reg = new TableCell();
            reg.Text = temp.regno.ToString();
            reg.BorderStyle = BorderStyle.Solid;
            reg.HorizontalAlign = HorizontalAlign.Center;
            reg.VerticalAlign = VerticalAlign.Middle;

            TableCell ch = new TableCell();
            ch.Text = temp.chno.ToString();
            ch.BorderStyle = BorderStyle.Solid;
            ch.HorizontalAlign = HorizontalAlign.Center;
            ch.VerticalAlign = VerticalAlign.Middle;

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

            row.Cells.Add(id);
            row.Cells.Add(fid);
            row.Cells.Add(cos);
            row.Cells.Add(reg);
            row.Cells.Add(ch);
            row.Cells.Add(st);
            row.Cells.Add(car);
            row.Cells.Add(pr);
            Table1.Rows.Add(row);
        }
    }
}