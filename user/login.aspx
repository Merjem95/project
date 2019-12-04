<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="user_MyAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

    

    
    <%--division with inline css--%> 
<div style="border-style:solid;border-color:ButtonFace;margin:50px 423px 0px 36px;background-color:#fabb4863;">
    <br /> <%--break--%>
  <h2>Login</h2>        <%--header login--%>
    <br />  <%--break--%>

  <label>E-mail <span>*</span></label>  <%--label email--%>
   <%-- textbox named t1 for email--%>
  <asp:TextBox ID="t1" runat="server" style="margin-left:17px;"></asp:TextBox> 
    <br /> <br />   <%--break--%>
    <%--label password--%>
  <label>Password <span>*</span></label>
    <%-- textbox named t2 for password--%>
  <asp:TextBox ID="t2" runat="server" TextMode="Password"></asp:TextBox>
 <br /><br />   <%--break--%>
   <%--with clicking the button login it must select from table my account where email and password must match textboxes t1 and t2--%>
  <asp:Button ID="b1" runat="server" Text="Login" OnClick="b1_Click" Height="37px" Width="86px" style="margin-left:80px;" />
    <br />  <%--break--%>
    <asp:Label ID="l1" runat="server" Text=""></asp:Label> <%--if the condition is true it will show message: "Data is found"--%>
    <br />  <%--break--%>

    </div>  <%--end of the division --%> 


</asp:Content>

