
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="State.aspx.cs" Inherits="KMS.UI.State" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <table>
            <tr>
                <td>Name : 
                    <asp:TextBox ID="txtStateName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
            </tr>
        </table>
        <div>
            <asp:GridView ID="grdState"  runat="server">

            </asp:GridView>
        </div>
    </form>
</body>
</html>
