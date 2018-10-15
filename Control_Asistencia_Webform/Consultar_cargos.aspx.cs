using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Control_Asistencia_Webform
{
    public partial class Consultar_cargos : System.Web.UI.Page
    {
        public bool IsPostback { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostback)
            {
                cargar_grid();
            }
        }

        protected void grid_cargos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_cargos.PageIndex = e.NewPageIndex;
            //LLenarDatosConsejera();
            this.grid_cargos.DataBind();
        }
        public void cargar_grid()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                //invoco al sp para cargar el grid view

                SqlCommand cmd = new SqlCommand("validar_id_cargos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", 1);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int total_ap = 0;
                rdr.Read();
                //while(rdr.Read())    // En caso de que exista varios valores de retorno sin usar DataTable
                // {
                total_ap = rdr.GetInt32(rdr.GetOrdinal("total"));
                // }
                conn.Close();
            
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //da.Fill(dt);

                //grid_cargos.DataSource = dt;
                //grid_cargos.DataBind();
            }
        }

    }
}