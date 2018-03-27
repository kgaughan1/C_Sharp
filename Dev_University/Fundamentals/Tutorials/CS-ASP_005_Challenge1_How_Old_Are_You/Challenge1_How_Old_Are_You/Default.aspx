<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge1_How_Old_Are_You.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How old are you?&nbsp;
            <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            How much money do you have in your pocket?&nbsp;
            <asp:TextBox ID="moneyTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="clickButton" runat="server" Text="Click Me To See Your Fortune" Width="195px" OnClick="clickButton_Click" />
            <br />
            <br />
            <asp:Label ID="labelOutputFortune" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
