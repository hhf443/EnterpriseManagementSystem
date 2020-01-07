<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="Web.Admin.NewsList" MasterPageFile="Admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                <td height="28" style=" background-image:url(images/title_bg1.jpg)">当前位置: 新闻管理</td>
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
            <td>标题</td>
            <td>发布时间</td>
            <td>删除</td>
            </tr>
                <asp:Repeater ID="rptNews" runat="server">
                <ItemTemplate>
            <tr>
            <td><%# Eval("Title") %></td>
            <td><%# Eval("PublishTime") %></td>
            <td><asp:LinkButton runat="server" ID="lnkbtnDeletes" OnClientClick="return confirm('确定删除？');"
            CommandArgument='<%# Eval("ID") %>' OnCommand="lnkbtnDelete_Command">删除</asp:LinkButton></td>
            </tr>
                </ItemTemplate>
                </asp:Repeater>
        </table>
    </form>
</body>
</html>
</asp:Content>