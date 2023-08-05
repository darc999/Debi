<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Debi.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" href="StyleSheet1.css">
</head>
<body>
    <header>
            <img class="navLogo" src="logo_1.png">
    </header>


    <form id="form1" runat="server">

         <div style="padding-top:40px;">
            <table class="RegTable">
                <tr>
                    <td rowspan="10" style="width: 300px; text-align:center; background: #faa300; border-radius:5px;"><asp:Label style="font-size: 35px;" ID="Label4" runat="server" Text="Login Here"></asp:Label></asp:Label></td>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label5" runat="server" Text="Hotel ID :"></asp:Label>
                    </td >
                    <td style="height:40px;">
                        <asp:TextBox ID="UN" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label6" runat="server" Text="Password :"></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="PW" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td colspan="2" style="height:40px; ">
                        <asp:Label ID="rslt" runat="server"></asp:Label>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" />
                        
                    </td>
                </tr>            
            </table>
        </div>       
    </form>
    <footer>
        <p style="width:100;">Copyright @ 2022 Debi Hotel | Powered and Designed by Deneth Chamodya</p> 
    </footer>
</body>
</html>
