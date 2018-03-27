<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Simple_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <span class="auto-style1">First Value: </span>&nbsp;<asp:TextBox ID="value1" runat="server" CssClass="auto-style1" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br class="auto-style1" />
            <span class="auto-style1">Second Value:&nbsp; </span>
            <asp:TextBox ID="value2" runat="server" CssClass="auto-style1"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;
            <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
            <br />
            <br />
            <asp:Label ID="outputLabel" runat="server" BackColor="#0099FF" Font-Bold="True" Font-Size="Large"></asp:Label>
        </div>
    </form>
</body>
</html>
