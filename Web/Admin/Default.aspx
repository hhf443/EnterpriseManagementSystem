<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Admin.Default" %>

<!DOCTYPE html>

<HTML>
<head runat="server">
<TITLE>管理中心登陆</TITLE>
<META http-equiv=Content-Type content="text/html; charset=gb2312">
<LINK href="css/admin.css" type="text/css" rel="stylesheet">
<style>
.input{BORDER-RIGHT: #000000 1px solid; BORDER-TOP: #000000 1px solid; BORDER-LEFT: #000000 1px solid; BORDER-BOTTOM: #000000 1px solid}
    .auto-style1 {
        font-family: 华文行楷;
        font-size: xx-large;
        border-left-color: #A0A0A0;
        border-right-color: #C0C0C0;
        border-top-color: #A0A0A0;
        border-bottom-color: #C0C0C0;
        background-color:#20B2AA;
        height: 179px;
        }
    .auto-style2 {
        border-left-color: #A0A0A0;
        border-right-color: #C0C0C0;
        border-top-color: #A0A0A0;
        border-bottom-color: #C0C0C0;
        background-color: #20B2AA;
    }
</style>
</head>
<BODY>
    <form id="form1" runat="server">
 <TABLE cellSpacing=0 cellPadding=0 border=0 
     style="height:700px;width:100%;background-image:url(images/loginback.gif);background-repeat:no-repeat;background-size:100%">
  <TR>
    <TD align=middle>
      <TABLE cellSpacing=0 cellPadding=0 border=0 align="center" width="468px">
        <tr>
            <td></td>
        </tr>
        <TR>
          <TD class="auto-style1" style="text-align:center"><em><span class="auto-style2">后台登陆系统</span></em></TD>
        </TR>
      </TABLE>
      <TABLE cellSpacing=0 cellPadding=0 width=468 bgColor=#ffffff border=0>
        <TR>
          <TD width=16></TD>
          <TD align=middle>
            <TABLE cellSpacing=0 cellPadding=0 width=230 border=0>
              <TR height=5>
                <TD width=5></TD>
                <TD width=56></TD>
                <TD></TD></TR>
              <TR height=36>
                <TD></TD>
                <TD>用户名</TD>
                <TD>
                    <asp:TextBox ID="txtLoginName" runat="server" MaxLength="30" CssClass="input"></asp:TextBox>
                </TD></TR>
              <TR height=36>
                <TD>&nbsp; </TD>
                <TD>口　令</TD>
                <TD>
                    <asp:TextBox ID="txtPassword" runat="server" MaxLength="30" CssClass="input" TextMode="Password"></asp:TextBox>
                </TD>
              </TR>
              <TR height=5><TD colSpan=3></TD></TR>
              <TR>
                <TD>&nbsp;</TD>
                <TD>&nbsp;</TD>
                <TD>
                    <asp:ImageButton ID="imgbtnLogin" runat="server" ImageUrl="images/bt_login.gif" 
                        Height="18" Width="70" onclick="imgbtnLogin_Click" />
                </TD>
              </TR>
            </TABLE>
          </TD>
          <TD width=16></TD></TR></TABLE>
      <TABLE cellSpacing=0 cellPadding=0 width=468 border=0>
        <TR>
          <TD></TD></TR></TABLE>
      <TABLE cellSpacing=0 cellPadding=0 width=468 border=0>
        <TR>
          <TD align=right>&nbsp;</TD></TR></TABLE></TD></TR></TABLE>
    </form>
</body>
</html>
