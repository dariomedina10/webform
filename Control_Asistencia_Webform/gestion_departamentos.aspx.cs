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
    public partial class gestion_departamentos : System.Web.UI.Page
    {
        public int total_ap = 0;
        public bool IsPostback { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostback)
            {
                Label1.Visible = false;
                Button1.Enabled = false;
                Button3.Enabled = false;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
                {
                    Label1.Visible = true;
                    SqlCommand cmd = new SqlCommand("update_dèpartamentos", Conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_depto", SqlDbType.Int).Value = clave.Text;
                    cmd.Parameters.Add("@descr", System.Data.SqlDbType.VarChar).Value = descrip.Text;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    Label1.Visible = true;
                    Label1.Text = "Departamento Modificado Exitosamente";
                }
            }
            catch (Exception ex)
            {
                Label1.Visible = true;
                Label1.Text = "Departamento No Modificado" + ex.Message;
            }
        }





        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
                {
                    Label1.Visible = true;
                    SqlCommand cmd = new SqlCommand("delete_tabla", Conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = "departamentos";
                    cmd.Parameters.Add("@nombre_campo_id", SqlDbType.VarChar).Value = "id_depto";
                    cmd.Parameters.Add("@valor_id", System.Data.SqlDbType.Int).Value = clave.Text;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    clave.Text = "";
                    descrip.Text = "";
                    Label1.Visible = true;
                    Label1.Text = "Departamento Eliminado Exitosamente";
                }
            }
            catch (Exception ex)
            {
                Label1.Visible = true;
                Label1.Text = "Departamento No Eliminado" + ex.Message;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)

        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("validar_id_depto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(clave.Text));
                    conn.Open();
                    total_ap = Convert.ToInt32(cmd.ExecuteScalar());
                    //descrip.Text = Convert.ToString(rdr["descripcion"]);
                    //  descrip.Text = (int)rdr["descripcion"];
                    // descrip.Text = rdr["descripcion"].ToString();
                    if (total_ap > 0)
                    {

                        Button1.Enabled = true;
                        Button3.Enabled = true;

                        //rutina para mostrar la descripcion en el textbox
                        SqlCommand cmd2 = new SqlCommand("mostrar_id_depto", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@id", clave.Text);
                        SqlDataReader rdr2 = cmd2.ExecuteReader();
                        try
                        {

                            if (rdr2.Read())
                            {
                                descrip.Text = (string)rdr2["descripcion"];

                            }
                        }
                        catch (Exception ex)
                        {
                            Label1.Visible = true;
                            Label1.Text = "Problemas en la conexión" + ex.Message;
                        }


                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "No se ha encontrado Información con el código ingresado";

                    }

                    conn.Close();
                    //}
                }
                catch (Exception ex)
                {
                    Label1.Visible = true;
                    Label1.Text = "Problemas en la conexión" + ex.Message;
                }
            }

        }
    }
}