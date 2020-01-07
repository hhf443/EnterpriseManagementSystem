<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Web.ProductList" MasterPageFile="MainMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>最新<a href="#">产品</a></h2>
<p>
    <asp:DataList ID="dlProduct" runat="server" RepeatColumns="5" Height="200px" OnSelectedIndexChanged="dlProduct_SelectedIndexChanged" Width="638px">
    <ItemTemplate>
    <a href='<%# "Product.aspx?id=" + Eval("ID") %>'>
        <img alt='<%# Eval("Name") %>' width="75" height="90" src='<%# Eval("Picture") %>' style=" margin:5px; border:solid 1px #666;" />
    </a>
    </ItemTemplate>
    </asp:DataList>
</p>
</asp:Content>
