<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="LoginEncrypt.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <h1>Welcome to Login page</h1>
    <hr />
    <div>
        
        Enter the Username<asp:TextBox ID="txtUsername" runat="server" placeholder="Username" ></asp:TextBox>
        <br />
        Enter the Password<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"  placeholder="Password"></asp:TextBox>
        
    </div>
</div>

<asp:Button ID="btnSRegister" runat="server"  text="Save" OnClick="btnSRegister_Click" />
        </div>
    </form>
</body>
</html>
