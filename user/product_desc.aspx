<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="product_desc.aspx.cs" Inherits="user_product_desc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="Server">
  

    <asp:Repeater ID="d1" runat="server">

        <HeaderTemplate>
        </HeaderTemplate>



        <ItemTemplate>
            <div style="height: 300px; width: 560px; border-style: solid; border-width: 1px;">

                <div style="height: 295px; width: 200px; float: left; border-style: solid; border-width: 1px;">
                <img src="../<%#Eval("ProdImg") %>" alt="" height="290" width="190" />
                </div>
                <div style="color: #7a7c7f; font-size: 20px;  line-height: 45px; text-align: center; text-shadow: 0 1px 1px #fff; padding-top: 20px;  height: 275px; width: 340px; float: left; border-style: solid; border-width: 1px;">
                    &nbsp;Item name:<%#Eval("ProdName") %><br />&nbsp;Description:<%#Eval("ProdDesc") %><br />&nbsp;Price:$<%#Eval("ProdPrice") %><br />&nbsp;Available quantity:<%#Eval("ProdQty") %></div>
    </div>
        </ItemTemplate>



        <FooterTemplate>
        </FooterTemplate>

    </asp:Repeater>
    <br />
    
    <table>
        <tr>
            <td><asp:Label ID="l2" runat="server" Text="Enter Quantity"></asp:Label></td>
             <td><asp:textbox ID="t1" runat="server">1</asp:textbox></td>
            
        </tr>

        <tr>
            <td colspan="3">
                <asp:Label ID="l1" runat="server" ForeColor="Red" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    
    
    <div style="margin-left:0" >
    <asp:Button ID="b2" runat="server" style="background-color: white; color: black;  border: 2px solid #4CAF50;background-color: #4CAF50; color: white;font-size: 25px;padding: 11px 70px;"  text="<<" OnClick="b2_Click"/>
    &nbsp;
    <asp:Button ID="btnAddToCart" runat="server" style="background-color: white; color: black; border: 2px solid #008CBA;background-color: #008CBA;color: white;font-size: 20px;padding: 14px 40px;" text="Add to Cart" OnClick="btnAddToCart_Click"/>
        </div>
    <br /><br />
    
    <%--show comments--%>
    <p>Comments</p>
    <asp:Repeater id="rcom" runat="server">
        
        <ItemTemplate>
        <hr />  
        <asp:Label ID="Label3" runat="server" Text='<%#Eval("name")%>'></asp:Label> 
        <asp:Label ID="Label4" runat="server" Text='<%#Eval("time")%>' ></asp:Label> <br />
        
        <div runat="server" innerText='<%#Eval("com")%>'></div>
            <hr /> 
        </ItemTemplate>
    </asp:Repeater>
    <br /><br />
    <%--add comment--%>
    <div style="margin-left:0" >
        <asp:Label ID="Label1" runat="server" Text="Name" ></asp:Label>
        <asp:textbox ID="tname" runat="server" style="margin: 0px 0px 0px 30px;" Width="179px"></asp:textbox>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Comment"></asp:Label>
        <asp:textbox ID="tcom" runat="server" TextMode="MultiLine" Height="49px" Width="184px"></asp:textbox> <br />
        <asp:Button ID="btncom" runat="server" style="background-color: white; color: black; border: 2px solid #008CBA;background-color: #008cba;color: white;font-size: 15px;padding: 5px 10px;" text="Add comment"  Height="38px" Width="162px" OnClick="btncom_Click"/>
        </div>
</asp:Content>

