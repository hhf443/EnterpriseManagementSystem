<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Web.Product" MasterPageFile="MainMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h2>最新产品</h2>
<center><h3><asp:Label ID="lblName" runat="server" style="font-size: x-small"></asp:Label></h3></center>
<center><asp:Image ID="imgPicture" runat="server" Width="79px" Height="82px" />
    <br />
    </center>
    <center>价格：<asp:Label ID="lblPrice" runat="server"></asp:Label>元　　　　　[
<asp:HyperLink ID="hlProduct" runat="server">订购该产品</asp:HyperLink>]</center>
<p><asp:Label ID="lblDetails" runat="server"></asp:Label></p>

</asp:Content>
