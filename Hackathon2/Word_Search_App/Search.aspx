<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Hackathon2.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h1>Welcome to Word Search Application</h1>
            </div>
            <hr />
            Enter the Word to Search<asp:TextBox ID="txtWord" runat="server" />
            <br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />


            <br /><br />

            <asp:Button ID="btnShowAll" runat="server" Text="Show All Words" OnClick="btnShowAll_Click" />

            <br />
            <br />

            <asp:GridView ID="gvAllWords" runat="server" AutoGenerateColumns="False" Visible="false">
                <Columns>
                    <asp:BoundField DataField="Key" HeaderText="Word" />
                    <asp:BoundField DataField="Value" HeaderText="Translation" />
                </Columns>
            </asp:GridView>




        </div>
    </form>
</body>
</html>



