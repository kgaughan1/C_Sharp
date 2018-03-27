

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalDbExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:GridView ID="customersGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="customersGridView_RowCommand">
            <Columns>
                <asp:ButtonField Text="View" />
                <asp:BoundField DataField="Make" HeaderText="Make" />
                <asp:BoundField DataField="Model" HeaderText="Model" />
                <asp:BoundField DataField="Year" HeaderText="Year" />
                <asp:BoundField DataField="CarID" HeaderText="Car ID" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" ReadOnly="True" SortExpression="CustomerId" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
        <br />
        <br />

    </div>
        <asp:Label ID="outputLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
