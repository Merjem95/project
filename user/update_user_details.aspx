<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="update_user_details.aspx.cs" Inherits="user_update_order_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

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
    <td ><label>Address</label></td>
   <td class="area">
      <asp:TextBox style="border: 1px solid #ccc;" ID="txt3" runat="server" TextMode="MultiLine" Width="240px" ></asp:TextBox>
   </td>
  </tr> 

        <tr>
    <td ><label>City</label></td>
   <td>
      <asp:TextBox ID="txt4" runat="server"  ></asp:TextBox>
   </td>
  </tr> 

        <tr>
    <td ><label>State</label></td>
   <td>
      <asp:TextBox ID="txt5" runat="server"   ></asp:TextBox>
   </td>
  </tr> 

         
        <tr>
    <td><label>Phone</label></td>
   <td>
      <asp:TextBox ID="txt6" runat="server"   ></asp:TextBox>
   </td>
  </tr>  


<tr>
           
    <td style="white-space: nowrap" >      
                         
    </td>
         <td style="white-space: nowrap" >


         </td>   
    </tr> 
</table>
    <asp:Button ID="btnUpdate" runat="server" Text="Update and continue"  Width="100px" OnClick="btnUpdate_Click" />    
                 <asp:Button ID="btnClose" runat="server" Text="Close" OnClick="btnClose_Click"  />
</asp:Content>

