<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Master.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Carti adaugate recent</h2>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="Titlu" HeaderText="Titlu" />
            <asp:BoundField DataField="Autori" HeaderText="Autori" />
            <asp:BoundField DataField="Editura" HeaderText="Editura" />
            <asp:BoundField DataField="Data_adaugare" HeaderText="Adaugat" />
            <asp:BoundField DataField="Disponibilitate" HeaderText="Este disponibil?" />
        </Columns>
         
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="Afiseaza_carti_adaugate_recent" TypeName="Biblioteca"></asp:ObjectDataSource>
</asp:Content>

