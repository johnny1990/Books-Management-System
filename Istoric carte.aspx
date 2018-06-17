<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Master.master" AutoEventWireup="true" CodeFile="Istoric carte.aspx.cs" Inherits="Istoric_carte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Istoric carte</h2>
Id carte : 
    <asp:TextBox ID="txtIdCarte" runat="server"></asp:TextBox> <p />   <asp:Button ID="btnAfisIstoric" runat="server" Text="Afiseaza istoric carte" />
    <p />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="Istoric_carte" TypeName="Biblioteca">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtIdcarte" Name="Id_carte" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
        </asp:ObjectDataSource>
</asp:Content>


