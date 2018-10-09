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
    public partial class Ingresar_Cargos : System.Web.UI.Page
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

        protected void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        //función maximo

   /*      void Maximo()
        {
            int cont;
            System.Data.SqlClient.SqlCommand comd2 = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlCommand comd3 = new System.Data.SqlClient.SqlCommand();
            string s;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {

               
            comd2.CommandText = "select max(id_cargo) from cargo";
            comd2 = new System.Data.SqlClient.SqlCommand(comd2.CommandText, conn);
            conn.Open();
            comd3.CommandText = "select count(*) from cargo";
            comd3 = new System.Data.SqlClient.SqlCommand(comd3.CommandText, conn);
            cont = comd3.ExecuteScalar;
            if (cont < 1)
            {
                valor = 0;
            }
            else
            {
                valor = comd2.ExecuteScalar();
            }
            conn.Close();
           
        }*/
        //evento del botón
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
                {
                    Label1.Visible = true;
                    SqlCommand cmd = new SqlCommand("INSERT_CARGOS", Conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@descr", System.Data.SqlDbType.VarChar).Value = descripcion.Text;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    Label1.Text = "Cargo Insertado Exitosamente";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Cargo No Insertado" + ex.Message;
            }
        }
    }
}