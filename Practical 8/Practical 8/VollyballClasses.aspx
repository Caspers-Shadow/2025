<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VollyballClasses.aspx.cs" Inherits="Practical_8.VollyballClasses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 159px;
        }
        .auto-style2 {
            width: 418px;
        }
        .auto-style3 {
            width: 159px;
            height: 42px;
        }
        .auto-style4 {
            width: 418px;
            height: 42px;
        }
        .auto-style5 {
            width: 524px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" Width="94px" />
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="#990099" Text="Virtual Volleyball Coaching Class Booking"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter name!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style5" rowspan="5">
                    <asp:Calendar ID="theCal" runat="server"></asp:Calendar>
                </td>
                <td rowspan="5">
                    <asp:Label ID="lblOutput" runat="server" BackColor="#CC00FF"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter email!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Student number:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtStudNum" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter student number!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Select Campus:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:RadioButton ID="rgbMC" runat="server" BackColor="#CC00FF" GroupName="Campus" Text="MC" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="rgbPC" runat="server" GroupName="Campus" Text="PC" BackColor="#CC00FF" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="rgbVC" runat="server" GroupName="Campus" Text="VC" BackColor="#CC00FF" />
                &nbsp;
                    <asp:Label ID="lblCampus" runat="server" Text="Please choose a campus!" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    <asp:Button ID="btnBook" runat="server" Height="34px" Text="Book" Width="116px" OnClick="btnBook_Click" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
