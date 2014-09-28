<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>XYZ Corporation - Payroll Calculator</title>
    <link rel="stylesheet" type="text/css" href="NetPayCalc.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Company XYZ - EMPLOYEE PAYROLL CALCULATOR</h1>
        <br />
        <br />
        <asp:Label ID="lblwagehr" runat="server" Text="Hourly Wage:"></asp:Label>
        <asp:TextBox ID="tbwage" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblworkhr" runat="server" Text="Hours Worked:"></asp:Label>
        <asp:TextBox ID="tbhrworked" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDeductionspretax" runat="server" EnableTheming="True" Text="Pre Tax Deductions:"></asp:Label>
        <asp:TextBox ID="tbDeductionpretax" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbldeductionposttax" runat="server" Text="Post Tax Deductions:"></asp:Label>
        <asp:TextBox ID="tbPostDeduction" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCalc" runat="server" Text="Calculate Net Pay" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" />
        <br />
    
    
        <p>
            <asp:Label ID="lblDisplayNet" runat="server" Text="Employee Net Pay:" Visible="False"></asp:Label>
            <asp:Label ID="lblnetpay" runat="server"></asp:Label>
        </p>

    </div>
    </form>
</body>
</html>
