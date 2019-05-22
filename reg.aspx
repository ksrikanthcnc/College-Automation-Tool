<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="reg" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:darkgray">
 <% Response.WriteFile("homepage.aspx"); %>
    <table><tr><td>
                Registerhere

               </td>
        <td>
    <form runat="server">
     <center> <h2> User Registration Form </h2> </center>
       <h3> Enter Your Details </h3>
          <asp:TextBox ID="fname" CssClass="a" runat="server" placeholder="First Name"></asp:TextBox><br />
          <asp:TextBox ID="lname" CssClass="a" runat="server" placeholder="Last Name"></asp:TextBox><br />
          <asp:TextBox ID="uname"  CssClass="a" runat="server" placeholder="User Name"></asp:TextBox><br />
          <asp:TextBox ID="pass" type="password" CssClass="a" runat="server" placeholder="Password"></asp:TextBox><br />
          <asp:TextBox ID="cpass" type="password" CssClass="a" runat="server" placeholder="Cofirm Password"></asp:TextBox><br />
          <asp:TextBox ID="mobile" CssClass="a" runat="server" placeholder="Mobile"></asp:TextBox><br />
          <asp:TextBox ID="email" runat="server" CssClass="a"  placeholder="Email"></asp:TextBox><br />
             <asp:DropDownList ID="role" runat="server" CssClass="a" >
              <asp:ListItem Value="">Role</asp:ListItem>
              <asp:ListItem Value="student">Student</asp:ListItem>
              <asp:ListItem Value="staff">Staff</asp:ListItem>
          </asp:DropDownList><br />
	   <asp:DropDownList ID="gender" runat="server" CssClass="a" >
              <asp:ListItem Value="">gender</asp:ListItem>
              <asp:ListItem Value="male">Male</asp:ListItem>
              <asp:ListItem Value="female">Female</asp:ListItem>
          </asp:DropDownList><br />
          <asp:TextBox ID="place" runat="server" placeholder="Place" CssClass="a" ></asp:TextBox><br />
          <asp:Button ID="submit" runat="server" Text="Submit" OnClick="k_Click"  CssClass="k" /> 
        </td>
        </tr>
           </form>
        </tr>
        </table>
</body>
</html>
