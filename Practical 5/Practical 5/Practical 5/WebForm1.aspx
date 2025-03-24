<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 173px;
        }
        .auto-style2 {
            width: 252px;
        }
        .auto-style3 {
            width: 115px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style6 {
            margin-left: 2px;
        }
        .auto-style7 {
            text-align: left;
        }
        .auto-style8 {
            width: 173px;
            height: 19px;
        }
        .auto-style9 {
            width: 252px;
            height: 19px;
        }
        .auto-style10 {
            width: 115px;
            height: 19px;
        }
        .auto-style11 {
            height: 19px;
        }
        .auto-style12 {
            width: 173px;
            height: 52px;
        }
        .auto-style13 {
            width: 252px;
            height: 52px;
        }
        .auto-style14 {
            width: 115px;
            height: 52px;
        }
        .auto-style15 {
            height: 52px;
        }
        .auto-style16 {
            text-align: left;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#3399FF" Text="Art Club Pen Order Form"></asp:Label>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Fisrt Name:"></asp:Label>
                </td>
                <td class="auto-style2">
        <div style="height: 27px">
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style4" Height="16px" style="text-align: left"></asp:TextBox>
        </div>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLastName" ErrorMessage="Required!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label3" runat="server" Text="Phone Number:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtPhoneNum" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="Label4" runat="server" Text="Email Address:"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email address" ValidationExpression="^[\w\.-]+@[\w\.-]+\.\w{2,4}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="Label5" runat="server" Text="Pen Selection for order:"></asp:Label>
                </td>
                <td class="auto-style13"></td>
                <td class="auto-style14">
                    <asp:Button ID="btnOrder" runat="server" CssClass="auto-style4" Height="33px" OnClick="btnOrder_Click" Text="Place order" Width="147px" />
                </td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="Label6" runat="server" Text="Colour:"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlColour" runat="server" CssClass="auto-style4" Height="20px" Width="87px">
                        <asp:ListItem Value="30">Black</asp:ListItem>
                        <asp:ListItem>Red</asp:ListItem>
                        <asp:ListItem>Blue</asp:ListItem>
                        <asp:ListItem>Green</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label7" runat="server" Text="Amount:"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtAmount" runat="server" CssClass="auto-style6" Height="18px" Width="52px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAmount" ErrorMessage="Amount not valid" MaximumValue="50" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
        </table>
        <div class="auto-style7">
&nbsp;</div>
        <p class="auto-style16">
            <asp:Label ID="lblResult" runat="server" Text="lblResult"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblAmount" runat="server" Font-Italic="True" Text="lblAmount"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblTax" runat="server" Font-Italic="True" Text="lblTax"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblTotal" runat="server" BorderColor="White" Font-Bold="True" Font-Size="X-Large" ForeColor="#FF3300" Text="lblTotal"></asp:Label>
        </p>
    </form>
</body>
</html>
