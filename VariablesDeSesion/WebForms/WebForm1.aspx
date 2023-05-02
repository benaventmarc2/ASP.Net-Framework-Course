<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="VariablesDeSesion.WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtIncremento" runat="server"></asp:TextBox>
            <asp:Button ID="btnIncremento" runat="server" OnClick="btnIncremento_Click" Text="Button" />
            <br />
            viewstate webform1<br />
            comprara con webform2</div>
    </form>
</body>
</html>
