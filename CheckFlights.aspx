<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CheckFlights.aspx.cs" Inherits="CheckFlights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .auto-style5 {
            font-size: medium;
        }
        .auto-style6 {
            font-size: x-large;
            color: #0066FF;
        }
        .auto-style7 {
            text-align: left
        }
        .auto-style8 {
            width: 100%;
            font-size: 0.8125em;
            line-height: 1.3846em;
            margin: 0 auto;
            padding: 0;
            background-color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager EnablePageMethods="true" ID="MainSM" runat="server" ScriptMode="Release" LoadScriptsBeforeUI="true"></asp:ScriptManager>

    <section id="content"><div class="ic"></div>
            <div class="content-bg">
                <div class="main">
                    <div style="width:100%; height:750px">
                        <div style="width:450px; height:400px; line-height:40px; float:left">
                        <div style="width:150px; height:400px; line-height:40px; float:left">


                            <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="Departure Location:"></asp:Label>
                            <br />
                            <asp:Label ID="Label2" runat="server" CssClass="auto-style5" Text="Arrival Location:"></asp:Label>
                            <br />
                            <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text="Adults:"></asp:Label>
                            <br />
                            <asp:Label ID="Label4" runat="server" CssClass="auto-style5" Text="Child:"></asp:Label>
                            <br />
                            <asp:Label ID="Label5" runat="server" CssClass="auto-style5" Text="Departure DateTime:"></asp:Label>
                            <br />
                            <br />
                            <br />


                        </div>
                        <div style="width:300px; height:400px; line-height:40px; float:left">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList>
                            <br />
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            </asp:DropDownList>
                            <br />
                            <asp:DropDownList ID="DropDownList3" runat="server" Width="80px">
                                <asp:ListItem>0</asp:ListItem>
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <asp:DropDownList ID="DropDownList4" runat="server" Width="80px">
                                <asp:ListItem>0</asp:ListItem>
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <asp:ListBox ID="ListBox1" runat="server" Height="117px" Width="233px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
                            <br />
                            <asp:Label ID="Label18" runat="server" CssClass="auto-style5" Text="Please Select All Details" ForeColor="Red" Visible="False"></asp:Label>
                            <br />
                            <asp:Button ID="Button4" runat="server" Text="Confirm" OnClick="Button4_Click" BackColor="#3366CC" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="30px" Width="233px" />
                            
                            </div>
                            <div id="confirm" runat="server" style="width:350px; height:100%; line-height:40px; float:left" class="auto-style7">
                            <asp:Label ID="Label6" runat="server" CssClass="auto-style6" Text="DETAILS"></asp:Label>
                            <br />
                            <asp:Label ID="Label7" runat="server" CssClass="auto-style5" Text="Arrival Date And Time:"></asp:Label>
&nbsp;<asp:Label ID="Label13" runat="server" CssClass="auto-style5" Text="Arrival Date And Time:"></asp:Label>
                            <br />
                            <asp:Label ID="Label8" runat="server" CssClass="auto-style5" Text="Regular Ticket Price:"></asp:Label>
&nbsp;<asp:Label ID="Label14" runat="server" CssClass="auto-style5" Text="Regular Ticket Price:"></asp:Label>
                            <br />
                            <asp:Label ID="Label9" runat="server" CssClass="auto-style5" Text="Child Ticket Price:"></asp:Label>
&nbsp;<asp:Label ID="Label15" runat="server" CssClass="auto-style5" Text="Child Ticket Price:"></asp:Label>
                            <br />
                            <asp:Label ID="Label10" runat="server" CssClass="auto-style5" Text="Total Price:"></asp:Label>
&nbsp;<asp:Label ID="Label16" runat="server" CssClass="auto-style5" Text="Total Price:"></asp:Label>
                            <br />
                            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" CssClass="auto-style5" GroupName="R" Text="Book" OnCheckedChanged="RadioButton1_CheckedChanged" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" CssClass="auto-style5" GroupName="R" Text="Reserve" OnCheckedChanged="RadioButton2_CheckedChanged" Checked="True" />
                            <br />
                            <asp:Label ID="Label11" runat="server" CssClass="auto-style5" Visible="False">Card Number:</asp:Label>
&nbsp;<asp:Label ID="Label17" runat="server" CssClass="auto-style5" Visible="False">Card Number:</asp:Label>
&nbsp;<asp:Button ID="Button3" runat="server" Text="Other Card" OnClick="Button3_Click" Visible="False" BackColor="#0066CC" BorderStyle="None" Font-Bold="True" ForeColor="White" />
                            <br />
                            <asp:Label ID="Label12" runat="server" CssClass="auto-style5" Visible="False">Other Card:</asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="159px" Enabled="False" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:Button ID="Button2" runat="server" Text="Proceed" OnClick="Button2_Click" BackColor="#0066CC" BorderStyle="None" Font-Bold="True" ForeColor="White" Width="233px" />

                            <asp:HyperLink ID="HyperLink2" runat="server" Visible="False" NavigateUrl="SignUp.aspx" Font-Size="Medium">Sign Up</asp:HyperLink>
                     </div>
                        </div>
                        <div id="SEL" runat="server" style="width:350px; height:100%; line-height:40px; float:left">
                            <div class="plane">
                                 <p>Selected Seats: <input id="Text1" type="text" runat="server" /></p>
  <div class="exit exit--front fuselage">
    
  </div>
  
  <ol class="cabin fuselage" id="av"  runat="server">
    <li class="row row--1" id="av1"  runat="server">
      <ol class="seats" id="av2" type="A"  runat="server">
        <li class="seat" id="av3" runat="server">
            <input type="checkbox" id="1A" />
          <label for="1A">1A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="1B" />
          <label for="1B">1B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="1C" />
          <label for="1C">1C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="1D" />
          <label for="1D">1D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="1E" />
          <label for="1E">1E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="1F" />
          <label for="1F">1F</label>
        </li>
      </ol>
    </li>
    <li class="row row--2">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="2A" />
          <label for="2A">2A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="2B" />
          <label for="2B">2B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="2C" />
          <label for="2C">2C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="2D" />
          <label for="2D">2D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="2E" />
          <label for="2E">2E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="2F" />
          <label for="2F">2F</label>
        </li>
      </ol>
    </li>
    <li class="row row--3">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="3A" />
          <label for="3A">3A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="3B" />
          <label for="3B">3B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="3C" />
          <label for="3C">3C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="3D" />
          <label for="3D">3D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="3E" />
          <label for="3E">3E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="3F" />
          <label for="3F">3F</label>
        </li>
      </ol>
    </li>
    <li class="row row--4">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="4A" />
          <label for="4A">4A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="4B" />
          <label for="4B">4B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="4C" />
          <label for="4C">4C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="4D" />
          <label for="4D">4D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="4E" />
          <label for="4E">4E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="4F" />
          <label for="4F">4F</label>
        </li>
      </ol>
    </li>
    <li class="row row--5">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="5A" />
          <label for="5A">5A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="5B" />
          <label for="5B">5B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="5C" />
          <label for="5C">5C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="5D" />
          <label for="5D">5D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="5E" />
          <label for="5E">5E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="5F" />
          <label for="5F">5F</label>
        </li>
      </ol>
    </li>
    <li class="row row--6">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="6A" />
          <label for="6A">6A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="6B" />
          <label for="6B">6B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="6C" />
          <label for="6C">6C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="6D" />
          <label for="6D">6D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="6E" />
          <label for="6E">6E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="6F" />
          <label for="6F">6F</label>
        </li>
      </ol>
    </li>
    <li class="row row--7">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="7A" />
          <label for="7A">7A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="7B" />
          <label for="7B">7B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="7C" />
          <label for="7C">7C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="7D" />
          <label for="7D">7D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="7E" />
          <label for="7E">7E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="7F" />
          <label for="7F">7F</label>
        </li>
      </ol>
    </li>
    <li class="row row--8">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="8A" />
          <label for="8A">8A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="8B" />
          <label for="8B">8B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="8C" />
          <label for="8C">8C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="8D" />
          <label for="8D">8D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="8E" />
          <label for="8E">8E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="8F" />
          <label for="8F">8F</label>
        </li>
      </ol>
    </li>
    <li class="row row--9">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="9A" />
          <label for="9A">9A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="9B" />
          <label for="9B">9B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="9C" />
          <label for="9C">9C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="9D" />
          <label for="9D">9D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="9E" />
          <label for="9E">9E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="9F" />
          <label for="9F">9F</label>
        </li>
      </ol>
    </li>
    <li class="row row--10">
      <ol class="seats" type="A">
        <li class="seat">
          <input type="checkbox" id="10A" />
          <label for="10A">10A</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="10B" />
          <label for="10B">10B</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="10C" />
          <label for="10C">10C</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="10D" />
          <label for="10D">10D</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="10E" />
          <label for="10E">10E</label>
        </li>
        <li class="seat">
          <input type="checkbox" id="10F" />
          <label for="10F">10F</label>
        </li>
      </ol>
    </li>
  </ol>
  <div class="exit exit--back fuselage">
    
  </div>
</div>
                        </div>
                        
                    </div>
                     

                    </div>
                </div>
        </section>
    <script type="text/javascript">
        setonclick();
        function setonclick(){
            var inputs = document.getElementsByTagName('input');
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i].getAttribute('type') == 'checkbox') {
                    inputs[i].onclick = function () {
                        getSelected(this.id);
                    }
                }
            }
            
        }
        function set(ind)
        {
            var spl = ind.split(",");
            for(var i=0; i<spl.length;i++)
            {
                var a = document.getElementById(spl[i]);
                a.disabled = true;
            }
        }
        function setSelected(ind)
        {
            var spl = ind.split(",");
            for (var i = 0; i < spl.length; i++) {
                var a = document.getElementById(spl[i]);
                a.checked = true;
            }
        }
        function getSelected(id)
        {
            var myJsVar = "<%= number %>";
            var count = 0;
            var selected_ = "";
            var inputs = document.getElementsByTagName('input');
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i].getAttribute('type') == 'checkbox') {
                    if(inputs[i].checked==true)
                    {
                        count++;
                    }
                }
            }
            if(count>myJsVar)
            {
                var temp = document.getElementById(id);
                if (temp.checked == true) {
                    temp.checked = false;
                    alert("Please select only " + myJsVar + " seats.");
                }
            }
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i].getAttribute('type') == 'checkbox') {
                    if (inputs[i].checked == true) {
                        selected_ += inputs[i].id + ",";
                    }
                }
            }

            document.getElementById('<%= Text1.ClientID %>').setAttribute('value', selected_);
        }
    </script>
</asp:Content>

