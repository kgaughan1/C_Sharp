<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_16_ChallengeDaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            How many days have elapsed?</p>
        <p>
            Choose one date:</p>
        <p>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>
            Choose a second date:</p>
        <p>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" />
        </p>
        <p>
            <asp:Label ID="outputLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
