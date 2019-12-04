<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="user_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
     <link rel="stylesheet" href="css/reg.css"/>
   
    
   
</head>
<body>
<form id="frm" runat="server">
    <header>Registration</header> 
    <table >
  <tr>
    <td ><label>First Name</label></td>
   <td>
       <asp:TextBox ID="txt1" runat="server"   ></asp:TextBox>
   </td>
  </tr>

        <tr>
    <td ><label>Last Name</label></td>
   <td>
      <asp:TextBox ID="txt2" runat="server"  ></asp:TextBox>
   </td>
  </tr>
    
        <tr>
    <td ><label>Email</label></td>
   <td>
      <asp:TextBox ID="txt3" runat="server"  ></asp:TextBox>
   </td>
  </tr> 

         <tr>
    <td ><label>Password</label></td>
   <td>
      <asp:TextBox ID="txt4" runat="server" TextMode="Password"   ></asp:TextBox>
   </td>
  </tr> 

        <tr>
    <td ><label>Address</label></td>
   <td class="area">
      <asp:TextBox style="margin-left:20px;font-family: lato;font-size: 18px;text-align:center;border: 1px solid #ccc;" ID="txt5" runat="server" TextMode="MultiLine" Width="240px"   ></asp:TextBox>
   </td>
  </tr> 

        <tr>
    <td ><label>City</label></td>
   <td>
      <asp:TextBox ID="txt6" runat="server"  ></asp:TextBox>
   </td>
  </tr> 

        <tr>
    <td ><label>State</label></td>
   <td>
      <asp:TextBox ID="txt7" runat="server"   ></asp:TextBox>
   </td>
  </tr> 

        <tr>
    <td ><label>Pincode</label></td>
   <td>
      <asp:TextBox ID="txt8" runat="server"   ></asp:TextBox>
   </td>
  </tr>
        
        <tr>
    <td><label>Phone</label></td>
   <td>
      <asp:TextBox ID="txt9" runat="server"   ></asp:TextBox>
   </td>
  </tr>  

        <tr>
           
    <td style="white-space: nowrap" >      
        <asp:Button ID="btn1" runat="server" Text="Register" OnClick="btn1_Click" Width="100px" />                     
    </td>
         <td style="white-space: nowrap" >
             <asp:Button ID="btnClose" runat="server" Text="Close" OnClick="btnClose_Click" />

         </td>   
    </tr> 

        <tr>
          <td colspan="2" style="text-align:left">
                 <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
             </td>
        </tr>
        </table>
     </form>   
</body>
</html>
