<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Master.master" AutoEventWireup="true" CodeFile="Cautare carti.aspx.cs" Inherits="Cautare_carti" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Cauta carti</h2>
  Title : 
      <asp:TextBox ID="txtTitlu" runat="server"></asp:TextBox>
  Author : 
      <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox>
   <p />
   <asp:Button ID="btnCauta" runat="server" Text="Cauta" onclick="btnCauta_Click" />
   <p />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns ="False">
      <Columns>
            <asp:BoundField DataField="Id_carte" HeaderText="Id carte" />
            <asp:BoundField DataField="Titlu" HeaderText="Titlu" />
            <asp:BoundField DataField="Autori" HeaderText="Autori" />
            <asp:BoundField DataField="Editura" HeaderText="Editura" />
            <asp:BoundField DataField="Disponibilitate" HeaderText="Este disponibil?" />
            <asp:HyperLinkField DataNavigateUrlFields="Id_carte" 
                DataNavigateUrlFormatString="Rezervare.aspx?Id carte={0}" Text="Rezerva" />
        </Columns>
    </asp:GridView>

</asp:Content>

