<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseRegistration.aspx.cs" Inherits="Practical_6.CourseRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
            width: 306px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style7 {
            width: 305px;
        }
        .auto-style8 {
            text-align: right;
            width: 305px;
        }
        .auto-style9 {
            width: 248px;
        }
        .auto-style10 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div class="auto-style1">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Course Registration Form"></asp:Label>
        </div>
                <table class="auto-style10">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label2" runat="server" Text="Student Name:"></asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:TextBox ID="txtName" runat="server" Width="342px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Name Required!" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style4" Width="336px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Required!" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Wrong Email format!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <p class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Available Courses:"></asp:Label>
                </p>
                <asp:ListBox ID="lstCourses" runat="server" Width="224px">
                    <asp:ListItem>Web Development</asp:ListItem>
                    <asp:ListItem>AI</asp:ListItem>
                    <asp:ListItem>Data Science</asp:ListItem>
                    <asp:ListItem>Cybersecurity</asp:ListItem>
                </asp:ListBox>
            </div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label5" runat="server" Text="Study Mode:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:DropDownList ID="ddlStudyMode" runat="server" Height="33px" Width="235px">
                            <asp:ListItem>Select Study Mode</asp:ListItem>
                            <asp:ListItem>Part Time</asp:ListItem>
                            <asp:ListItem>Full Time</asp:ListItem>
                            <asp:ListItem>Distance</asp:ListItem>
                            <asp:ListItem>International</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlStudyMode" ErrorMessage="Study Mode Required!" ForeColor="Red" InitialValue="Select Study Mode"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="btnRegister" runat="server" BackColor="#33CC33" OnClick="btnRegister_Click" Text="Register" Width="151px" />
                    </td>
                    <td>
                        <asp:Button ID="btnClear" runat="server" BackColor="Yellow" OnClick="btnClear_Click" Text="Clear" Width="151px" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblOutput" runat="server" ForeColor="Red" Text="Make sure all the requires information have been provided!"></asp:Label>
            <br />
            <asp:Image ID="imgCyber" runat="server" ImageUrl="~/WelcometoCyber.jpg" />
            <asp:Image ID="imgData" runat="server" Height="162px" ImageUrl="~/WelcometoDataScie.jpg" Width="305px" />
            <asp:Image ID="imgAI" runat="server" Height="106px" ImageUrl="~/WelcometoAI.jpg" Width="128px" />
            <asp:Image ID="imgWeb" runat="server" ImageUrl="~/WlcomeWebDev.png" Width="225px" />
        </div>
    </form>
</body>
</html>
