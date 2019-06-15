using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Process
/// </summary>
public class Process
{
    SqlConnection con;
    public class flight
    {
        public int flightId, planeid, avseat;
        public float regp, chp;
        public DateTime depT;
        public DateTime arrT;
        public string arrl, depl, flightno;
    }
    public class plane
    {
        public int id, seats;
        public string pname, pmodel;
    }
    public class reservation
    {
        public int id, fid, chno, regno;
        public string us, cardno,st;
        public float total;
    }
    public class user
    {
        public string usename, pass, fn, ln, ph, email, cn, ulev, gender;
    }
	public Process()
	{
		//
		// TODO: Add constructor logic here
		//
        con= new SqlConnection("Data Source=Mohammad\\mohammad;Initial Catalog=EasyJetOnline;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
       // con = new SqlConnection("Server=tcp:nbfy1nepov.database.windows.net,1433;Database=EasyJetOnline;User ID=m_amighi@nbfy1nepov;Password=Aemag51367;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
	}
    //===============account=======================

    public char login(string username,string password)
    {
        char result=' ';
        string command="SELECT * FROM [Users] WHERE UserName='"+username+"' AND Password='"+password+"'";
        SqlCommand com=new SqlCommand(command,con);
        con.Open();
        SqlDataReader reader;
        reader=com.ExecuteReader();
        if(!reader.Read())
            result='w';
        else
        {
            if(reader.GetString(7).TrimEnd().Equals("admin"))
                result='a';
            else
                result='u';
        }
      
        reader.Close();
        con.Close();
        return result;
    }
    public bool adduser(user us)
    {
        bool ret = true;
        string command = "SELECT * FROM [Users] WHERE UserName='" + us + "'";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        SqlDataReader reader = com.ExecuteReader();
        if(reader.Read())
        {
            reader.Close();
            con.Close();
            return false;
        }
        reader.Close();
        command = "INSERT INTO [Users] VALUES('" + us.usename + "','" + us.pass + "','" + us.fn + "','" + us.ln + "','" + us.ph + "','" + us.email + "','" + us.cn + "','" + us.ulev + "','" + us.gender + "')";
        com = new SqlCommand(command, con);
        com.ExecuteNonQuery();
        con.Close();
        return ret;
    }
    public string getcno(string us)
    {
        string cno="";
        string command = "Select * From [UserS] WHERE UserName='" + us + "'";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        SqlDataReader reader = com.ExecuteReader();
        if (reader.Read())
            cno = reader.GetString(6);
        reader.Close();
        con.Close();
        return cno;
    }
    //===================flights========================

    public void addFlight(flight fl)
    {
        string command = "INSERT INTO [Flight] (Dep_datetime,Arr_datetime,Dep_location,Arr_location,FlightNo,RegTicketPrice,ChTicketPrice,PlaneId,AvailableSeats) VALUES('" + fl.depT + "','" + fl.arrT + "','" + fl.depl + "','" + fl.arrl + "','" + fl.flightno + "','" + fl.regp + "','" + fl.chp + "','" + fl.planeid + "','" + fl.avseat + "')";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public List<flight> getflights()
    {
        List<flight> ret = new List<flight>();
        flight fl;
        string command = "SELECT * FROM [Flight]";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while(reader.Read())
        {
            fl = new flight();
            fl.flightId = reader.GetInt32(0);
            fl.depT = reader.GetDateTime(1);
            fl.arrT = reader.GetDateTime(2);
            fl.depl = reader.GetString(3);
            fl.arrl = reader.GetString(4);
            fl.flightno = reader.GetString(5);
            fl.regp = float.Parse(reader.GetValue(6).ToString());
            fl.chp = float.Parse(reader.GetValue(7).ToString());
            fl.planeid = reader.GetInt32(8);
            fl.avseat = reader.GetInt32(9);
            ret.Add(fl);
        }
        reader.Close();
        con.Close();
        return ret;
    }
    public void dedav(int num,int fid)
    {
        int av=0;
        string command = "SELECT * FROM [Flight] WHERE FlightId='"+fid+"'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
            av = reader.GetInt32(9);
        reader.Close();
        av=av-num;
        command = "UPDATE [Flight] SET AvailableSeats='" + av + "'";
        com = new SqlCommand(command, con);
        com.ExecuteNonQuery();
        con.Close();
    }
    public void cancelfl(int fid)
    {
        string command = "DELETE FROM [Flight] WHERE FlightId='" + fid + "'";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();

    }
    //==========================plane===================
    public void addplane(plane pl)
    {
        string command="INSERT INTO [Plane] (PlaneName,PlaneModel,SeatsNumber) VALUES('"+pl.pname+"','"+pl.pmodel+"','"+pl.seats+"')";
        SqlCommand com=new SqlCommand(command,con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public List<plane> getplane()
    {
        List<plane> ret = new List<plane>();
        plane pl;
        string command = "SELECT * FROM [Plane]";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while(reader.Read())
        {
            pl = new plane();
            pl.id = reader.GetInt32(0);
            pl.pname = reader.GetString(1);
            pl.pmodel = reader.GetString(2);
            pl.seats = reader.GetInt32(3);
            ret.Add(pl);
        }
        reader.Close();
        con.Close();
        return ret;
    }

    //====================reservation================================

    public void newResrvation(reservation res)
    {
        string command = "INSERT INTO [Reservation] (FlightNumber,UserName,RegTicketNo,ChTicketNo,Status,CardNumber,TotalPrice) VALUES('" + res.fid + "','" + res.us + "','" + res.regno + "','" + res.chno + "','" + res.st + "','" + res.cardno + "','" + res.total + "')";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public List<reservation> getReservation()
    {
        string command = "SELECT * FROM [Reservation]";
        List<reservation> ret = new List<reservation>();
        reservation res;
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader=com.ExecuteReader();
        while(reader.Read())
        {
            res = new reservation();
            res.id = reader.GetInt32(0);
            res.fid = reader.GetInt32(1);
            res.us = reader.GetString(2);
            res.regno = reader.GetInt32(3);
            res.chno = reader.GetInt32(4);
            res.st = reader.GetString(5);
            res.cardno = reader.GetString(6);
            res.total = float.Parse(reader.GetValue(7).ToString());
            ret.Add(res);
        }
        reader.Close();
        con.Close();
        return ret;
    }
    public int getLastResId()
    {
        string command = "SELECT * FROM [Reservation]";
        int ret=0;
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {

            ret = reader.GetInt32(0);
        }
        reader.Close();
        con.Close();
        return ret;
    }
    public void changest(int rid, string newst)
    {
        string command = "UPDATE [Reservation] SET Status='" + newst + "' WHERE ReservationId='" + rid + "'";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public string getOccSeats(int flightId)
    {
        string retVal = "";
        string command = "SELECT * FROM [Seats] WHERE FlightID='"+flightId+"'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            retVal += reader.GetString(3).TrimEnd()+",";
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public void addOccSeat(string seat,int flightId,int reservationId)
    {
        string[] se = seat.Split(',');
        con.Open();
        for (int i=0;i<se.Length;i++)
        {
            string command = "INSERT INTO [Seats] (FlightID,ResId,Seat) VALUES('" + flightId + "','" + reservationId + "','" + se[i] + "')";
            SqlCommand com = new SqlCommand(command, con);
          
            com.ExecuteNonQuery();
            
        }
        con.Close();

    }
}