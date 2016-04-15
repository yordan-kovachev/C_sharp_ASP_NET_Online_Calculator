<%@ Page Title="Online Calculator" Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" 
    Inherits="Calculator.WebApp._Default"
    MaintainScrollPositionOnPostBack="true"
    ViewStateEncryptionMode="Always"%>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title + " - Desktop version written in ASP.NET" %>.</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <table>
        <tr>
            <td colspan="6"></td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="entryStatusLabel" colspan="6" runat="server" Font-Bold="True"
                    Font-Size="X-Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:TextBox ID="resultTextBox" runat="server" Height="23px" Width="530px"
                    TextMode="SingleLine" Font-Bold="True" Font-Size="X-Large" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="button7" runat="server" Height="50px" Text="7"
                    Width="70px" OnClientClick="button7" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="button8" runat="server" Height="50px" Text="8"
                    Width="70px" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="button9" runat="server" Height="50px" Text="9"
                    Width="70px" OnClick="buttonNumber_Click" />
            </td>
            <td>
             <asp:Button ID="buttonDivide" runat="server" Height="50px" Text="/"
                    Width="70px" ForeColor="Black" OnClick="buttonDivide_Click" />
            </td>
            <td>
                <asp:Button ID="buttonNegative" runat="server" Height="50px" Text="-"
                    Width="72px" OnClick="buttonNegative_Click" />
                <asp:Button ID="buttonPercentage" runat="server" Height="50px" Text="%"
                    Width="72px" OnClick="bottonPercentage_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="button4" runat="server" Height="50px" Text="4"
                    Width="70px" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="button5" runat="server" Height="50px" Text="5"
                    Width="70px" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="button6" runat="server" Height="50px" Text="6"
                    Width="70px" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="buttonMultiply" runat="server" Height="50px" Text="X"
                    Width="70px" OnClick="buttonMultiply_Click" />
            </td>
            <td>
                <asp:Button ID="buttonClear" colspan="2" runat="server" style="background-color:IndianRed; color: white" Height="50px" Text="CLEAR ALL"
                    Width="150px" OnClick="buttonClear_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="button1" runat="server" Height="50px" Text="1"
                    Width="70px" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="button2" runat="server" Height="50px" Text="2"
                    Width="70px" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="button3" runat="server" Height="50px" Text="3"
                    Width="70px" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="buttonMinus" runat="server" Height="50px" Text="-"
                    Width="70px" OnClick="buttonMinus_Click" />
            </td>
            <td>
                <asp:Button ID="buttonDelete" colspan="2" runat="server" style="background-color: orange; color: white" Height="50px" Text="DELETE"
                    Width="150px" OnClick="buttonDelete_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:Button ID="button0" runat="server" Height="50px" Text="0"
                    Width="170px" OnClick="buttonNumber_Click" />
            </td>
            <td>
                <asp:Button ID="buttonPeriod" runat="server" Height="50px" Text="."
                    Width="70px" OnClick="buttonPeriod_Click" />
            </td>
            <td>
                <asp:Button ID="buttonPlus" runat="server" Height="50px" Text="+"
                    Width="70px" OnClick="buttonPlus_Click" />
            </td>
            <td>
                <asp:Button ID="buttonEquals" colspan="2" runat="server" style="background-color:DarkTurquoise; color: white" Height="50px" Text="="
                    Width="150px" OnClick="buttonEquals_Click" />
            </td>
            
        </tr>
    </table>  

</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 40px;
        }
    </style>
</asp:Content>


