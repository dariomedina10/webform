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
    public partial class Listado_Empleados : System.Web.UI.Page
    {

        public bool IsPostback { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostback)
            {
                cargar_grid();
            }
        }

        protected void grid_empl_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_empl.PageIndex = e.NewPageIndex;

            this.grid_empl.DataBind();
        }

        public void cargar_grid()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                //invoco al sp para cargar el grid view

                SqlCommand cmd = new SqlCommand("select_tabla", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = "empleados";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grid_empl.DataSource = dt;
                grid_empl.DataBind();
            }
        }

    }
}