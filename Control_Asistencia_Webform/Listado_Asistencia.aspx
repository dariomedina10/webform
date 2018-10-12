<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Asistencia.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.Listado_Asistencia" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

      <center>
     <h2>
      <body>
  <p style="color:white";> <strong>Listado de Control de Asistencia</strong></p>
</body>

        
     </h2>       
    </center>
     <form>
  <div class="form-group">
      <center>
         <asp:GridView ID="grid_control" runat="server"  CssClass="table table-hover table-striped" GridLines="None"
    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4" OnPageIndexChanging="grid_control_PageIndexChanging">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
        <asp:BoundField DataField="id_control" HeaderText="Código" Visible="true" />
        <asp:BoundField DataField="Fecha" HeaderText="Fecha" Visible="true" />
        <asp:BoundField DataField="id_turno" HeaderText="Código de Turno" Visible="true" />
        <asp:BoundField DataField="hora_entrada" HeaderText="Entrada" Visible="true" />
        <asp:BoundField DataField="Hora_salida" HeaderText="Salida" Visible="true" />
        <asp:BoundField DataField="id_control" HeaderText="Cédula del Empleado" Visible="true" />
       
    </Columns>
                 <PagerStyle HorizontalAlign="Center" ForeColor="White" />
                 </asp:GridView>
</center>
 </div>

</form>
</asp:Content>

