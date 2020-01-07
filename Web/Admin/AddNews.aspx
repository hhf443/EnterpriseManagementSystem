<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="Web.Admin.AddNews" MasterPageFile="Admin.Master" ValidateRequest="False" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<!DOCTYPE html>
<html>
<head>
<title></title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/admin.css" type="text/css" rel="stylesheet" />
    <script src="kindeditor-3.3.1/kindeditor.js" charset="utf-8" type="text/javascript"></script>
    <script type="text/javascript">
        KE.show({
            id: '<%= txtContent.ClientID %>',
            cssPath: 'kindeditor-3.3.1/examples/index.css'
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" align="center" border="0">
        <tr>
            <td height="28" style=" background-image:url(images/title_bg1.jpg)">当前位置: 新闻添加页面</td>
        </tr>
        <tr>
            <td bgcolor="#49C8AF" height="1"></td>
        </tr>
        <tr >
            <td height="20" style=" background-image:url(images/shadow_bg.jpg)"></td>
        </tr>
    </table>

    <table cellspacing="0" cellpadding="2" width="95%" align="center" border="0">
        <tr>
            <td align="right" width="100">新闻标题：</td>
            <td style="COLOR: #880000"><asp:TextBox ID="txtTitle" runat="server" Width="300" MaxLength="100"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">内容：</td>
            <td style="COLOR: #880000">
        
            <asp:TextBox ID="txtContent" runat="server" style="width:100%;height:400px;visibility:hidden;"></asp:TextBox>
    
            </td>
        </tr>
        <tr>
            <td align="right" style="height: 36px"></td>
            <td style="COLOR: #880000; height: 36px;"><asp:Button runat="server" ID="btnSave" Text="保存" onclick="btnSave_Click" /></td>
        </tr>
    </table>
    </form>
</body>
</html>
</asp:Content>
