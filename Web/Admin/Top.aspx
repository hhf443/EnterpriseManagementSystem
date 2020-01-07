<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top.aspx.cs" Inherits="Web.Admin.Top" %>

<!DOCTYPE html>

<html>
<head runat="server">

<title>头部</title>
<META http-equiv=Content-Type content="text/html; charset=gb2312">
<LINK href="css/admin.css" type="text/css" rel="stylesheet">

    <style type="text/css">
        .auto-style1 {
            font-family: Verdana;
            font-size: large;
            color: #FFFFFF;
        }
        .auto-style2 {
            font-family: Verdana;
            font-size: small;
        }
    </style>

</head>

<body>

    <form id="form1" runat="server">
    
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0>
  <TR height=56>
    <TD width=260 style="background-color:#20B2AA" class="auto-style1"><em><strong>&nbsp;&nbsp; HOFE无限公司</strong></em></TD>
    <TD style="FONT-WEIGHT: bold; COLOR: #fff; PADDING-TOP: 20px; background-color:#20B2AA" align=middle class="auto-style2">
        当前用户：admin &nbsp;&nbsp; &nbsp;&nbsp; 
        <asp:LinkButton ID="lnkbtnLogout" runat="server" 
            OnClientClick="if (confirm('确定要退出吗？')) return true; else return false;" 
            Font-Underline="False" ForeColor="White" onclick="lnkbtnLogout_Click">退出系统</asp:LinkButton>
    </TD>
    <TD align=right width=268 style="background-color:#20B2AA"></TD></TR>
</TABLE>

    </form>
    
</body>
</html>
