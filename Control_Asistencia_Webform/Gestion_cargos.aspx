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
         <asp:TextBox ID="id_cargo" runat="server" CssClass="table table-hover table-striped" placeholder="Ingrese Codigo"></asp:TextBox> <br />
         <asp:TextBox ID="descrip" runat="server" CssClass="table table-hover table-striped" placeholder="Descripción"></asp:TextBox>
     </center>
 </div>

</form>
</asp:Content>

