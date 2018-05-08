<%@ Page Title="" Language="C#" MasterPageFile="~/student.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body style="background-color:darkgray">
 <% Response.WriteFile("homepage.aspx"); %>
    <form id="Form1" runat="server">
     <center> <h2> User Registration Form </h2> </center>
       <h3> Enter Your Details to Update</h3>
          <asp:TextBox ID="fname" runat="server" placeholder="First Name" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="lname" runat="server" placeholder="Last Name" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="uname" runat="server" placeholder="User Name" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="pass" runat="server" placeholder="Password" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="cpass" runat="server" placeholder="Cofirm Password" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="mobile" runat="server" placeholder="Mobile" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="email" runat="server" placeholder="Email" CssClass="a"></asp:TextBox><br />
             Role:<asp:DropDownList ID="role" runat="server" CssClass="a">
              <asp:ListItem Value="student">Student</asp:ListItem>
              <asp:ListItem Value="staff">Staff</asp:ListItem>
          </asp:DropDownList><br />
	   Gender:<asp:DropDownList ID="gender" runat="server" CssClass="a">
              <asp:ListItem Value="male">Male</asp:ListItem>
              <asp:ListItem Value="female">Female</asp:ListItem>
          </asp:DropDownList><br />
          <asp:TextBox ID="place" runat="server" placeholder="Place" CssClass="a"></asp:TextBox><br />
          <asp:Button ID="submit" runat="server" Text="Submit" OnClick="k_Click" CssClass="k" /> 
           </form>
</body>
</html>

</asp:Content>

