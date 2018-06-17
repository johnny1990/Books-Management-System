<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Master.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Raport rezervari</h2>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        DataSourceID="ObjectDataSource1">
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="Raport_rezervari" TypeName="Biblioteca"></asp:ObjectDataSource>
</asp:Content>
