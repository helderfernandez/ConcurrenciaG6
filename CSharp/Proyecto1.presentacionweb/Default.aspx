<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto1.presentacionweb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="width: 175px"><strong>Asincrono</strong></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbid" runat="server" BackColor="#FFFFCC">Automatico</asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label3" runat="server" Text="Apellido paterno"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbApellidoPaterno" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label4" runat="server" Text="Apellido materno"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbApellidomaterno" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label5" runat="server" Text="Genero"></asp:Label>
            </td>
            <td>
                <asp:RadioButton ID="rbMAsculino" runat="server" GroupName="a" Text="Masculino" />
                <asp:RadioButton ID="rbFemenino" runat="server" GroupName="a" Text="Femenino" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label6" runat="server" Text="Fecha nacimiento"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbFechaNacimiento" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label7" runat="server" Text="Documento identidad"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbDocumentoIdentidad" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label8" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbDireccion" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label9" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbTelefono" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label10" runat="server" Text="Correo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbCorreo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label11" runat="server" Text="Nit"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbNit" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label12" runat="server" Text="Rubro"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cbRubro" runat="server" Height="36px" Width="200px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Label ID="Label13" runat="server" Text="Ciudad"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cbCiudad" runat="server" Height="36px" Width="199px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">&nbsp;</td>
            <td>
                <asp:Label ID="Label14" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">
                <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
</asp:Content>
