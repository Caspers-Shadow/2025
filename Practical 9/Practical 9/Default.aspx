<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practical_9.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 257px;
        }
        .auto-style3 {
            width: 455px;
        }
        .auto-style4 {
            width: 257px;
            height: 26px;
        }
        .auto-style5 {
            width: 455px;
            height: 26px;
        }
        .auto-style6 {
            background-color: #00FF99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style6">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Book your appointment with Dr.C# to See Sharp"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtName" ErrorMessage="Please enter a name!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td rowspan="4">
                    <asp:Calendar ID="TheCal" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please neter an email address!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Select Service:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlService" runat="server">
                        <asp:ListItem>Eye Exam</asp:ListItem>
                        <asp:ListItem>Contact Lens Fitting</asp:ListItem>
                        <asp:ListItem>Eye Health Advice</asp:ListItem>
                        <asp:ListItem>Care for Eye Injuries</asp:ListItem>
                    </asp:DropDownList>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlService" ErrorMessage="Please select a service!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Payment Method:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:RadioButton ID="rdoCash" runat="server" GroupName="Payment Method" Text="Cash" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="rdoAid" runat="server" GroupName="Payment Method" Text="Medical Aid" />
&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnBook" runat="server" Height="38px" OnClick="btnBook_Click" Text="Book" Width="207px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Label ID="lblBookingShow" runat="server" Visible="False">Booking</asp:Label>
                </td>
                <td rowspan="2"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:GridView ID="gvBooking" runat="server" Visible="False">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
