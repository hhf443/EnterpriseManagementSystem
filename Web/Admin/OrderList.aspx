<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="Web.Admin.OrderList" MasterPageFile="Admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!DOCTYPE html>

<html>
<head>
<title></title>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<link href="css/admin.css" type="text/css" rel="stylesheet" />
    <style>
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
        <td height="28" style=" background-image:url(images/title_bg1.jpg)">当前位置: 订单管理</td>
    </tr>
    <tr>
        <td bgcolor="#b1ceef" height="1"></td>
    </tr>
    <tr >
        <td height="20" style=" background-image:url(images/shadow_bg.jpg)"></td>
    </tr>
</table>
<table id="news_list" cellspacing="1" width="95%" align="center">

<asp:Repeater ID="rptOrders" runat="server">
<ItemTemplate>
<tr>
<td>产品名称：<%# ConvertProduct(Eval("ProductID")) %></td>
<td>会员ID：<%# ConvertMember(Eval("MemberID")) %></td>
<td>订购数量：<%# Eval("Number") %></td>
<td>发布时间：<%# Eval("PublishTime") %></td>
</tr>
<tr>
<td colspan="5">
详细说明：<%# Eval("Details") %><br /><br /><div style=" text-align:right;">
<asp:LinkButton runat="server" ID="lnkbtnChangeStatus" CommandArgument='<%# Eval("ID") %>'
OnCommand="lnkbtnChangeStatus_Command" Visible='<%# !bool.Parse(Eval("Status")+"") %>'>处理订单</asp:LinkButton>
<span <%# !bool.Parse(Eval("Status")+"")?"style='display:none'":"" %> >己处理</span>
</div>
</td>
</tr>
</ItemTemplate>
</asp:Repeater>

</table>
</form>
</body>
</html>

</asp:Content>
