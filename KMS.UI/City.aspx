<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="City.aspx.cs" Inherits="KMS.UI.City" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>State</td>
                    <td><asp:DropDownList ID="ddlState" runat="server">
                        <asp:ListItem Text="--Select--" Value="0" />
                        <asp:ListItem Text="HARYANA" Value="14"></asp:ListItem>
                        <asp:ListItem Text="DELHI" Value="9"></asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>City</td>
                <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" />
                            <asp:BoundField DataField="Name" HeaderText="City" />
                            <asp:BoundField DataField="StateName" HeaderText="State" />
                        </Columns>
                        </asp:GridView></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
