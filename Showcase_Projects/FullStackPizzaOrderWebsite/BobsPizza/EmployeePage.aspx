<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeePage.aspx.cs" Inherits="BobsPizza.EmployeePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="customersGridView" runat="server" AutoGenerateColumns="False" EmptyDataText="There are no data records to display." OnRowCommand="customersGridView_RowCommand">
                <Columns>
                    <asp:ButtonField Text="Complete" />
                    <asp:BoundField DataField="orderID" HeaderText="OrderID" />
                    <asp:BoundField DataField="size" HeaderText="Size" />
                    <asp:BoundField DataField="crust" HeaderText="Crust" />
                    <asp:BoundField DataField="sausage" HeaderText="Sausage" />
                    <asp:BoundField DataField="pepperoni" HeaderText="Pepperoni" />
                    <asp:BoundField DataField="onions" HeaderText="Onions" />
                    <asp:BoundField DataField="Green_Peppers" HeaderText="Green_Peppers" />
                    <asp:BoundField DataField="Total_Cost" HeaderText="Total_Cost" />
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="address" HeaderText="Address" />
                    <asp:BoundField DataField="zip" HeaderText="Zip" />
                    <asp:BoundField DataField="phone" HeaderText="Phone" />
                    <asp:BoundField DataField="Payment_Type" HeaderText="Payment_Type" />
                    <asp:BoundField DataField="completed" HeaderText="Completed" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
