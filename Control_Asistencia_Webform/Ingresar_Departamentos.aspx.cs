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
    public partial class Ingresar_Departamentos : System.Web.UI.Page
    {

        public bool IsPostback { get; private set; }
        int valor;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostback)
            {
                Label1.Visible = false;
            }
        }

     
     
        //evento del botón
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
                {
                    Label1.Visible = true;
                    SqlCommand cmd = new SqlCommand("INSERT_departamentos", Conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_depto", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@descr", System.Data.SqlDbType.VarChar).Value = descripcion.Text;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    Label1.Text = "Departamento Insertado Exitosamente";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Departamento No Insertado" + ex.Message;
            }
        }
    }
}
