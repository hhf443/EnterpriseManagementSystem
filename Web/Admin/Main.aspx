<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Web.Admin.Main" MasterPageFile="~/Admin/Admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!DOCTYPE html>

<html>
<head>
<title>管理中心 V1.0</title>
<meta http-equiv=Content-Type content="text/html; charset=gb2312">
<meta http-equiv=Pragma content=no-cache>
<meta http-equiv=Cache-Control content=no-cache>
<meta http-equiv=Expires content=-1000>
<link href="css/admin.css" type="text/css" rel="stylesheet">
</head>

<FRAMESET border=0 frameSpacing=0 rows="60,*" frameBorder=0>
    <FRAME name=header src="Top.aspx" frameBorder=0 noResize scrolling=no></FRAME>
    <FRAMESET cols="170,*">
        <FRAME name=menu src="menu.htm" frameBorder=0 noResize></FRAME>
        <FRAME name=main src="Index.aspx" frameBorder=0 noResize scrolling=yes></FRAME>
    </FRAMESET>
</FRAMESET>

<noframes>
</noframes>
</html>
</asp:Content>
