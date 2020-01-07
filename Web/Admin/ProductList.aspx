<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Web.Admin.ProductList" MasterPageFile="~/Admin/Admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!DOCTYPE html>

<html>
<head>
<title></title>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<link href="css/admin.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
        #news_list
        {
	        background-color:#ccc;
	        border:0;
        }
        #news_list td
        {
	        background-color:#fff;
	        padding:5px;
        }
    </style>
</head>

<body>
<form id="form1" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" align="center" border="0">
        <tr>
            <td height="28" style=" background-image:url(images/title_bg1.jpg)">��ǰλ��: ��Ʒ����</td>
        </tr>
        <tr>
            <td bgcolor="#b1ceef" height="1"></td>
        </tr>
        <tr >
            <td height="20" style=" background-image:url(images/shadow_bg.jpg)"></td>
        </tr>
    </table>

    <table id="news_list" cellspacing="1" width="95%" align="center">
        <tr style=" background-color:#eee;">
        <td>��Ʒ����</td>
        <td>�۸�</td>
        <td>�༭</td>
        <td>ɾ��</td>
        </tr>
        <asp:Repeater ID="rptProducts" runat="server">
        <ItemTemplate>
        <tr>
        <td><%# Eval("Name") %></td>
        <td><%# Eval("Price") %></td>
        <td><asp:LinkButton runat="server" ID="lnkbtnUpdates" PostBackUrl='<%# "EditProduct.aspx?id=" + Eval("ID") %>'>�޸�</asp:LinkButton></td>
        <td><asp:LinkButton runat="server" ID="lnkbtnDeletes" OnClientClick="return confirm('ɾ���ò�Ʒ��ɾ��������ص����ж�����\nȷ��ɾ����');" 
            CommandArgument='<%# Eval("ID") %>' OnCommand="lnkbtnDelete_Command">ɾ��</asp:LinkButton></td>
        </tr>
        </ItemTemplate>
        </asp:Repeater>
    </table>
</form>
</body>
</html>

</asp:Content>

