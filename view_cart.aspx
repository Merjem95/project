<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_cart.aspx.cs" Inherits="view_cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/mydesign.css" type="text/css" media="all" />
    <title>Cart</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div  class="table-responsive">
                <%--close button with clicking on it redirect us to the products page--%> 
                <asp:Button ID="btnclose" runat="server" Text="Close" OnClick="btnclose_Click"  /> 
                <br />
                <br />
                <asp:DataList ID="d1" runat="server">  <%--datalist connected to the database--%>
                    <HeaderTemplate>                   <%--the header template--%>
                        <table  style="border-spacing: 10px 0;" >          <%--table with style--%> 
                            <thead>                    <%--header of the table--%>
                                <tr style="background-color:#c0c0c03b;color:#171616cf;font-weight:bold;">                    <%--table row--%>
                                    <th>Product </th>   <%--table data header Product--%>
                                    <th>Name</th>       <%--table data header Name--%>
                                    <th>Description</th>  <%--table data header Description--%>
                                    <th>Price</th>          <%--table data header Price--%>
                                    <th>Quantity</th>       <%--table data header Quantity--%>
                                     <th>Delete</th>
                                </tr>                       <%--end of the table row--%>
                            </thead>                        <%--end of the header of the table--%>
                    </HeaderTemplate>                       <%--end of the header template--%>
                    <ItemTemplate>                          <%--display the field values of a record--%>
                        <tbody>                             <%-- body of the table--%>
                            <tr>                            <%--table row--%>
                                <%--table data with image source of the product from database--%>
                                <td><img src="../<%#Eval("ProdImg") %>" alt="" height="100" width="100" /></td>
                                <%--table data with Name of the product source from database--%>
                                <td><%#Eval("ProdName") %></td>
                                <%--table data with description of the product from database--%>
                                <td><%#Eval("ProdDesc") %></td>
                                <%--table data with price of the product from database--%>
                                <td>$<%#Eval("ProdPrice") %></td>
                                <%--table data with quantity of the product from database--%>
                                <td><%#Eval("ProdQty") %></td>
                                <%--delete hyperlink which takes the id from the producuct and delete it--%>
                                <td><a href="/user/delete_cart.aspx?id=<%#Eval("rowIndex") %>">delete </a></td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                    <FooterTemplate></table></FooterTemplate>
                </asp:DataList>
                <br />
                <p style="text-align:left">
                <asp:Label ID="l1" runat="server"></asp:Label>
                    <asp:Button id="btncheckout" runat="server" Text="checkout" OnClick="btncheckout_Click"/>
                    </p>
            </div>
        </div>
    </form>
</body>
</html>
