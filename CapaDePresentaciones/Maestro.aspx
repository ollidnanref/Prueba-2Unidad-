<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Maestro.aspx.cs" Inherits="CapaDePresentaciones.Maestro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>AUTOS QUE SE ENCUENTRAN EN EL ESTACIONAMIENTO</h1>

    <asp:GridView ID="gvRegistros" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            
            <asp:BoundField DataField="Patente" HeaderText="Patente" SortExpression="Patente" />
            <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="TipoPersonal" HeaderText="TipoPersonal" SortExpression="TipoPersonal" />
            <asp:BoundField DataField="NombrePersonal" HeaderText="NombrePersonal" SortExpression="NombrePersonal" />
            <asp:BoundField DataField="FechaIngreso" HeaderText="FechaIngreso" SortExpression="FechaIngreso" />
            
        </Columns>
    </asp:GridView>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ReadAll" TypeName="CapaDeNegocios.RegistroAccesoCollection"></asp:ObjectDataSource>

</asp:Content>
