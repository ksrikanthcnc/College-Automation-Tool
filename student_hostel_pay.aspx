<%@ Page Title="" Language="C#" MasterPageFile="~/student.master" AutoEventWireup="true" CodeFile="student_hostel_pay.aspx.cs" Inherits="student_hostel_pay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <form runat="server">
    
 
 
     <center> <h2>Fee Paymet Details</h2> </center>

       <h3> Enter Your Details </h3>
          <asp:TextBox ID="sem" runat="server" placeholder="Semester"></asp:TextBox>    <br />    
          <asp:TextBox ID="hostel" runat="server" placeholder="hostel"></asp:TextBox>    <br />    
          <asp:TextBox ID="amt" runat="server" placeholder="amount"></asp:TextBox>    <br />    
          <asp:TextBox ID="date" runat="server" placeholder="date"></asp:TextBox>    <br />    
                    <asp:TextBox ID="du" runat="server" placeholder="DUnumber"></asp:TextBox>    <br />
          <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
           
        </form>
</asp:Content>

