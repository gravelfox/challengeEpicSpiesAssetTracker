<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="challengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 120px;
            height: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img class="auto-style1" src="epic-spies-logo.jpg" /></div>
        <h2>Asset Performance Tracker</h2>
        <p>
            Asset Name:&nbsp;
            <asp:TextBox ID="assetTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:&nbsp;
            <asp:TextBox ID="electionTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="subTFTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="msgLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
