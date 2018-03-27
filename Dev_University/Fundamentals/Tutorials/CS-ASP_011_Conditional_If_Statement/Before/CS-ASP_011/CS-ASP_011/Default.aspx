<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
        <br />
        <br />
        <asp:CheckBox ID="coolCheckBox" runat="server" OnCheckedChanged="coolCheckBox_CheckedChanged" Text="Are You Cool?" />
        <br />
        <br />
        <br />
        If you could only eat one food for the rest of your life, what would you choose?<br />
        <asp:RadioButton ID="pizzarb" runat="server" Checked="True" GroupName="FoodGroup" Text="Pizza" />
        <br />
        <asp:RadioButton ID="saladrb" runat="server" GroupName="FoodGroup" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Salad" />
        <br />
        <asp:RadioButton ID="pbajrb" runat="server" GroupName="FoodGroup" Text="PB&amp;J" />
        <br />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
