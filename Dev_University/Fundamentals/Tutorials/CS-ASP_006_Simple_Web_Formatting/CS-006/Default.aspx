<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
        .auto-style2 {
            background-color: #577DFF;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 265px;
        }
        .auto-style5 {
            background-color: #FFFF00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Head Line 1</h1>
            <h2>Head Line 2</h2>
            <h3>Head Line 3</h3>
            <h4>Head Line 4</h4>
            <h5>Head Line 5</h5>
            <h6>Head Line 6</h6>
        </div>
        <p style="font-family: Arial, Helvetica, sans-serif">
            This is some text I want to <span class="auto-style1">add </span><span class="auto-style2">style</span> to.</p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <a href="http://www.google.com">Add a hyperlink.</a></p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.reddit.com" Target="_blank">This is another hyperlink.</asp:HyperLink>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Emoticon.png" />
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            &nbsp;</p>
        <table class="auto-style3">
            <tr>
                <td class="auto-style4">Player</td>
                <td>Year</td>
                <td>Home Runs</td>
            </tr>
            <tr>
                <td class="auto-style4">Sammy Sosa</td>
                <td>2005</td>
                <td>100</td>
            </tr>
            <tr>
                <td class="auto-style4">Mark MacGuire</td>
                <td>2005</td>
                <td>102</td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <ol>
        <li>First Item</li>
        <li>Second Item</li>
        <li>Third Item</li>
    </ol>
    <p>
        &nbsp;</p>
    <ul>
        <li class="auto-style5">This is an idea</li>
        <li class="auto-style5">This is an equally good idea, yet one more idea.</li>
        <li class="auto-style5">No idea...</li>
    </ul>
    <p>
        &nbsp;</p>
</body>
</html>
