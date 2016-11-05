<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="ZodiacBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="GetDate" OnClick="Button1_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Date: "></asp:Label>
        <asp:TextBox ID="DateBox" runat="server" ></asp:TextBox>
        <br />
    

        <asp:Label ID="Label3" runat="server" Text="Mon:   "></asp:Label>
        <asp:TextBox ID="MonBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Day:   "></asp:Label>
        <asp:TextBox ID="DayBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="GetName" OnClick="Button2_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Name: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>

    <br />
    <br />

    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Selected="True">Brisbane</asp:ListItem>
            <asp:ListItem>New Farm</asp:ListItem>
            <asp:ListItem>Bowen Hills</asp:ListItem>
            <asp:ListItem>Hamilton</asp:ListItem>
            <asp:ListItem>Eagle Farm</asp:ListItem>
            <asp:ListItem>Albion Bc</asp:ListItem>
            <asp:ListItem>Clayfield</asp:ListItem>
            <asp:ListItem>Lutwyche</asp:ListItem>
            <asp:ListItem>Alderley</asp:ListItem>
            <asp:ListItem>Kelvin Grove</asp:ListItem>
            <asp:ListItem>Ashgrove</asp:ListItem>
            <asp:ListItem>Milton</asp:ListItem>
            <asp:ListItem>Bardon</asp:ListItem>
            <asp:ListItem>St Lucia</asp:ListItem>
            <asp:ListItem>Uni of Queensland</asp:ListItem>
            <asp:ListItem>Highgate Hill</asp:ListItem>
            <asp:ListItem>Dutton Park</asp:ListItem>
            <asp:ListItem>East Brisbane</asp:ListItem>
            <asp:ListItem>Cannon Hill</asp:ListItem>
            <asp:ListItem>Balmoral</asp:ListItem>
            <asp:ListItem>Murarrie</asp:ListItem>

        </asp:DropDownList>
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="ShowPostCode" OnClick="Button3_Click"/>
        <br />
        <asp:Label ID="CodeLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="TimeLabel" runat="server"></asp:Label>



    </asp:Content>
