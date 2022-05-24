<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Validate XML Service"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="XML Url:"></asp:Label>
            <asp:TextBox ID="XMLTextBox" runat="server" Width="860px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="XSD Url:"></asp:Label>
&nbsp;<asp:TextBox ID="XSDTextBox" runat="server" Width="859px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Validate XML File" />
            <br />
            <br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Validation Results:"></asp:Label>
            <br />
            <asp:TextBox ID="Results" runat="server" ReadOnly="True" Width="922px" Height="75px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Add Team Node Service"></asp:Label>
            <br />
            <br />
            <asp:Label ID="xmlurl" runat="server" Text="XML URL:"></asp:Label>
            <br />
            <asp:Label ID="teamName" runat="server" Text="Team Name:"></asp:Label>
&nbsp;<asp:TextBox ID="teamNameTextBox" runat="server" Width="239px"></asp:TextBox>
            <br />
            <asp:Label ID="college" runat="server" Text="College:"></asp:Label>
&nbsp;<asp:TextBox ID="collegeTextBox" runat="server" Width="239px"></asp:TextBox>
&nbsp;<br />
            <asp:Label ID="Label6" runat="server" Text="Conference:"></asp:Label>
&nbsp;<asp:TextBox ID="ConferenceTextBox" runat="server" Width="239px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="xmlurl0" runat="server" Text="Quarterback1:"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="teamName0" runat="server" Text="First Name:"></asp:Label>
&nbsp;<asp:TextBox ID="qb1FirstNameTextBox" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="college0" runat="server" Text="Last Name:"></asp:Label>
&nbsp;<asp:TextBox ID="qb1LastNameTextBox" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" Text="Height:"></asp:Label>
&nbsp;<asp:TextBox ID="qb1HeightTextBox" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Text="Number:"></asp:Label>
&nbsp;<asp:TextBox ID="qb1Number" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label11" runat="server" Text="QBR:"></asp:Label>
&nbsp;<asp:TextBox ID="qb1QBR" runat="server" Width="239px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Quarterback2:"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="teamName1" runat="server" Text="First Name:"></asp:Label>
&nbsp;<asp:TextBox ID="qb2FirstName" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="college2" runat="server" Text="Last Name:"></asp:Label>
&nbsp;<asp:TextBox ID="qb2LastName" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label12" runat="server" Text="Height:"></asp:Label>
&nbsp;<asp:TextBox ID="qb2Height" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label13" runat="server" Text="Number:"></asp:Label>
&nbsp;<asp:TextBox ID="qb2Number" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label14" runat="server" Text="QBR:"></asp:Label>
&nbsp;<asp:TextBox ID="qb2Qbr" runat="server" Width="239px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="college1" runat="server" Text="Schedule:"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="teamName2" runat="server" Text="Week1:"></asp:Label>
&nbsp;<asp:TextBox ID="week1" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="college3" runat="server" Text="Week2:"></asp:Label>
&nbsp;<asp:TextBox ID="week2" runat="server" Width="239px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label15" runat="server" Text="Week3:"></asp:Label>
&nbsp;<asp:TextBox ID="week3" runat="server" Width="239px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add Team" />
            <br />
            <br />
            <asp:Label ID="Label16" runat="server" Text="XML Before:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label17" runat="server" Text="XML After Adding Team Node:"></asp:Label>
            <br />
            <asp:TextBox ID="XMLBefore" runat="server" Height="792px" TextMode="MultiLine" Width="658px"></asp:TextBox>
            <asp:TextBox ID="ResultsTextBox" runat="server" Height="792px" TextMode="MultiLine" Width="658px"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
