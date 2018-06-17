<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Master.master" AutoEventWireup="true" CodeFile="Istoric membri.aspx.cs" Inherits="Istoric_membri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Istoric membri</h2>
    Id membru : 
    <asp:TextBox ID="txtIdMembru" runat="server"></asp:TextBox> <p />   <asp:Button ID="btnAfisIstoric" runat="server" Text="Afiseaza istoric" />
    <p />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="Istoric_membru" TypeName="Biblioteca">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtIdMembru" Name="Id_membru" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
        </asp:ObjectDataSource>
</asp:Content>

