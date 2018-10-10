using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;

namespace Control_Asistencia_Webform
{
    public partial class Ingresar_Empleados : System.Web.UI.Page
    {

        public bool IsPostback { get; private set; }
        int valor;

    
        public void combo_cargos()
        {
          

            SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
              string sql = "SELECT id_cargo, descripcion FROM cargos";

               using (SqlCommand cmd = new SqlCommand(sql, Conexion))
               {
                        Conexion.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cargo.DataSource = ds;
                    cargo.DataTextField = "descripcion";                            // FieldName of Table in DataBase
                    cargo.DataValueField = "id_cargo";
                    cargo.DataBind();
                    
                            Conexion.Close();
                }

            }
        }
        public void combo_departamentos()
        {


            SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                string sql = "SELECT id_depto, descripcion FROM departamentos";

                using (SqlCommand cmd = new SqlCommand(sql, Conexion))
                {
                    Conexion.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    depto.DataSource = ds;
                    depto.DataTextField = "descripcion";                            // FieldName of Table in DataBase
                    depto.DataValueField = "id_depto";
                    depto.DataBind();

                    Conexion.Close();
                }

            }
        }

        public void combo_tipo_empleado()
        {


            SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                string sql = "SELECT id_tipo_empl, descripcion FROM tipo_empleado";

                using (SqlCommand cmd = new SqlCommand(sql, Conexion))
                {
                    Conexion.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    tipo_empl.DataSource = ds;
                    tipo_empl.DataTextField = "descripcion";                            // FieldName of Table in DataBase
                    tipo_empl.DataValueField = "id_tipo_empl";
                    tipo_empl.DataBind();

                    Conexion.Close();
                }

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime fechahoy = DateTime.Now;
            if (!IsPostback)
            {
                fecha_ingreso.Text =  Convert.ToString(fechahoy);
                string val = fecha_ingreso.Text;
                val = val.Substring(0, 10);
                fecha_ingreso.Text = val;
                combo_cargos();
                combo_departamentos();
                combo_tipo_empleado();
              //  Label1.Visible = false;
            }
        }



        //evento del botón
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
                {
                    //Label1.Visible = true;
                    SqlCommand cmd = new SqlCommand("INSERT_turnos", Conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_turno", SqlDbType.Int).Value = 0;
                    //cmd.Parameters.Add("@descr", System.Data.SqlDbType.VarChar).Value = descripcion.Text;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    //Label1.Text = "Turno Insertado Exitosamente";
                }
            }
            catch (Exception ex)
            {
              //  Label1.Text = "Turno No Insertado" + ex.Message;
            }
        }

    }
}