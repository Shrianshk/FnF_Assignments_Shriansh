<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWords.aspx.cs" Inherits="Hackathon2.MyWords" %>

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

    table {
        border-collapse: collapse;
        width: 100%;
    }

    th, td {
        border: 1px solid #ccc;
        padding: 8px;
    }

    th {
        background-color: #eee;
    }
</style>

   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="Key" HeaderText="Word" />
                    <asp:BoundField DataField="Value" HeaderText="Translation" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
