<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            float: left;
            height: 441px;
            margin-left: 192px;
        }
        .auto-style6 {
            float: left;
            width: 220px;
            height: 470px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <asp:Panel ID="Panel1" runat="server" Height="514px" Width="100%" BackColor="White">
        <div style="margin-top:25px; " class="auto-style5">
            <div style="margin:0;color:blue;  line-height:40px; font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif" class="auto-style5">
                 <label for="Email">User Name:</label><br />
            
                 <label for="Password">Password:</label>
                <br />
                 <label for="Password2">Re-Password: </label><br />
                 <label for="fn">First Name:</label><br />
                 <label for="ln">Last Name:</label><br />
                   Email<label for="Day">:
                 </label>
                 <br />
                <label for="phone">Phone Number:</label>
                <br />
                 Gender:<br />
                 Card<label for="Employee"> Number:</label>

            </div>
            <div style="margin:0px; line-height:40px; " class="auto-style6">
                
                &nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<br /> &nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;
                <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Not Match" Visible="False"></asp:Label>
                <br />
&nbsp;<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;<br /> &nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<br /> &nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                &nbsp;<br /> &nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                &nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;<br /> &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Width="125px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                <br />
                &nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Please Fill All Fields Properly" Visible="False"></asp:Label>
                <br />
                &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" BackColor="#0066CC" BorderStyle="None" Font-Bold="True" ForeColor="White" Width="150px" />

            </div>




        </div>
        
                <script type="text/javascript">
                    $("#rEmployee").change(function () {
                        if ($("#rEmployee").attr("checked")) {
                            $('.e1').show(callback);
                            $('.e1').show(callback);

                        }
                        else {
                            $('.e1').hide(callback);
                            $('.e2').hide(callback);
                         
                        }
                    });
                </script>
    </asp:Panel>

</asp:Content>

