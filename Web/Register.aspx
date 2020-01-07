<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web.Register" MasterPageFile="MainMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript" src="js/jquery-3.4.1.js"></script>
    <style type="text/css">
        .auto-style4 {
            width: 359px;
        }
        .auto-style5 {
            width: 310px;
        }
        .auto-style6 {
            width: 326px;
        }
        .infocolor{
            color: red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>注册会员</h2>
<br />
<center>
<table cellpadding="5" style="height: 182px; width: 718px">
<tr><td class="auto-style6">用户名：</td><td class="auto-style5"><asp:TextBox ID="txtLoginName" runat="server" MaxLength="20"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" 
        ControlToValidate="txtLoginName" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td><td class="auto-style5">年龄：</td><td class="auto-style4"><asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
    </td></tr>
<tr><td class="auto-style6">密码：</td><td class="auto-style5"><asp:TextBox ID="txtPassword" runat="server" 
    TextMode="Password" MaxLength="20"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
        ControlToValidate="txtPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td><td class="auto-style5">电话：</td><td class="auto-style4"><asp:TextBox ID="txtPhone" runat="server" MaxLength="20"></asp:TextBox>
    </td></tr>
<tr><td class="auto-style6">重复密码：</td><td class="auto-style5"><asp:TextBox ID="txtRePassword" 
    runat="server" TextMode="Password" MaxLength="20"></asp:TextBox>
    <br />
    <asp:CompareValidator ID="cvPassword" runat="server" 
        ControlToCompare="txtRePassword" ControlToValidate="txtPassword" 
        ErrorMessage="两次密码需一致。" CssClass="infocolor"></asp:CompareValidator>
    </td><td class="auto-style5">邮箱：</td><td class="auto-style4"><asp:TextBox ID="txtEmail" runat="server" MaxLength="50"></asp:TextBox>
    </td></tr>
<tr><td class="auto-style6">性别：</td><td class="auto-style5">
    <asp:RadioButtonList ID="rblIsMale" runat="server" RepeatColumns="2">
    <asp:ListItem Value="true" Selected>男</asp:ListItem>
    <asp:ListItem Value="false">女</asp:ListItem>
    </asp:RadioButtonList>
</td><td class="auto-style5">
        地址：</td><td class="auto-style4">
        <asp:TextBox ID="txtAddress" runat="server" MaxLength="255"></asp:TextBox>
</td></tr>
<tr><td colspan="4" style="text-align:right"><asp:Button ID="btnSubmit" runat="server" Text="提交" 
        onclick="btnSubmit_Click" />　　<asp:Button ID="btnLogin" runat="server" Text="返回登录" 
        CausesValidation="false" PostBackUrl="Login.aspx" /></td></tr>
</table>
</center>
<br />
</asp:Content>

