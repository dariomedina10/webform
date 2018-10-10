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
               Label1.Visible = false;
            }
        }



        //evento del botón
        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
        //        {
        //            Label1.Visible = true;
        //            SqlCommand cmd = new SqlCommand("INSERT_empleados", Conexion);
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.Parameters.Add("@id_empl", SqlDbType.BigInt).Value = cedula.Text;
        //            cmd.Parameters.Add("@nombres", System.Data.SqlDbType.VarChar).Value = nom.Text;
        //            cmd.Parameters.Add("@apelli", System.Data.SqlDbType.VarChar).Value = ape.Text;
        //            cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = cargo.DataValueField;
        //            cmd.Parameters.Add("@id_depto", SqlDbType.Int).Value = depto.DataValueField;
        //            cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = fecha_ingreso.Text;
        //            cmd.Parameters.Add("@id_tipo_empl", SqlDbType.Int).Value = tipo_empl.DataValueField;
        //            Conexion.Open();
        //            cmd.ExecuteNonQuery();
        //            Conexion.Close();
        //            Label1.Text = "Empleado Insertado Exitosamente";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //     Label1.Text = "Empleado No Insertado" + ex.Message;
        //    }
        //}

        protected void Button4_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
                {
                    Label1.Visible = true;
                    SqlCommand cmd = new SqlCommand("INSERT_empleados", Conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empl", SqlDbType.BigInt).Value = cedula.Text;
                    cmd.Parameters.Add("@nombres", System.Data.SqlDbType.VarChar).Value = nom.Text;
                    cmd.Parameters.Add("@apelli", System.Data.SqlDbType.VarChar).Value = ape.Text;
                    cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = cargo.SelectedIndex + 1;
                    cmd.Parameters.Add("@id_depto", SqlDbType.Int).Value = depto.SelectedIndex + 1;
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = fecha_ingreso.Text;
                    cmd.Parameters.Add("@id_tipo_empl", SqlDbType.Int).Value = tipo_empl.SelectedIndex + 1;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    Label1.Text = "Empleado Insertado Exitosamente";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Empleado No Insertado" + ex.Message;
            }
        }
    }
}