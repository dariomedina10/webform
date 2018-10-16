<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestion_cargos.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.Gestion_cargos" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

      <center>
     <h2>
      <body>
  <p style="color:white";> <strong>Gestión de Cargos (Modificar-Eliminar)</strong></p>
</body>

        
     </h2>       
    </center>
     <form>
 <div class="form-group">
     <center>
         <asp:TextBox ID="clave" runat="server" CssClass="table table-hover table-striped" placeholder="Ingrese Codigo"></asp:TextBox> <br />
         <asp:TextBox ID="descrip" runat="server" CssClass="table table-hover table-striped" placeholder="Descripción"></asp:TextBox> <br />
         <asp:Button ID="buscar" runat="server" Text="Buscar" Width="97px" CssClass="table table-hover table-striped" /> 
         <asp:Button ID="modificar" runat="server" Text="Modificar" Width="97px" CssClass="table table-hover table-striped" /> 
          <asp:Button ID="eliminar" runat="server" Text="Eliminar" Width="97px" CssClass="table table-hover table-striped"  /> 
          <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White" CssClass="table table-hover table-striped" ></asp:Label>
     </center>
 </div>

</form>
</asp:Content>


