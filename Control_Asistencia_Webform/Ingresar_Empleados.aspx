<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingresar_Empleados.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.Ingresar_Empleados" %>
 
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
                        Ingresar Empleados</p>
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
            <tr>
                <td style="WIDTH: 25%">
                    Nombres </td>
                <td style="WIDTH: 50%">
                    <asp:TextBox ID="nom" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td style="WIDTH: 25%">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="nom" ErrorMessage="RequiredFieldValidator">Debe ingresar Nombres</asp:RequiredFieldValidator>
                </td>

            </tr>

             <tr>
                <td style="WIDTH: 25%">
                    Apellidos </td>
                <td style="WIDTH: 50%">
                    <asp:TextBox ID="ape" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td style="WIDTH: 25%">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="ape" ErrorMessage="RequiredFieldValidator">Debe ingresar Apellidos</asp:RequiredFieldValidator>
                </td>

            </tr>
            <tr>
                <td class="style1">
                    Cargo</td>
                <td class="style2">
                    <asp:DropDownList ID="cargo" runat="server" Width="280px">
                    </asp:DropDownList>
                </td>
                <td class="style1">
                    <asp:RequiredFieldValidator ID="rfvFecha" runat="server" 
                        ControlToValidate="cargo" Display="Static" ErrorMessage="Seleccione Cargo" 
                        InitialValue="Escoja Un cargo"></asp:RequiredFieldValidator>
                </td>
               
            </tr>
            <tr>
              <td class="style1">
                    Departamento</td>
                <td class="style2">
                    <asp:DropDownList ID="depto" runat="server" Width="280px">
                    </asp:DropDownList>
                </td>
                <td class="style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="depto" Display="Static" ErrorMessage="Seleccione Departamento" 
                        InitialValue="Escoja Un Departamento"></asp:RequiredFieldValidator>
                </td>
                 <tr>
                <td class="style1">
                    Tipo de Empleado</td>
                <td class="style2">
                    <asp:DropDownList ID="tipo_empl" runat="server" Width="280px">
                    </asp:DropDownList>
                </td>
                <td class="style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="tipo_empl" Display="Static" ErrorMessage="Seleccione Tipo de Empleado" 
                        InitialValue="Escoja el Tipo de Empleado"></asp:RequiredFieldValidator>
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
