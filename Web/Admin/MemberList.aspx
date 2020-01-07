<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberList.aspx.cs" Inherits="Web.Admin.MemberList" MasterPageFile="Admin.master" %>

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
            <td height="28" style=" background-image:url(images/title_bg1.jpg)">��ǰλ��: �û�����</td>
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
    <td>�û���</td>
    <td>�Ա�</td>
    <td>����</td>
    <td>�绰</td>
    <td>�鿴</td>
    <td>ɾ��</td>
    </tr>
    <asp:Repeater ID="rptMembers" runat="server">
    <ItemTemplate>
    <tr>
    <td><%# Eval("LoginName") %></td>
    <td><%# bool.Parse(Eval("IsMale").ToString())?"��":"Ů" %></td>
    <td><%# Eval("Age") %></td>
    <td><%# Eval("Phone") %></td>
    <td><asp:LinkButton runat="server" ID="lnkbtnUpdates" PostBackUrl='<%# "ShowMember.aspx?id=" + Eval("ID") %>'>�鿴��ϸ</asp:LinkButton></td>
    <td><asp:LinkButton runat="server" ID="lnkbtnDelete" OnClientClick="return confirm('�Ƿ�ɾ����')"
     CommandArgument='<%# Eval("ID") %>' OnCommand="lnkbtnDelete_Command" >ɾ�����û�</asp:LinkButton></td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
    </table>
</form>
</body>
</html>

</asp:Content>
