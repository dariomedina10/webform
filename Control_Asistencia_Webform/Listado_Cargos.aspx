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

      <center>
      <asp:GridView ID="grid_cargos" runat="server" CssClass="table table-hover table-striped" GridLines="None" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="5" OnPageIndexChanging="grid_cargos_PageIndexChanging">
      
   
    <%--      <asp:GridView ID="grid_cargos" runat="server"  CssClass="table table-hover table-striped" GridLines="None"
    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
        <asp:BoundField DataField="id_cargo" HeaderText="Código del Cargo" Visible="true" />
        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
       
    </Columns>--%>
       
                 <AlternatingRowStyle BackColor="Black" ForeColor="#284775" />
       
      <%--        <Columns>
        <asp:BoundField DataField="id_cargo" HeaderText="Código del Cargo" Visible="true" />
        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
       
    </Columns>--%>
       
                 <EditRowStyle BackColor="#999999" />
                 <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="Black" />
               <PagerStyle BackColor="#284775" ForeColor="Black" HorizontalAlign="Center" />
                 <RowStyle CssClass="cursor-pointer" BackColor="#F7F6F3" ForeColor="#333333" />
               <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
               <SortedAscendingCellStyle BackColor="#E9E7E2" />
               <SortedAscendingHeaderStyle BackColor="#506C8C" />
               <SortedDescendingCellStyle BackColor="#FFFDF8" />
               <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
          </asp:GridView>
</center>
   
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
