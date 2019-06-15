<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AddPlane.aspx.cs" Inherits="AddPlane" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            left: 0px;
            top: 0px;
            height: 403px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <section id="content"><div class="ic"></div>
            <div class="content-bg">
                <div class="main">
                    <br />
                    <br />
                    Plane Name:
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Plane Model :
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Please Fill All Requeird Information" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add" Width="134px" BackColor="#0066CC" BorderStyle="None" ForeColor="White" />
                    &nbsp;<asp:Button ID="Button3" runat="server" Text="Clear" Width="134px" BackColor="#0066CC" BorderStyle="None" ForeColor="White" />



                    </div>
                </div>
         </section>
</asp:Content>

