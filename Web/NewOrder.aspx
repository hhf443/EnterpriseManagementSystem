<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewOrder.aspx.cs" Inherits="Web.NewOrder" MasterPageFile="MainMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h2>订购产品</h2>
<table cellpadding="5">
<tr><td>产品名称：</td><td><asp:Label ID="lblProductName" runat="server"></asp:Label></td></tr>
<tr><td>价格：</td><td><asp:Label ID="lblPrice" runat="server"></asp:Label></td></tr>
<tr><td>订购数量：</td><td><asp:TextBox ID="txtNumber" runat="server" CssClass="narrow"></asp:TextBox></td></tr>
<tr><td>详细说明：</td><td><asp:TextBox ID="txtDetails" runat="server" TextMode="MultiLine"></asp:TextBox></td></tr>
<tr><td></td><td><asp:Button ID="btnSubmit" runat="server" Text="订购" 
        onclick="btnSubmit_Click" /></td></tr>
</table>

</asp:Content>

