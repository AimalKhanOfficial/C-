<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormsApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <label runat="server" id="lblTxt"></label>
    <div>
        <input type="text" runat="server" id="txtName"/>
        <br/>
        <input type="button" value="Click me!" runat="server" OnServerClick="OnServerClick"/>
        
        <br/>
        <input type="button" value="Lets fly! Redirect" runat="server" OnServerClick="Redirect"/>
        
        <br/>
        <input type="button" value="Lets fly! Server Transfer" runat="server" OnServerClick="Transfer"/>
    </div>
    </form>
</body>
</html>
