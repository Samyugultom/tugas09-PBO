<%@ Page Title="KosEmpatMata" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="pbo_tm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        #btnInsertion {
            background-color: rgb(80, 73, 136);
            border-radius: 20px;
            padding: 10px;
            color: white;
            border: none;
        }
        #btnUpdation {
            background-color: rgb(71 146 119);
            border-radius: 20px;
            padding: 10px;
            color: white;
            border: none;
        }
        #btnSelect{
            background-color: rgb(78 111 152);
            border-radius: 20px;
            padding: 10px;
            color: white;
            border: none;
        }
        #btnDelete{
            background-color: rgb(186 96 44);
            border-radius: 20px;
            padding: 10px;
            color: white;
            border: none;
        }
        input[type=text]{
            border-radius: 10px;
            padding: 10px;
        }
        form{
            display: flex;
            flex-direction: row;
            align-items: start;
        }
        table{
            margin-right: 50px;
            margin-left: 50px;
        }
        body{
            display: flex;
            justify-content: center;
            align-items: center;
        }
    </style>
    <table>  
    <tr>  
        <td colspan="2">  
            <h1>Insertion</h1>  
        </td>  
    </tr>  
    <tr>  
        <td> ID ruangan</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtkosID" runat="server" ForeColor="Purple"></asp:TextBox >  
        </td>  
    </tr>  
    <tr>  
        <td> nama ruangan</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtkosnameR" runat="server" ForeColor="Purple" ></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td> nama penyewa</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtkosnameP" runat="server"  ForeColor="Purple" ></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td> fasilitas ruangan</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtkosfasilitas" runat="server"  ForeColor="Purple" ></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td colspan="2">  
            <asp:Button ID="btnInsertion"  ForeColor="Blue" runat="server" Text="Insert" OnClick="btnInsertion_Click" Style="width: 48px" />  
            <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>  
            <asp:Button ID="btnUpdation"  ForeColor="Blue" runat="server" Text="Update" OnClick="btnUpdation_Click" />
        </td>  
    </tr>  
</table> 
    <table>  
    <tr>  
        <td>  
            <h1>Selection</h1>  
        </td>  
    </tr>  
    <tr>  
        <td>  
            <asp:Button ID="btnSelect" runat="server" ForeColor="Blue" Text="Select All Data" OnClick="btnSelect_Click" />  
        </td>  
    </tr>  
    <tr>  
        <td>  
            <asp:GridView ID="GridView1"  ForeColor="Blue" runat="server"></asp:GridView>  
        </td>  
    </tr>  
</table> 


<table>  
    <tr>  
        <td colspan="3">  
            <h1>Deletion</h1>  
        </td>  
    </tr>  
    <tr>  
        <td> ID Ruangan</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtRuanganID" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr >  
        <td colspan="3">  
            <asp:Button ID="btnDelete"  ForeColor="Red" runat="server" Text="Delete" OnClick="btnDelete_Click" />  
            <asp:Label ID="lblmessage" runat="server" ForeColor="Red"></asp:Label>  
        </td>  
    </tr>  
</table>  

</asp:Content>
