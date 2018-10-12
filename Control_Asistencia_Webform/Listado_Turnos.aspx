<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Turnos.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.Listado_Turnos" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

      <center>
     <h2>
      <body>
  <p style="color:white";> <strong>Listado General Por Turnos</strong></p>
</body>

        
     </h2>       
    </center>
     <form>
  <div class="form-group">
      <center>
         <asp:GridView ID="grid_turnos" runat="server"  CssClass="table table-hover table-striped" GridLines="None"
    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4" OnPageIndexChanging="grid_turnos_PageIndexChanging">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
        <asp:BoundField DataField="id_turno" HeaderText="Código" Visible="true" />
        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
       
    </Columns>
                 <PagerStyle HorizontalAlign="Center" ForeColor="White" />
                 </asp:GridView>
</center>
 </div>

</form>
</asp:Content>
