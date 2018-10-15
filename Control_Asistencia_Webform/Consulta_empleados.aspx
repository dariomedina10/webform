<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta_empleados.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.Consulta_empleados" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

      <center>
     <h2>
      <body>
  <p style="color:white";> <strong>Consulta Por Empleados</strong></p>
</body>

        
     </h2>       
    </center>
     <form>
  <div class="form-group">
      <center>
         <div class="form-group">
    <label for="exampleInputPassword1"></label>
   <%-- <input type="text"  id="clave" placeholder="Ingrese Codigo">--%>
<asp:TextBox ID="clave" runat="server" placeholder="Ingrese Cédula" ></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button2" runat="server" Text="Buscar" Width="97px" OnClick="Button2_Click" /> 
             <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White"></asp:Label>
  </div>
         
         <asp:GridView ID="grid_empl" runat="server"  CssClass="table table-hover table-striped" GridLines="None"
    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4" OnPageIndexChanging="grid_empl_PageIndexChanging">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
        <asp:BoundField DataField="id_empl" HeaderText="Cédula del Empleado" Visible="true" />
        <asp:BoundField DataField="nombres" HeaderText="Nombres" />
        <asp:BoundField DataField="apelli" HeaderText="Apellido" Visible="true" />
        <asp:BoundField DataField="id_cargo" HeaderText="Código del Cargo" />
        <asp:BoundField DataField="id_depto" HeaderText="Código del Departamento" />
        <asp:BoundField DataField="fecha_ingreso" HeaderText="Fecha de Ingreso" Visible="true" />
        <asp:BoundField DataField="id_tipo_empl" HeaderText="Código de Tipo de Empleado" />
       
    </Columns>
                 <PagerStyle HorizontalAlign="Center" ForeColor="White" />
                 </asp:GridView>
</center>
 </div>

</form>
</asp:Content>



