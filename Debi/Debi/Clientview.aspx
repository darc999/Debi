<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientview.aspx.cs" Inherits="Debi.Clientview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header>
            <img class="navLogo" src="logo_1.png">
            <asp:Button ID="Button4" Style="padding: 9px 25px; color:white; background-color: rgba(0,136,169,1); border:none; border-radius: 50px; cursor: pointer;" runat="server" Text="Login" OnClick="Button1_Click" />

        </header>
        <section style="width:100%;">
            <div class="search01"">
                <table style="text-align:center;">
                    <tr>
                        <th colspan="2" style="height: 40px"><asp:Label ID="Label3" Style="font-size:25px;" runat="server" Text="Search Hotels"></asp:Label></th>
                    </tr>
                    <tr>
                        <td style="height:40px;">
                            <asp:Label ID="Label4" runat="server" Text="Hotel Name"></asp:Label>
                            <asp:TextBox ID="name" runat="server"></asp:TextBox>
                        </td>
                        <td style="height:40px;">
                            <asp:Label ID="Label8" runat="server" Text="Location"></asp:Label>
                            <asp:TextBox ID="location" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height:40px;">
                            <asp:Button style="padding: 9px 25px; color:white; background-color: rgb(255, 106, 0); border:none; border-radius: 50px; cursor: pointer;" ID="Button1" runat="server" OnClick="search_Click" Text="Search" />
                        </td>
                    </tr>
                </table>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" Height="16px" Width="355px">
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </div>
        </section>
        <br> <asp:GridView ID="GridView2" runat="server">
                </asp:GridView><br>
        <section style="width:100%;">
            <div class="search01"">
                <table style="text-align:center; padding-top:20px;">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Search Rooms in "></asp:Label>
                            <asp:TextBox ID="name2" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Show Images In "></asp:Label>
                            <asp:TextBox ID="roomidd" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button Style="padding: 9px 25px; color:white; background-color: rgb(255, 106, 0); border:none; border-radius: 50px; cursor: pointer;" ID="Button5" runat="server" OnClick="Button2_Click" Text="Search" />
                        </td>
                        <td>
                            <asp:Button Style="padding: 9px 25px; color:white; background-color: rgb(255, 106, 0); border:none; border-radius: 50px; cursor: pointer;" ID="Button2" runat="server" Text="Show" OnClick="Button3_Click" />
                        </td>
                       
                    </tr>
                </table>

               
                <asp:GridView ID="GridView3" runat="server"  AutoGenerateColumns="True" >
                <Columns>
                    <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" ImageUrl='<%# "data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("ImageData")) %>' />
                    </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                    </asp:GridView>
            </div>
        </section>
    </div>
    </form>
    <!--<footer>
        <p style="width:100;">Copyright @ 2022 Debi Hotel | Powered and Designed by Deneth Chamodya</p> 
    </footer>-->
</body>
</html>
