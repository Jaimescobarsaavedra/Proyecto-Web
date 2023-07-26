<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Proyecto_Web.Usuarios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Nombre" CssClass="badge"></asp:Label><asp:RequiredFieldValidator ID="pass" runat="server" ControlToValidate="TXTnombre" ErrorMessage="Agrega un nombre"
ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:TextBox ID="TXTnombre" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="fecha nacimiento" CssClass="badge"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TXTfecha" ErrorMessage="Agrega un fecha"
ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:TextBox ID="TXTfecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="Sexo" CssClass="badge"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TXTsexo" ErrorMessage="Agrega un sexo"
ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:DropDownList ID="TXTsexo" runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Masculino</asp:ListItem>
        <asp:ListItem>Femenino</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Enviar" CssClass="btn-default" OnClick="Button1_Click" BackColor="#33CCFF" />
    <asp:Button ID="Button2" runat="server" Text="Actualizar" BackColor="#99FFCC" CssClass="btn-default" OnClick="Button2_Click" />
    <asp:Label ID="Label4" runat="server"></asp:Label>
</asp:Content>
