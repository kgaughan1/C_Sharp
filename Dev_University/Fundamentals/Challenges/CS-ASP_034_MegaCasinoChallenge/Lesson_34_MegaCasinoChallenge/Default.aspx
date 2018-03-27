<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lesson_34_MegaCasinoChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" />
&nbsp;
            <asp:Image ID="Image2" runat="server" />
&nbsp;
            <asp:Image ID="Image3" runat="server" />
        </div>
        <p>
            Your Bet:&nbsp;&nbsp;
            <asp:TextBox ID="betTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull the Lever!" />
        </p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        Player&#39;s Money:&nbsp; $<asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry -x2 Your Bet<br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        HOWEVER... if there&#39;s even one BAR you win nothing!</form>
</body>
</html>
