<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTranslation.aspx.cs" Inherits="Hackathon2.AddTranslation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       
    body {
        font-family: sans-serif;
        background-color: #ffffff;
        padding: 20px;
    }

    div {
        margin: 10px 0;
    }

    label, input, button {
        display: block;
        margin: 10px 0;
    }

    input[type="text"] {
        padding: 6px;
        width: 200px;
        border: 1px solid #ccc;
    }

    button {
        padding: 6px 12px;
        background-color: #4CAF50;
        color: white;
        border: none;
        cursor: pointer;
    }

    button:hover {
        background-color: #45a049;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWord" runat="server" />
            <asp:TextBox ID="txtTranslation" runat="server" />
            <asp:Button ID="btnAdd" runat="server" Text="Add to My Words" OnClick="btnAdd_Click" />

        </div>
    </form>
</body>
</html>
