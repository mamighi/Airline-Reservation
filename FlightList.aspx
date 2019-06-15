<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="FlightList.aspx.cs" Inherits="FlightList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="content"><div class="ic"></div>
            <div class="content-bg">
                <div class="main">
                    <div style="width:100%; height:100px">

                        <br />
                        &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Status: "></asp:Label>
                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Checked="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="All" />
&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="Future" />
&nbsp;
                        <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="Past" />
&nbsp;
                        <br />
&nbsp;<br />
&nbsp;
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sold: "></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton6" runat="server" AutoPostBack="True" Checked="True" Font-Bold="True" Font-Size="Medium" GroupName="a" Text="All" />
&nbsp;
                        <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="a" Text="Sold Out" />
&nbsp;
                        <asp:RadioButton ID="RadioButton5" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="a" Text="Available" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" BackColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Cancel" Width="109px" OnClick="Button1_Click" />
                    &nbsp;<asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Text="Please chose a flight"></asp:Label>
                    </div>
                    <div style="width:100%; height:300px">

                        <asp:Table ID="Table1" runat="server" CellPadding="0" CellSpacing="2" Width="100%" BorderColor="White" BorderStyle="Ridge" GridLines="Vertical" HorizontalAlign="Center">
                            <asp:TableRow runat="server" BackColor="#0066CC" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="40px" HorizontalAlign="Center" VerticalAlign="Middle" TableSection="TableHeader">
                                <asp:TableCell runat="server" Width="5px" BorderStyle="Solid"></asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">ID</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Departure Time</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Departure Location</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Arrival Time</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Arrival Location</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" HorizontalAlign="Center" BorderStyle="Solid">Flight Number</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" HorizontalAlign="Center" BorderStyle="Solid">Regular Price</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" HorizontalAlign="Center" BorderStyle="Solid">Child Price</asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="Solid">Plane Id</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Availabel Seats</asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                    </div>

                    </div>
                </div>
           </section>


</asp:Content>

