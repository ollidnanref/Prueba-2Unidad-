<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Estadistica.aspx.cs" Inherits="CapaDePresentaciones.Estadistica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>ESTADISTICAS</h1>

    <table>
        <tr>
            <td>
                Número total de vehiculos por dia
            </td>
        </tr>
        <tr>
            <td>
                Ingrese dia:
                <asp:TextBox ID="txtDia" runat="server" Width="30px"></asp:TextBox>
            </td>
            <td>
                Ingrese mes: 
                <asp:TextBox ID="txtMes" runat="server" Width="30px"></asp:TextBox>
            </td>
            <td>
                Ingrese año
            <asp:TextBox ID="txtAno" runat="server" Width="50px"></asp:TextBox>
                </td>
            <td>
                <asp:Button ID="btnDia" runat="server" Text="Calcular" OnClick="btnDia_Click" />
            </td>
            <td>
                <asp:Label ID="lblPorDia" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Total Alumnos y Docentes
            </td>
        </tr>
        <tr>
            <td>
                Total Alumnos: 
            </td>
            <td>
                <asp:Label ID="lblTotalAlumnos" runat="server" Text=""></asp:Label>
            </td>
            <td>
                Total Docentes:
            </td>
            <td>
                <asp:Label ID="lblTotalDocentes" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnTotalAlumnosDocentes" runat="server" Text="Calcular" OnClick="btnTotalAlumnosDocentes_Click" />
            </td>
        </tr>
        <tr>
            <td>
                Numero total de vehiculos por rango de fecha (Hora)
            </td>
        </tr>
        <tr>
            <td>
                Desde: <asp:TextBox ID="txtMenor" runat="server"></asp:TextBox>
            </td>
            <td>
                Hasta: <asp:TextBox ID="txtMayor" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
            </td>
            <td>
                <asp:Label ID="lblTotalPorHoras" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                ListarVehiculos que se encuentren en el estacionamiento por alumno o docente
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlTipo" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnSegunTipo" runat="server" Text="Calcular" OnClick="btnSegunTipo_Click" />
            </td>
            <td>
                <asp:Label ID="lblSegunTipo" runat="server" Text=""></asp:Label>
            </td>
        </tr>

    </table>

</asp:Content>
