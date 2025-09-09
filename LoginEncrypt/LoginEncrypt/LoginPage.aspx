<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginEncrypt.LoginPage" %>

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
                Enter the Password<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"  placeholder="Password" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
                
            </div>
        </div>
        <asp:Button ID="btnLogin" runat="server"  text="Login" OnClick="btnLogin_Click"/>
        <asp:Button ID="btnSignup" runat="server"  text="SignUp" OnClick="btnSignup_Click" />
    </form>
</body>
</html>
