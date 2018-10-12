<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado_Cargos.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Control_Asistencia_Webform.Listado_Cargos" %>



<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <center>
     <h2>
      <body>
  <p style="color:white";> <strong>Listado General de Cargos</strong></p>
</body>

        
     </h2>       
    </center>

  </body
   <form>
  <div class="form-group">
      
    <%--  <asp:GridView ID="grid_cargos" runat="server" --%>
          <asp:GridView ID="grid_cargos" runat="server"  CssClass="table table-hover table-striped" GridLines="Horizontal"
    AutoGenerateColumns="False">
               <Columns>
        <asp:BoundField DataField="id_cargo" HeaderText="Código del Cargo" Visible="false" />
        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
       
    </Columns>
                 <RowStyle CssClass="cursor-pointer" />
          </asp:GridView>
   
  <%--  <Columns>
        <asp:BoundField DataField="id_cargo" HeaderText="Código del Cargo" Visible="false" />
        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
       
    </Columns>--%>
 



    <%--<label for="exampleInputEmail1">Email address</label>
    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
    <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
  </div>
  <div class="form-group form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">Check me out</label>--%>
  </div>

</form>
</asp:Content>
