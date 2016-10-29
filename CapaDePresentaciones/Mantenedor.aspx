<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Mantenedor.aspx.cs" Inherits="CapaDePresentaciones.IngresoDeRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MANTENEDOR</h1>

    <table>
        <tr>
            <td>
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Patente"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPatente" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnConsultarVehiculo" runat="server" Text="Consultar Vehiculo" OnClick="btnConsultarVehiculo_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Marca"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Color"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Tipo Personal"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlTipoPersonal" runat="server"></asp:DropDownList>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Nombre Personal"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombrePersonal" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Fecha de Ingreso"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFechaIngreso" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnHoraIngreso" runat="server" Text="Hora Actual" OnClick="btnHoraIngreso_Click" />
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="(*) Formato fecha: '2000-01-01 00:00:00'" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Fecha de Salida"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFechaSalida" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnHoraSalida" runat="server" Text="Hora Actual" OnClick="btnHoraSalida_Click" />
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="(*) Formato fecha: '2015-12-31 23:59:59'" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnRegistrarIngreso" runat="server" Text="Registrar Ingreso" OnClick="btnRegistrarIngreso_Click" />
            </td>
            <td>
                <asp:Button ID="btnEditarRegistro" runat="server" Text="Editar Registro" OnClick="btnEditarRegistro_Click" />
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Registro" OnClick="btnEliminar_Click" />
            </td>
        </tr>
    </table>

    
    
    
 
    <br />
</asp:Content>
