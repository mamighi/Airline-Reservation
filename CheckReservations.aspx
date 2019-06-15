<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="CheckReservations.aspx.cs" Inherits="CheckReservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <section id="content"><div class="ic"></div>
            <div class="content-bg">
                <div class="main">
                    <div style="width:100%; height:100px">

                        <br />
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="Flight Number: "></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="140px">
                        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Status: "></asp:Label>
                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Checked="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="All" />
&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="Reserved" />
&nbsp;
                        <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="Booked" />
&nbsp;
                        <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" GroupName="s" Text="Canceled" />
&nbsp;</div>
                    <div style="width:100%; height:300px">

                        <asp:Table ID="Table1" runat="server" CellPadding="1" CellSpacing="1" Width="100%" BorderColor="White" BorderStyle="Solid" GridLines="Vertical">
                            <asp:TableRow runat="server" BackColor="#0066CC" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="40px" HorizontalAlign="Center" VerticalAlign="Middle">
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">ID</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Flight Number</asp:TableCell>
                                <asp:TableCell runat="server" VerticalAlign="Middle" BorderStyle="Solid">Costumer</asp:TableCell>
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

