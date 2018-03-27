<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_Conditional_Radio_Button.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="GroupPreference" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" GroupName="GroupPreference" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="GroupPreference" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="GroupPreference" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" />
            <br />
            <br />
            <asp:Image ID="outputImage" runat="server" />
            <br />
            <br />
            <asp:Label ID="outputLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
