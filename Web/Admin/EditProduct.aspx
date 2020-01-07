<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Web.Admin.EditProduct" MasterPageFile="Admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title></title>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<link href="css/admin.css" type="text/css" rel="stylesheet" />
</head>

<body>
<form id="form1" runat="server">
<table cellspacing="0" cellpadding="0" width="100%" align="center" border="0">
    <tr>
        <td height="28" style=" background-image:url(images/title_bg1.jpg)">当前位置: 产品编辑页面</td>
    </tr>
    <tr>
        <td bgcolor="#b1ceef" height="1"></td>
    </tr>
    <tr >
        <td height="20" style=" background-image:url(images/shadow_bg.jpg)"></td>
    </tr>
</table>

<table cellspacing="0" cellpadding="2" width="95%" align="center" border="0">
    <tr>
        <td align="right" width="100">产品名称：</td>
        <td style="COLOR: #880000"><asp:TextBox ID="txtName" runat="server" Width="300" MaxLength="50"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right" width="100">图片：</td>
        <td style="COLOR: #880000">
            <asp:FileUpload ID="fuPicture" runat="server" Width="300" />
        </td>
    </tr>
    <tr>
        <td align="right" width="100">价格：</td>
        <td style="COLOR: #880000"><asp:TextBox ID="txtPrice" runat="server" Width="300"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">详细说明：</td>
        <td style="COLOR: #880000">        
        <asp:TextBox ID="txtDetails" runat="server" style="width:600px;height:230px;"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right"></td>
        <td style="COLOR: #880000"><asp:Button runat="server" ID="btnSave" Text="保存" onclick="btnSave_Click" /></td>
    </tr>
</table>
<div runat="server" id="divResult"></div>
</form>
</body>
</html>

</asp:Content>

