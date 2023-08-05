<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Imageupload1.aspx.cs" Inherits="Debi.Imageupload1" %>

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
                    <td rowspan="10" style="width: 300px; text-align:center; background: #faa300; border-radius:5px;"><asp:Label style="font-size: 35px;" ID="Label2" runat="server" Text="Room Management"></asp:Label></td>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label7" runat="server" Text="Upload Image"></asp:Label>
                    </td >
                    <td style="height:40px;">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label8" runat="server" Text="Hotel ID "></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="hid2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label9" runat="server" Text="Room Type"></asp:Label>
                    </td>
                    <td style="height:40px;">
                       <asp:DropDownList ID="type" runat="server">
                            <asp:ListItem>Deluxe</asp:ListItem>
                            <asp:ListItem>Suit</asp:ListItem>
                            <asp:ListItem>Standard</asp:ListItem>
                       </asp:DropDownList>
                        
                    </td>
                </tr>   
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label10" runat="server" Text="Price "></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="prc" runat="server"></asp:TextBox>
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label11" runat="server" Text="Availabilty"></asp:Label>
                    </td>
                    <td style="height:40px;">
                        Yes:<asp:RadioButton ID="yes1" runat="server" />
                        No:<asp:RadioButton ID="no1" runat="server" />
                        <asp:Label ID="lbltx" runat="server"></asp:Label>
                    </td>
                </tr> 
                <tr>
                    <td style="height:40px; padding-left:10px;">
                        <asp:Label ID="Label14" runat="server" Text="Description :"></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="TextBox6" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height:40px; padding-left:10px;">
                       <asp:Label ID="Label3" runat="server" Text="Room ID"></asp:Label>
                    </td>
                    <td style="height:40px;">
                        <asp:TextBox ID="rid" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td colspan="2" style="height:40px; ">
                        <asp:Button ID="btnUpload" Style="padding: 9px 25px; color:white; background-color: rgba(0,136,169,1); border:none; border-radius: 50px; cursor: pointer;" runat="server" Text="Add" OnClick="btnUpload_Click" />
                        <asp:Button ID="Button1" Style="padding: 9px 25px; color:white; background-color: rgba(0,136,169,1); border:none; border-radius: 50px; cursor: pointer;" runat="server" Text="Show" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" Style="padding: 9px 25px; color:white; background-color: rgba(0,136,169,1); border:none; border-radius: 50px; cursor: pointer;" runat="server" OnClick="Button2_Click" Text="Update" />
                        <asp:Button ID="Button3" Style="padding: 9px 25px; color:white; background-color: rgba(0,136,169,1); border:none; border-radius: 50px; cursor: pointer;" runat="server" OnClick="Button3_Click" Text="Delete" />
                     
                    </td>
                </tr>            
            </table>
        </div> 

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True">
            <Columns>
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" ImageUrl='<%# "data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("ImageData")) %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
   
</body>
</html>
