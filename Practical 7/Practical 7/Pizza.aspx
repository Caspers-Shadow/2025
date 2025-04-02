<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pizza.aspx.cs" Inherits="Practical_7.Pizza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 136px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 54px;
        }
        .auto-style4 {
            width: 570px;
        }
        .auto-style5 {
            height: 26px;
            width: 570px;
        }
        .auto-style6 {
            height: 54px;
            width: 570px;
        }
        .auto-style7 {
            width: 158px;
        }
        .auto-style8 {
            height: 26px;
            width: 158px;
        }
        .auto-style9 {
            height: 54px;
            width: 158px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="Red" Text="Complete this Form to order Pizza"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label5" runat="server" Text="Selected Size:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlSize" runat="server" Width="201px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem Value="Small"></asp:ListItem>
                            <asp:ListItem>Medium</asp:ListItem>
                            <asp:ListItem>Large</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlSize" ErrorMessage="Please enter size!" InitialValue="1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label4" runat="server" Text="Select Toppings:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:ListBox ID="lstToppings" runat="server" Width="158px">
                            <asp:ListItem>Cheese</asp:ListItem>
                            <asp:ListItem>Mushroom</asp:ListItem>
                            <asp:ListItem>Pepperoni</asp:ListItem>
                            <asp:ListItem>Olives</asp:ListItem>
                            <asp:ListItem Value="Bacon"></asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lstToppings" ErrorMessage="Please enter toppings!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label6" runat="server" Text="Crust Type:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:RadioButton ID="rdThin" runat="server" AutoPostBack="True" GroupName="Crust" OnCheckedChanged="radButton_CheckChanged" Text="Thin" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:RadioButton ID="rdThick" runat="server" AutoPostBack="True" GroupName="Crust" OnCheckedChanged="radButton_CheckChanged" Text="Thick" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:CheckBox ID="chkTrip" runat="server" AutoPostBack="True" Text="Add a tip" />
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtTip" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTip" ErrorMessage="Please enter toppings!" Visible="False"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="Order" Width="107px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Label ID="lblOutput" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
