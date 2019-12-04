<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="display_item.aspx.cs" Inherits="user_display_item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="Server">


    
    <asp:Repeater id="d1" runat="server">               <%--display a repeated list of items--%>
         <HeaderTemplate>                               <%--the header template--%>  
           <ul>                                         <%--unordered list--%>
       </HeaderTemplate>                                <%--end of the header template--%>
         <ItemTemplate>                                 <%--display the field values of a record--%>
                <li class="product">                    <%--list item--%>
        <%--hyperlink connected to product description page which takes the id from the selected product--%>
                    <a href="product_desc.aspx?id=<%#Eval("IDProd") %>">  
                        <img src="../<%#Eval("ProdImg") %>" alt="" /></a>  <%--image source from table product--%>
                    <div class="product-info">                              <%--division with css class--%>
                        <h3><%#Eval("ProdName") %></h3>                     <%--header of product name --%>
                        <div class="product-desc">                          <%--division with css class--%>
                            <h4>Available quantity:<%#Eval("ProdQty") %></h4> <%--header of product quantity --%>
                            <p><%#Eval("ProdDesc") %></p>           <%--paragraph with product description--%>
                            <strong class="price">$<%#Eval("ProdPrice") %></strong><%--product price with bold weight--%></div>                            <%--end of the division--%>
                    </div>                                <%--end of the division--%>
                </li>                                     <%--end of the list item--%>          
        </ItemTemplate>                                   <%--end of the Item Template--%>
         <FooterTemplate>                                 <%--Footer template--%>
            </ul>                                         <%--end of the unordered list--%>
        </FooterTemplate>                                 <%--end of the Footer template--%>
    </asp:Repeater>                                       <%--end of the Repeater--%>




</asp:Content>

