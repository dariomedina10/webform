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
    public partial class Gestion_cargos : System.Web.UI.Page
    {
       
            public int total_ap = 0;
        public bool IsPostback { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostback)
            {
                Label1.Visible = false;
                modificar.Enabled = false;
                eliminar.Enabled = false;
            }
        }



        public void cargar_grid()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                //invoco al sp para cargar el grid view

                SqlCommand cmd = new SqlCommand("mostrar_id_depto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = clave.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

             
            }
        }
        public void consulta()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                //invoco al sp para cargar el grid view
                try
                {
                    SqlCommand cmd = new SqlCommand("validar_id_cargos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", clave.Text);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    int total_ap = 0;
                    rdr.Read();
                    if (rdr.Read())   
                    {
                        descrip.Text = (string)rdr["descripcion"]; ;
                        total_ap = rdr.GetInt32(rdr.GetOrdinal("total"));
                        if (total_ap > 0)
                        {
                            Response.Write("atrapado");
                            modificar.Enabled = true;
                            eliminar.Enabled = true;
                        }
                        else
                        {
                            Label1.Visible = true;
                            Label1.Text = "No se ha encontrado Información con el código ingresado";

                        }
                        
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    Label1.Visible = true;
                    Label1.Text = "Problemas en la conexión" + ex.Message;
                }
            }
        }

        protected void buscar_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
    }