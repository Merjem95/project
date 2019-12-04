<%@ Page Title="" Language="C#" MasterPageFile="~/user/admin/admin.master" AutoEventWireup="true" CodeFile="add_product.aspx.cs" Inherits="admin_add_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="Server">
       <h3>Add Product</h3> <%--header with text Add Product--%>
           <table> <%--table tag created for adding products--%>
            <tr> <%--table row--%>
            <td>Product name</td> <%--table data inside the table row--%>
            <td> <asp:TextBox ID="t1" runat="server"></asp:TextBox></td> <%--textbox created for writing the product name--%>
            </tr>   <%--end of table row--%>
        <tr>    <%--table row--%>
            <td>Product description</td> <%--table data inside the table row--%>
            <td> <asp:TextBox ID="t2" runat="server"></asp:TextBox></td><%--textbox created for writing the product description--%>
        </tr>   <%--end of table row--%>
        <tr>    <%--table row--%>
            <td>Product price</td> <%--table data inside the table row--%>
            <td> <asp:TextBox ID="t3" runat="server"></asp:TextBox></td><%--textbox created for writing the product price--%>
        </tr>   <%--end of table row--%>
        <tr>    <%--table row--%>
            <td>Product quantity</td> <%--table data inside the table row--%>
            <td> <asp:textbox ID="t4" runat="server"></asp:textbox></td><%--textbox created for writing the product quantity--%>
        </tr>   <%--end of table row--%>
        <tr>    <%--table row--%>
            <td>Product image <%--table data inside the table row--%>
             <asp:FileUpload ID="f1" runat="server"/> 
                <br />
            </td><%--fileupload created for uploading the product image from your files--%>
            </tr>
            <br />
               <tr>
            <td>Add Category<asp:DropDownList ID="ddl" runat="server"  OnSelectedIndexChanged="ddl_SelectedIndexChanged" >
                <asp:ListItem>Woman_Category</asp:ListItem>
                <asp:ListItem>Man_Category</asp:ListItem>
                <asp:ListItem>Bags_Shoes</asp:ListItem>
                <asp:ListItem>Jewelry_Watches</asp:ListItem>
                <asp:ListItem>Phones_Accessories</asp:ListItem>
                </asp:DropDownList>

            </td>
               <tr />
           <%--end of table row--%> 
         <tr>   <%--table row--%>
            <td colspan="2" align="center"> <%--table data inside the table row--%>
                <%--asp button created for uploading the records with the function b1_Click to our database--%>
                <asp:Button ID="b1" runat="server" Text="Upload" OnClick="b1_Click" Height="41px" Width="114px"/>
            </td>      <%--table data--%>        
        </tr>   <%--end of table row--%>
        </table>    <%--end of table--%>
</asp:Content>

