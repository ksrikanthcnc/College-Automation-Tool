<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
    
    
    
    <style type="text/css">
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            width: 1069px;
        }
        .auto-style4 {
            height: 449px;
        }
        .auto-style5 {
            width: 1150px;
            height: 449px;
            border: 3px ridge #C0C0C0;
        }
    </style>
    
    
    
</head>

    <body >
 <% Response.WriteFile("homepage.aspx"); %>
        <table><tr>
            <td class="auto-style4">
        <form runat="server">
            <h3 class="auto-style2">Login..</h3>
        <asp:TextBox ID="uname" runat="server" CssClass="a" placeholder="User Name"></asp:TextBox><br />
        <asp:TextBox ID="password" runat="server" CssClass="a" placeholder="Password"></asp:TextBox><br />
        <asp:Button ID="submit" runat="server" CssClass="k" Text="Submit" OnClick="submit_Click" />
            </form></td>
            <td class="auto-style5" style="vertical-align:top;">
                <h3>
                    NEWS....
                </h3>
                <p>
                    <a href="https://ragam.org.in/">**Ragam 2017:Annual inter college fest.
                        Ragam blends a series of fine-arts,socio-cultural and literary events,along with a variety of workshops,
                        exhibitions.</a></p>
                <p>
                    <a href="http://www.tathva.org/tathva.org/tathva16/Website/Main/index.php">**Tathva 2017:Tathva is an annual techno-management festival, It is one of the biggest technical festivals
                     in South India.&nbsp; Aimed at inspiring innovation, technical interest among students, 
                    and awareness among the public, the event hosts lectures, seminars, workshops, competitions,
                     paper presentations, exhibitions, quizzes, model displays and robotics events.</a></p>
                <p>
                    &nbsp;</p>
            </td>
               </tr>
        </table>
        
</body>

</html>
