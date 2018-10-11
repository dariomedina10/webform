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
    public partial class Ingresar_Control_Asistencia : System.Web.UI.Page
    {
        public bool IsPostback { get; private set; }
        public string fechas;

        public void combo_turnos()
        {


            SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                string sql = "SELECT id_turno, descripcion FROM turnos";

                using (SqlCommand cmd = new SqlCommand(sql, Conexion))
                {
                    Conexion.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    turno.DataSource = ds;
                    turno.DataTextField = "descripcion";                            // FieldName of Table in DataBase
                    turno.DataValueField = "id_turno";
                    turno.DataBind();

                    Conexion.Close();
                }

            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime fechahoy = DateTime.Now;
            
            if (!IsPostback)
            {
                fecha_ingreso.Text = Convert.ToString(fechahoy);
                fechas = Convert.ToString(fechahoy);
                combo_turnos();
                Label1.Visible = false;
            }
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
                {
                    Label1.Visible = true;
                    SqlCommand cmd = new SqlCommand("INSERT_control_asistencia", Conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_control", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha_ingreso.Text;
                    cmd.Parameters.Add("@id_turno", SqlDbType.Int).Value = turno.SelectedIndex + 1;
                    cmd.Parameters.Add("@hora_entrada", SqlDbType.DateTime).Value = fechas;
                    cmd.Parameters.Add("@hora_salida", SqlDbType.DateTime).Value = fechas;
                    cmd.Parameters.Add("@id_empl", SqlDbType.BigInt).Value = cedula.Text;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    Label1.Text = "Control de Asistencia Insertado Exitosamente";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Control de Asistencia No Insertado" + ex.Message;
            }
        }
    }
}
    
