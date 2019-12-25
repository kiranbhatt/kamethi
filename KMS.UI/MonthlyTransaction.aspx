<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonthlyTransaction.aspx.cs" Inherits="KMS.UI.MonthlyTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="UserId" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Name" SortExpression="UserName">

                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="UserId">
                    <ItemTemplate>
                            <asp:Label ID="lblUsetId" runat="server" Text='<%# Bind("UserId") %>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                    <%--<asp:BoundField DataField="UserId" Visible="false" HeaderText="UserId" InsertVisible="False" ReadOnly="True" SortExpression="UserId" />--%>

                    <asp:TemplateField HeaderText="Monthly Installment">
                        <ItemTemplate>
                            <asp:TextBox ID="txtMonthlyInstallment" runat="server" Text='<%# Bind("[Monthly Installment]") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Taken Amount">
                        <ItemTemplate>
                            <asp:TextBox ID="txtTakenAmount" runat="server" Text='<%# Bind("[Taken Amount]") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Given Amount">

                        <ItemTemplate>
                            <asp:TextBox ID="txtGivenAmount" runat="server" Text='<%# Bind("[Taken Amount]") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Deposit Amount">

                        <ItemTemplate>
                            <asp:TextBox ID="txtDepositAmount" runat="server" Text='<%# Bind("[Deposit Amount]") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="Balance Amount" SortExpression="Balance Amount">
                        <ItemTemplate>
                            <asp:TextBox ID="txtBalanceAmount" runat="server" Text='<%# Bind("[Balance Amount]") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>






                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EMSConnectionString %>" SelectCommand="usp_monthlytransactionusers" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        </div>
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
    </form>
</body>
</html>
