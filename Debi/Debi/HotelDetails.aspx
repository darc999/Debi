<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HotelDetails.aspx.cs" Inherits="Debi.WebForm1" %>

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
                    <td rowspan="10" style="width: 300px; text-align:center; background: #faa300; border-radius:5px;"><asp:Label ID="Label8" style="font-size: 35px;" runat="server" Text="Registration"></asp:Label></td>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label9" runat="server" Text="Hotel ID :"></asp:Label>
                    </td >
                    <td style="height:40px;">
                        <asp:TextBox ID="hid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label10" runat="server" Text="Password :"></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="pswrd" runat="server" required></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label11" runat="server" Text="Hotel Name :"></asp:Label>
                    </td>
                    <td style="height:40px;">
                            <asp:TextBox ID="htlname" runat="server" required></asp:TextBox>
                    </td>
                </tr>   
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label12" runat="server" Text="Location :"></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="loc" runat="server"  required></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label13" runat="server" Text="PhoneNumber :"></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="pnum" runat="server" required></asp:TextBox>
                    </td>
                </tr> 
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label14" runat="server" Text="Description :"></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="dsc" runat="server" required></asp:TextBox>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td colspan="2" style="height:40px; ">
                        <asp:Button Style="padding: 9px 25px; color:white; background-color: rgba(0,136,169,1); border:none; border-radius: 50px; cursor: pointer;" ID="Button3" runat="server" Text="Register" OnClick="Button1_Click" />
                        <asp:Button Style="padding: 9px 25px; color:white; background-color: rgba(0,136,169,1); border:none; border-radius: 50px; cursor: pointer;" ID="Button4" runat="server" Text="Clear" OnClick="Button2_Click" />

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
