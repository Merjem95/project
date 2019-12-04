<%@ Page Title="" Language="C#" MasterPageFile="~/user/admin/admin.master" AutoEventWireup="true" CodeFile="view_full_order.aspx.cs" Inherits="user_admin_view_full_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
<asp:Repeater id="r2" runat="server">               <%--display a repeated list of items--%>
         <HeaderTemplate>                               <%--the header template--%>  
           <table>     
               <tr style="background-color:gray;color:white;">
              <td>id</td>
               <td>firstname</td>
               <td>lastname</td> 
               <td>email</td>
                   <td>address</td>
                   <td>city</td>
                   <td>state</td>
                   <td>pincode</td>
                   <td>mobile</td>
               </tr>                                   
       </HeaderTemplate>                                <%--end of the header template--%>
         <ItemTemplate> 
             <tr>
               
               <td><%#Eval("id") %></td> 
               <td><%#Eval("firstname") %></td>
                 <td><%#Eval("lastname") %></td>
                 <td><%#Eval("email") %></td> 
               <td><%#Eval("address") %></td>
                 <td><%#Eval("city") %></td>
                 <td><%#Eval("state") %></td> 
               <td><%#Eval("pincode") %></td>
                 <td><%#Eval("mobile") %></td>
               </tr>                                   
                                             
        </ItemTemplate>                                   <%--end of the Item Template--%>
         <FooterTemplate>                                 <%--Footer template--%>
             </table>                                      <%--end of the unordered list--%>
        </FooterTemplate>                                 <%--end of the Footer template--%>
    </asp:Repeater>    
    <br /><br />

<asp:Repeater id="r1" runat="server">               <%--display a repeated list of items--%>
         <HeaderTemplate>                               <%--the header template--%>  
           <table>     
               <tr style="background-color:gray;color:white;">
              <td>Product Image</td>
               <td>Product Name</td>
               <td>Product Price</td> 
               <td>Product Quantity</td>
               
               </tr>                                   
       </HeaderTemplate>                                <%--end of the header template--%>
         <ItemTemplate> 
             <tr>
               <td><img src="../<%#Eval("prod_img")%>" height="100" width="100"/></td>
               <td><%#Eval("prod_name") %></td> 
               <td><%#Eval("prod_price") %></td>
                 <td><%#Eval("prod_qty") %></td>
                 
               </tr>                                   
                                             
        </ItemTemplate>                                   <%--end of the Item Template--%>
         <FooterTemplate>                                 <%--Footer template--%>
             </table>                                      <%--end of the unordered list--%>
        </FooterTemplate>                                 <%--end of the Footer template--%>
    </asp:Repeater>    
    <asp:Label ID="l1" runat="server" Text=""></asp:Label>
</asp:Content>

