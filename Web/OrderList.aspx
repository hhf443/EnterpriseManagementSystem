<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="Web.OrderList" MasterPageFile="MainMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
#order_list
{
    border:0;
    background-color:#ccc;
}
#order_list td
{
	background-color:#fff;
	padding:5px;
	font-size:13px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>订单列表</h2>

<table id="order_list" cellspacing="1">
    <asp:Repeater ID="rptOrders" runat="server">
    <ItemTemplate>
<tr>
<td>产品名称：<%# GetProductNameById(Eval("ProductID"))%></td>
<td>数量：<%# Eval("Number") %></td>
<td>时间：<%# Eval("PublishTime") %></td>
</tr>
<tr><td colspan="3">
详细说明：<%# Eval("Details") %><br /><br />
<div style='text-align:right;<%# bool.Parse(Eval("Status")+"")?"":"display:none" %>'>己处理</div>

</td></tr>
    </ItemTemplate>
    </asp:Repeater>
</table>

</asp:Content>
