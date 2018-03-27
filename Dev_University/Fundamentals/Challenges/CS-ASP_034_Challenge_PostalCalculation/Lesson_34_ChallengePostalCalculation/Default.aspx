<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lesson_34_ChallengePostalCalculation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator</div>
        <p>
            Width:&nbsp;
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            Height:&nbsp;
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            Length:&nbsp;
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="MethodGroup" OnCheckedChanged="groundRadioButton_CheckedChanged" Text="Ground" />
        </p>
        <p>
            <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="MethodGroup" OnCheckedChanged="airRadioButton_CheckedChanged" Text="Air" />
        </p>
        <p>
            <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" GroupName="MethodGroup" OnCheckedChanged="nextDayRadioButton_CheckedChanged" Text="Next Day" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
