<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="display_orders.aspx.cs" Inherits="user_display_orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

    <asp:Repeater id="r1" runat="server">               <%--display a repeated list of items--%>
         <HeaderTemplate>                               <%--the header template--%>  
           <table>     
               <tr style="background-color:gray;color:white;">
              <td>id</td>
               <td>firstname</td>
               <td>lastname</td> 
               <td>city</td>
               <td>state</td>
               <td>pincode</td>
                   <td>view ful order</td>
               </tr>                                   <%--unordered list--%>
       </HeaderTemplate>                                <%--end of the header template--%>
         <ItemTemplate> 
             <tr>
               <td><%#Eval("id") %></td>
               <td><%#Eval("firstname") %></td> 
               <td><%#Eval("lastname") %></td>
               <td><%#Eval("city") %></td>
               <td><%#Eval("state") %></td>
                 <td><%#Eval("pincode") %></td>
                 <td><a href="view_full_order.aspx?id=<%#Eval("id") %>">view ful order</a></td>
               </tr>                                   
                                             
        </ItemTemplate>                                   <%--end of the Item Template--%>
         <FooterTemplate>                                 <%--Footer template--%>
             </table>                                      <%--end of the unordered list--%>
        </FooterTemplate>                                 <%--end of the Footer template--%>
    </asp:Repeater>    

</asp:Content>

