<%@ Page Language="VB" AutoEventWireup="false" CodeFile="imageDetails.aspx.vb" Inherits="imageDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            width: 238px;
        }
        .style4
        {
            width: 205px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="2" style="font-size: x-large">
                    Search your image</td>
            </tr>
            <tr>
                <td class="style3" style="font-size: x-large">
                    enter the id
                </td>
                <td style="font-size: x-large">
                    <asp:TextBox ID="txtid" runat="server" style="font-size: large"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3" style="font-size: x-large">
                    &nbsp;</td>
                <td style="font-size: x-large">
                    <asp:Button ID="Button1" runat="server" style="font-size: large" 
                        Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="style3" style="font-size: x-large">
                    &nbsp;</td>
                <td style="font-size: x-large">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" colspan="2" style="font-size: x-large">
                    <asp:Panel ID="pnl" runat="server" Visible="False">
                        <table class="style1">
                            <tr>
                                <td class="style4">
                                    Image Name</td>
                                <td>
                                    <asp:Label ID="lblnm" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    Image</td>
                                <td>
                                    <asp:Image ID="img" runat="server" Height="181px" Width="205px" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
