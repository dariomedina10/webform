<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Departamentos.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.Listado_Departamentos" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

      <center>
     <h2>
      <body>
  <p style="color:white";> <strong>Listado General de Departamentos</strong></p>
</body>

        
     </h2>       
    </center>
     <form>
  <div class="form-group">
         <asp:GridView ID="grid_depto" runat="server"  CssClass="table table-hover table-striped" GridLines="None"
    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4" OnPageIndexChanging="grid_depto_PageIndexChanging">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
        <asp:BoundField DataField="id_depto" HeaderText="Código del Departamento" Visible="true" />
        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
       
    </Columns>
                 <PagerStyle HorizontalAlign="Center" ForeColor="White" />
                 </asp:GridView>
 </div>

</form>
</asp:Content>