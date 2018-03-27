<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BobsPizza.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="page-header">
                <h1>Papa Bob&#39;s Pizza</h1>
            </div>

             <div class="form-group">
                 <label>Size:</label>
                <asp:DropDownList ID="sizeDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="sizeDropDownList_SelectedIndexChanged" CssClass="form-control text-primary">
                    <asp:ListItem Value="Small">Small (12 inch - $12)</asp:ListItem>
                    <asp:ListItem Value="Medium">Medium (14 inch - $14)</asp:ListItem>
                    <asp:ListItem Value="Large">Large (16 inch - $16)</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                 <label>Crust:</label>
                <asp:DropDownList ID="crustDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="crustDropDownList_SelectedIndexChanged" CssClass="form-control text-primary">
                    <asp:ListItem Value="Regular">Regular</asp:ListItem>
                    <asp:ListItem Value="Thin">Thin</asp:ListItem>
                    <asp:ListItem Value="Thick">Thick (+ $2)</asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:CheckBox ID="sausageCheckBox" runat="server" Text="Sausage" AutoPostBack="True" OnCheckedChanged="sausageCheckBox_CheckedChanged" />
            <br />
            <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni" AutoPostBack="True" OnCheckedChanged="pepperoniCheckBox_CheckedChanged" />
            <br />
            <asp:CheckBox ID="onionCheckBox" runat="server" Text="Onion" AutoPostBack="True" OnCheckedChanged="onionCheckBox_CheckedChanged" />
            <br />
            <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers" AutoPostBack="True" OnCheckedChanged="greenPeppersCheckBox_CheckedChanged" />
            
            
            <h3>Deliver To:</h3>
            
            <div class="form-group">
                <label>Name:</label>
                <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                Address:
                <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                Zip:
                <asp:TextBox ID="zipTextBox" runat="server"  CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                Phone:
                <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <h3>Payment:</h3>
            <p>
                <asp:RadioButtonList ID="paymentOptionsRadioButtonList" runat="server">
                    <asp:ListItem Selected="True" Value="cashRadioButton">Cash</asp:ListItem>
                    <asp:ListItem Value="creditRadioButton">Credit</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <div>
                <asp:Button ID="orderButton" runat="server" Text="Order" OnClick="orderButton_Click" CssClass="btn-lg btn-primary" />
            </div>
            <div class ="form-group">
                <br />
                <asp:Label ID="exceptionLabel" runat="server" CssClass="bg-danger"></asp:Label>
            </div>

            <h3>Total Cost:
                <asp:Label ID="outputLabel" runat="server"></asp:Label>
            </h3>
            <p>&nbsp;</p>
        </div>
    </form>

    <script src="Scripts/jquery-3.2.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
