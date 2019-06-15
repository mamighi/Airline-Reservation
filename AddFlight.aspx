<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AddFlight.aspx.cs" Inherits="AddFlight" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <section id="content" class="auto-style6"><div class="ic"></div>
            <div class="content-bg">
                <div class="main">
                     Flight Number:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="128px"></asp:TextBox>
        <br />
        <br />
        Departure Date:&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Date" Width="128px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;<br />
        <br />
        Departure Time:
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Time" Width="128px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Invalid" Visible="False"></asp:Label>
        <br />
        <br />
        Arrival Date:&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server" TextMode="Date" Width="128px"></asp:TextBox>
        &nbsp;<br />
        <br />
        Arrival Time:
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Time" Width="128px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Invalid" Visible="False"></asp:Label>
        <br />
        <br />
                     Regular
        Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server" TextMode="Number" Width="53px"></asp:TextBox>
        &nbsp;RM&nbsp;
        <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="Invalid" Visible="False"></asp:Label>
                     <br />
                     <br />
                     Child
        Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox11" runat="server" TextMode="Number" Width="53px"></asp:TextBox>
        &nbsp;RM&nbsp;
        <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="Invalid" Visible="False"></asp:Label>
        <br />
        <br />
        Departure Location:&nbsp;
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        <br />
        Arrival Location:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <br />
        Plane Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Width="131px">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Insert all requierd information" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Add" Width="129px" BackColor="#0066CC" BorderStyle="None" Font-Bold="True" ForeColor="White" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Text="Clear" Width="129px" BackColor="#0066CC" Font-Bold="True" ForeColor="White" />



                    </div>
                </div>
           </section>
</asp:Content>

