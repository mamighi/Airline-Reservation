<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ReservationHistory.aspx.cs" Inherits="ReservationHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <section id="content"><div class="ic"></div>
            <div class="content-bg">
                <div class="main">
                    <div style="width:100%; height:100px">

                        <br />
                        &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Status: "></asp:Label>
                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Checked="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="All" OnCheckedChanged="RadioButton1_CheckedChanged" />
&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="Reserved" OnCheckedChanged="RadioButton2_CheckedChanged" />
&nbsp;
                        <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="Booked" OnCheckedChanged="RadioButton3_CheckedChanged" />
&nbsp;
                        <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="Canceled" OnCheckedChanged="RadioButton4_CheckedChanged" />
&nbsp;<br />
                        <br />
&nbsp;
                        <asp:Button ID="Button2" runat="server" BackColor="#0066CC" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Book" Width="109px" OnClick="Button2_Click" />
                    &nbsp;<asp:Button ID="Button1" runat="server" BackColor="#0066CC" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Cancel" Width="109px" OnClick="Button1_Click" />
                    &nbsp;
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
                    </div>
                    <div style="width:100%; height:300px">

                        <asp:Table ID="Table1" runat="server" CellPadding="1" CellSpacing="1" Width="100%" BorderColor="White" BorderStyle="Solid" GridLines="Vertical">
                            <asp:TableRow runat="server" BackColor="#0066CC" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="40px" HorizontalAlign="Center" VerticalAlign="Middle">
                                <asp:TableCell runat="server"></asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">ID</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Flight Number</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Regular Ticket</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Child Ticket</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Status</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Card Number</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Price</asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                    </div>

                    </div>
                </div>
           </section>
</asp:Content>

