<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" 
    MasterPageFile="MainMaster.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2><a href="#">公司新闻</a></h2>
    <ul>
        <asp:Repeater ID="rptNews" runat="server">
        <ItemTemplate>
        <li>
            <a href='<%# "News.aspx?id=" + Eval("ID") %>'>
                <%# Eval("Title") %></a> 
            [<%# Eval("PublishTime") %>]
        </li>
        </ItemTemplate>
        </asp:Repeater>
    </ul>
    <h2>最新<a href="#">产品</a></h2>
    <p>
        <asp:DataList ID="dlProduct" runat="server" RepeatColumns="8" Height="36px" Width="810px">
            <ItemTemplate>
            <a href='<%# "Product.aspx?id=" + Eval("ID") %>'>
                <img alt='<%# Eval("Name") %>' width="50" height="70"
                    src='<%# Eval("Picture") %>' style=" margin:5px; border:solid 1px #666;" />
            </a>
            </ItemTemplate>
        </asp:DataList>
    </p>
</asp:Content>
