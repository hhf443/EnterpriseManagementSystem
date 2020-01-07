<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="Web.NewsList" MasterPageFile="MainMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h2><a href="#">公司新闻</a></h2>

<ul>
    <asp:Repeater ID="rptNews" runat="server">
    <ItemTemplate>
    <li><a href='<%# "News.aspx?id=" + Eval("ID") %>'><%# Eval("Title") %></a> [<%# Eval("PublishTime") %>]</li>
    </ItemTemplate>
    </asp:Repeater>
</ul>

</asp:Content>

