<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowMember.aspx.cs" Inherits="Web.Admin.ShowMember" MasterPageFile="Admin.master" %>

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
            <td height="28" style=" background-image:url(images/title_bg1.jpg)">��ǰλ��: ��Ա��Ϣ</td>
        </tr>
        <tr>
            <td bgcolor="#b1ceef" height="1"></td>
        </tr>
        <tr >
            <td height="20" style=" background-image:url(images/shadow_bg.jpg)"></td>
        </tr>
    </table>

    <table cellspacing="0" cellpadding="5" width="95%" align="center" border="0">
        <tr>
            <td align="right" width="100">��¼���ƣ�</td>
            <td style="COLOR: #880000"><asp:label ID="lblLoginName" runat="server"></asp:label></td>
        </tr>
        <tr>
            <td align="right">���룺</td>
            <td style="COLOR: #880000"><asp:label ID="lblPassword" runat="server"></asp:label></td>
        </tr>
        <tr>
            <td align="right">�Ա�</td>
            <td style="COLOR: #880000"><asp:label ID="lblSex" runat="server"></asp:label></td>
        </tr>
        <tr>
            <td align="right">���䣺</td>
            <td style="COLOR: #880000"><asp:label ID="lblAge" runat="server"></asp:label></td>
        </tr>
        <tr>
            <td align="right">�绰��</td>
            <td style="COLOR: #880000"><asp:label ID="lblPhone" runat="server"></asp:label></td>
        </tr>
        <tr>
            <td align="right">���䣺</td>
            <td style="COLOR: #880000"><asp:label ID="lblEmail" runat="server"></asp:label></td>
        </tr>
        <tr>
            <td align="right">��ַ��</td>
            <td style="COLOR: #880000"><asp:label ID="lblAddress" runat="server"></asp:label></td>
        </tr>
        <tr>
            <td align="right"></td>
            <td style="COLOR: #880000"><a href="MemberList.aspx">�����б�</a></td>
        </tr>
    </table>
</form>
</body>
</html>

</asp:Content>