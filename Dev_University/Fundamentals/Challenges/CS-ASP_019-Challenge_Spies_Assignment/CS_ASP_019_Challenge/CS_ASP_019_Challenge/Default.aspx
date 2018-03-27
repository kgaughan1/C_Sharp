<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_019_Challenge.Default" MaintainScrollPositionOnPostback = "true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        <h1>Spy New Assignment Form</h1>
        <p>
            Spy Code Name:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:</p>
        <p>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="outputLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
