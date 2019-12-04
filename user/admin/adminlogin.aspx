<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="admin_adminlogin" %>

<!DOCTYPE html> <%--document definition type--%>
<html>   <%--root of an HTML document--%>
  <head>   <%-- head-container for all the head elements--%>
    <meta charset="UTF-8">  <%--character encoding for the HTML document--%>
      <%--title of the page--%>
    <title>Admin Login</title>  
      <%--css style with attributes linked --%>
        <link rel="stylesheet" href="logincss/style.css">
  </head> <%--end of head tag--%>
  <body> <%--body-contains all the contents of an HTML document--%>
<%--the login form of admin--%>
<form id="f1" runat="server" style="margin:70px;"> <%--style of form: id "f1" and margin 70pixel--%>
  <header>Login</header>    <%--header title of the form login--%>
    <%--label and textbox for the username--%>
  <label>Username <span>*</span></label>    <%--label with text username--%>
  <asp:TextBox ID="t1" runat="server"></asp:TextBox> <%--asp textbox connexted to server with name "t1"--%>
  <%--label and textbox for the password--%>
  <label>Password <span>*</span></label>    <%--label with text Password--%>
    <%--asp textbox connexted to server with name "t2" and text mode hidden "password"--%>
  <asp:TextBox ID="t2" runat="server" TextMode="Password"></asp:TextBox> 
 <br />     <%--break--%>
    <%--Login button with clicking to b1_Click you go to c# code--%>
    <table style="width: 184px; height: 22px">
        <td>
  <asp:Button ID="b1" runat="server" Text="Login" OnClick="b1_Click" />
       
        </td>
        <td>
 <asp:Button ID="bClose" runat="server" Text="Close" OnClick="bClose_Click"/>
        </td>
        </table>
    <br />  <%--break--%>
    <%--label for warning if you don't write the valid username or password--%>
    <asp:Label ID="l1" runat="server" Text=""></asp:Label>
    <br />  <%--break--%>
</form> <%--end of the login form--%>
    
    
    
    
  </body>
</html>
