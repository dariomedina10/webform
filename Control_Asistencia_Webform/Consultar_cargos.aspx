<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar_cargos.aspx.cs" MasterPageFile="~/Site.Master"  Inherits="Control_Asistencia_Webform.Consultar_cargos" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

      <center>
     <h2>
      <body>
  <p style="color:white";> <strong>Consulta Por Cargos</strong></p>
</body>

        
     </h2>       
    </center>
     <form>
  <div class="form-group">
      <center>
         <asp:GridView ID="grid_cargos" runat="server"  CssClass="table table-hover table-striped" GridLines="None"
    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4" OnPageIndexChanging="grid_cargos_PageIndexChanging">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
        <asp:BoundField DataField="id_cargo" HeaderText="Código del Cargo" Visible="true" />
        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
       
    </Columns>
                 <PagerStyle HorizontalAlign="Center" ForeColor="White" />
                 </asp:GridView>
</center>
 </div>

</form>
</asp:Content>

