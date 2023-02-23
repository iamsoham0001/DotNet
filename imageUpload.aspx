<%@ Page Language="VB" AutoEventWireup="false" CodeFile="imageUpload.aspx.vb" Inherits="imageUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 528px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td align="center" colspan="2" 
                style="font-size: x-large; font-family: 'Fira Code'; font-weight: 700;">
                Upload your Image Here</td>
        </tr>
        <tr>
            <td align="left" colspan="2" 
                style="font-size: x-large; font-family: 'Fira Code'">
                Enter a ID for your Image :<asp:TextBox ID="txtID" runat="server" 
                    style="font-size: large"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: x-large; font-family: 'Fira Code'">
                Enter a name for your Image :</td>
            <td style="font-size: x-large; font-family: 'Fira Code'">
                <asp:TextBox ID="txtName" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: x-large; font-family: 'Fira Code'">
                Upload your image file :</td>
            <td style="font-size: x-large; font-family: 'Fira Code'">
                <asp:FileUpload ID="fileUploadTool" runat="server" style="font-size: large" />
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: x-large; font-family: 'Fira Code'">
                &nbsp;</td>
            <td style="font-size: x-large; font-family: 'Fira Code'">
                <asp:Button ID="Button1" runat="server" style="font-size: large" 
                    Text="Upload !" />
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: x-large; font-family: 'Fira Code'">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/imageDetails.aspx">view images</asp:HyperLink>
            </td>
            <td style="font-size: x-large; font-family: 'Fira Code'">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
