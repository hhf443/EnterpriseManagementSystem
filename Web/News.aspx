<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Web.News" 
    MasterPageFile="MainMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h2>公司新闻</h2>
<h3><asp:Label ID="lblTitle" runat="server"></asp:Label></h3>
<p><asp:Label ID="lblContent" runat="server"></asp:Label></p>
<p style="text-align:right;"><asp:Label ID="lblPublishTime" runat="server"></asp:Label></p>

</asp:Content>