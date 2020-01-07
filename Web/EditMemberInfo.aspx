<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditMemberInfo.aspx.cs" Inherits="Web.EditMemberInfo" MasterPageFile="MainMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        #tbl_user
{
	    border-style: none;
            border-color: inherit;
            border-width: 0;
            background-color:#ccc;
	        height: 226px;
            width: 616px;
        }
#tbl_user td
{
	background-color:#fff;
	padding:5px;
	font-size:13px;
}
        .auto-style2 {
        }
        .auto-style4 {
            width: 106px;
        }
        .auto-style5 {
            width: 151px;
        }
        .auto-style6 {
            width: 107px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>修改用户信息</h2>
<center>
<table id="tbl_user" cellspacing="1">
<tr><td class="auto-style4">用户名：</td><td class="auto-style5"><asp:Label ID="lblLoginName" runat="server" MaxLength="20"></asp:Label></td><td class="auto-style6">年龄：</td><td class="auto-style2"><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td></tr>
<tr><td class="auto-style4">旧密码：</td><td class="auto-style5"><asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password" MaxLength="20"></asp:TextBox><br />
不填此项不修改密码
</td><td class="auto-style6">电话：</td><td class="auto-style2"><asp:TextBox ID="txtPhone" runat="server" MaxLength="20"></asp:TextBox>
</td></tr>
<tr><td class="auto-style4">新密码：</td><td class="auto-style5"><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" MaxLength="20"></asp:TextBox></td><td class="auto-style6">邮箱：</td><td class="auto-style2"><asp:TextBox ID="txtEmail" runat="server" MaxLength="50"></asp:TextBox></td></tr>
<tr><td class="auto-style4">重复密码：</td><td class="auto-style5"><asp:TextBox ID="txtRePassword" runat="server" TextMode="Password" MaxLength="20"></asp:TextBox></td><td class="auto-style6">地址：</td><td class="auto-style2"><asp:TextBox ID="txtAddress" runat="server" MaxLength="255"></asp:TextBox></td></tr>
<tr><td class="auto-style4">性别：</td><td class="auto-style5">
    <asp:RadioButtonList ID="rblIsMale" runat="server" RepeatColumns="2">
    <asp:ListItem Value="true">男</asp:ListItem>
    <asp:ListItem Value="false">女</asp:ListItem>
    </asp:RadioButtonList>
</td><td class="auto-style2" colspan="2" style="text-align:right">
        <asp:Button ID="btnSubmit" runat="server" Text="修改" onclick="btnSubmit_Click" />
</td></tr>
</table>
    <br />
    <div id="divResult" runat="server"></div>
</center>
</asp:Content>
