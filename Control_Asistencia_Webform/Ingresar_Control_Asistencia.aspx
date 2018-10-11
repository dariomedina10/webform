<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingresar_Control_Asistencia.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.Ingresar_Control_Asistencia" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table border="5" cellspacing="2" 
            style="border: thin solid goldenrod; FONT-SIZE: 14px; LEFT: 0px; MARGIN: 5px; VERTICAL-ALIGN: middle; WIDTH: 61%; COLOR: navy; FONT-FAMILY: 'Arial Rounded MT Bold', Arial, Verdana, Tahoma; POSITION: relative; TOP: 0px; TEXT-ALIGN: left">
            <tr>
                <td colspan="3" style="HEIGHT: 40px; BACKGROUND-COLOR:transparent">
                    <p style="FONT-SIZE: 16pt; COLOR::#034af3; LINE-HEIGHT: 24pt; TEXT-ALIGN: center">
                        Ingresar Control de Asistencia</p>
                </td>
            </tr>
                   <tr>
                <td style="WIDTH: 25%">
                    Fecha </td>
                <td style="WIDTH: 50%">
                    <asp:TextBox ID="fecha_ingreso" runat="server" Width="165px"></asp:TextBox>
                </td>
                <td style="WIDTH: 25%">
                    &nbsp;</td>

            </tr>

             <tr>
                <td class="style1">
                    Turno</td>
                <td class="style2">
                    <asp:DropDownList ID="turno" runat="server" Width="280px" EnableViewState="true" >
                    </asp:DropDownList>
                </td>
                <td class="style1">
                    <asp:RequiredFieldValidator ID="rfvFecha" runat="server" 
                        ControlToValidate="turno" Display="Static" ErrorMessage="Seleccione turno" 
                        InitialValue="Escoja Un turno"></asp:RequiredFieldValidator>
                </td>
               
            </tr>
            <tr>
                <td style="WIDTH: 25%">
                    Cédula</td>
                <td style="WIDTH: 50%">
                    <asp:TextBox ID="cedula" runat="server" Width="300px"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="cedula" ErrorMessage="Solo se Aceptan Valores Númericos" 
                        ValidationExpression="[0-9]+"></asp:RegularExpressionValidator>
                </td>
                 <td style="WIDTH: 25%">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="cedula" ErrorMessage="RequiredFieldValidator">Debe ingresar Cédula</asp:RequiredFieldValidator>
                </td>
            </tr>
                    
            </tr>
        </table>
    </p>
    <p>
       
        <asp:Button ID="Button4" runat="server" Text="Procesar" Width="97px" OnClick="Button4_Click1" />
       
    &nbsp;<asp:Button ID="Button2" runat="server" Text="Limpiar" Width="97px" />
    &nbsp;<asp:Button ID="Button3" runat="server" Text="Salir" Width="97px" />
    &nbsp;</p>
    <p>
        &nbsp;&nbsp;
        &nbsp;</p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    </p>
   
</asp:Content>
