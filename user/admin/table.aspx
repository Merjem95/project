<%@ Page Title="" Language="C#" MasterPageFile="~/user/admin/admin.master" AutoEventWireup="true" CodeFile="table.aspx.cs" Inherits="admin_testing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="Server">

    <style style="text/css">
        .hoverTable {
            width: 100%;
            border-collapse: collapse;
        }

            .hoverTable td {
                padding: 7px;
                border: #4e95f4 1px solid;
            }
            /* Define the default color for all the table rows */
            .hoverTable tr {
                background: #b8d1f3;
            }
                /* Define the hover highlight color for the table row */
                .hoverTable tr:hover {
                    background-color: #ffff99;
                }
    </style>

    <asp:Repeater ID="d1" runat="server" > <%--display a repeated list of items--%>
        <HeaderTemplate>                   <%--the header template--%>  
            <table class="hoverTable">     <%--table with css class "hoverTable"--%>
                <tr>                       <%--table row--%>
                    <td>ID</td>            <%--table data header ID--%>
                    <td>Product Name</td>  <%--table data header Product Name--%>
                    <td>Description</td>   <%--table data header Description--%>
                    <td>Price</td>         <%--table data header Price--%>
                    <td>Quantity</td>      <%--table data header Quantity--%>
                    <td>Delete</td>          <%--table data header Edit--%>
                </tr>                      <%--end of the table row--%>
        </HeaderTemplate>                  <%--end of the header template--%>  
        <ItemTemplate>                     <%--display the field values of a record--%>
            
            <tr>                                        <%--table row--%>
                <td><%#Eval("IDProd") %></td>           <%--table data with IDProd record of database--%>
                <td><%#Eval("ProdName") %></td>         <%--table data with IDProd record of database--%>
                <td><%#Eval("ProdDesc") %></td>         <%--table data with IDProd record of database--%>
                <td>$<%#Eval("ProdPrice") %></td>       <%--table data with IDProd record of database--%>
                <td><%#Eval("ProdQty") %></td>
                <td>
                    <a href="delete.aspx?id=<%#Eval("IDProd") %>">delete</a>
                </td>           <%--table data with IDProd record of database--%>               
            </tr>                        <%--end of the table row--%>   
        </ItemTemplate>                  <%--end of the Item Template--%>
        <FooterTemplate>                 <%--Footer template--%>
            </table>                     <%--end of the table row--%>
        </FooterTemplate>                <%--end of the Footer template--%>
    </asp:Repeater>                       <%--end of the Repeater--%>




    <%--<asp:GridView ID="G1" runat="server" AutoGenerateColumns="False" DataKeyNames="IDProd" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="IDProd" HeaderText="IDProd" InsertVisible="False" ReadOnly="True" SortExpression="IDProd" />
            <asp:BoundField DataField="ProdName" HeaderText="ProdName" SortExpression="ProdName" />
            <asp:BoundField DataField="ProdDesc" HeaderText="ProdDesc" SortExpression="ProdDesc" />
            <asp:BoundField DataField="ProdPrice" HeaderText="ProdPrice" SortExpression="ProdPrice" />
            <asp:BoundField DataField="ProdQty" HeaderText="ProdQty" SortExpression="ProdQty" />
            <asp:BoundField DataField="ProdImg" HeaderText="ProdImg" SortExpression="ProdImg" />
        </Columns>
    </asp:GridView>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:shopping %>" SelectCommand="SELECT * FROM [product]"></asp:SqlDataSource>--%>
</asp:Content>

