﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta_tipo_empleado.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.consulta_tipo_empleado" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

      <center>
     <h2>
      <body>
  <p style="color:white";> <strong>Consulta Por Tipo de Empleado</strong></p>
</body>

        
     </h2>       
    </center>
     <form>
  <div class="form-group">
      <center>
         <div class="form-group">
    <label for="exampleInputPassword1"></label>
   <%-- <input type="text"  id="clave" placeholder="Ingrese Codigo">--%>
<asp:TextBox ID="clave" runat="server" placeholder="Ingrese Codigo" ></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button2" runat="server" Text="Buscar" Width="97px" OnClick="Button2_Click" /> 
             <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White"></asp:Label>
  </div>
         
         <asp:GridView ID="grid_tipo" runat="server"  CssClass="table table-hover table-striped" GridLines="None"
    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4" OnPageIndexChanging="grid_tipo_PageIndexChanging">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
        <asp:BoundField DataField="id_depto" HeaderText="Código del Departamento" Visible="true" />
        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
       
    </Columns>
                 <PagerStyle HorizontalAlign="Center" ForeColor="White" />
                 </asp:GridView>
</center>
 </div>

</form>
</asp:Content>



