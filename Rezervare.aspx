﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Master.master" AutoEventWireup="true" CodeFile="Rezervare.aspx.cs" Inherits="Rezervare" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Rezervare carte</h2>
<table>
 <tr>
  <td>
     Id carte : 
  </td>
  <td>
      <asp:TextBox ID="txtIdCarte" runat="server"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1"   runat="server" 
          ErrorMessage="RequiredFieldValidator" ControlToValidate="txtIdCarte" 
          Display="Dynamic">*</asp:RequiredFieldValidator>
  </td>
 </tr>
 <tr>
  <td>
    Id membru : 
  </td>
  <td>
      <asp:TextBox ID="txtIdMembru" runat="server"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
          ErrorMessage="RequiredFieldValidator" ControlToValidate="txtIdMembru" 
          Display="Dynamic">*</asp:RequiredFieldValidator>
  </td>
 </tr>
</table>
<p />
    <asp:Button ID="btnRezerva" runat="server" Text="Rezervare" 
        onclick="btnRezerva_Click" />
    <p />
    <asp:Label ID="lblMsg" runat="server" Text="" EnableViewState ="false"></asp:Label>
</asp:Content>

