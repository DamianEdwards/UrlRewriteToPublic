<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="UrlRewriteToPublic.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        You got to a Web Form! p1=<%: Request.QueryString["p1"] %><br />
        <asp:HyperLink runat="server" NavigateUrl="~/">Click here to go home again</asp:HyperLink>
    </div>
    </form>
</body>
</html>
