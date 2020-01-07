<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" 
    MasterPageFile="~/MainMaster.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>用户登录</h2>
    <br />

    <table style="margin: auto; height: 154px; width: 297px;text-align:left">
        <tr><td class="auto-style2">用户名：</td><td class="auto-style2"><asp:TextBox ID="txtLoginName" runat="server"></asp:TextBox></td></tr>
        <tr><td class="auto-style2">密码：</td><td class="auto-style2"><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td></tr>
        <tr>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnLogin" runat="server" Text="登录" onclick="btnLogin_Click" />　
                <asp:Button ID="btnRegister" runat="server" Text="注册" PostBackUrl="Register.aspx" />
            </td>
        </tr>
    </table>

    <br />
    <br />
    <br />
</asp:Content>

