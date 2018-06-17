<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" Trace="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table width="700px" height="600px" align="center" style="background-color:White" >
    <tr style="height:50px">
       <td> <div class="header">Administrare biblioteca</div></td>
    </tr>
    <tr>
     <td valign="top" align="center">
      <h2>Login </h2>
       <table>
       <tr>
       <td>Nume utilizator : </td>
         <td>
            <asp:TextBox ID="txtUtilizator" runat="server" Width="150px"></asp:TextBox>
           </td>
       </tr>
       <tr>
       <td> Parola : </td>
       <td>
           <asp:TextBox ID="txtParola" runat="server" Width="150px" TextMode="Password"></asp:TextBox></td>
       </tr>
     </table>
     <p />
        <asp:Button ID="btnAutentificare" runat="server" Text="Login" onclick="btnAutentificare_Click" />
        <p />
        <asp:Label ID="lblMsg" runat="server" EnableViewState = "false"
            Text=""></asp:Label>
      </td>
    </tr>    
    </table>
    </form>
</body>
</html>
