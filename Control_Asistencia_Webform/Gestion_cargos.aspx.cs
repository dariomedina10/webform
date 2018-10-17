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
                Button1.Enabled = false;
                Button3.Enabled = false;
                // cargar_grid();
            }
        }

     

      
        public void consulta()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
            
                try
                {
                    SqlCommand cmd = new SqlCommand("mostrar_id_cargos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", clave.Text);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
                    rdr.Read();
                    if (rdr.Read())
                    {
                        descrip.Text = (string)rdr["descripcion"];   
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

        protected void Button2_Click(object sender, EventArgs e)

        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("validar_id_cargos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(clave.Text));
                    conn.Open();
                    total_ap = Convert.ToInt32(cmd.ExecuteScalar());
                        //descrip.Text = (string)rdr["descripcion"];
                        //descrip.Text = Convert.ToString(rdr["descripcion"]);
                        //  descrip.Text = (int)rdr["descripcion"];
                        //   total_ap = rdr.GetInt32(rdr.GetOrdinal("total"));

                        // descrip.Text = rdr["descripcion"].ToString();
                        if (total_ap > 0)
                        {
                        
                            Button1.Enabled = true;
                            Button3.Enabled = true;
                        consulta();
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

//    public int total_ap = 0;
//public bool IsPostback { get; private set; }
//protected void Page_Load(object sender, EventArgs e)
//{
//    if (!IsPostback)
//    {
//        Label1.Visible = false;
//        Button1.Enabled = false;
//        Button3.Enabled = false;
//    }
//}

////protected void buscar_Click(object sender, EventArgs e)
////{
////    consulta();
////}

//public void cargar_grid()
//{
//    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
//    {
//        //invoco al sp para cargar el grid view

//        SqlCommand cmd = new SqlCommand("mostrar_id_depto", conn);
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = clave.Text;
//        SqlDataAdapter da = new SqlDataAdapter(cmd);
//        DataTable dt = new DataTable();
//        da.Fill(dt);


//    }
//}
//public void Consulta()
//{
//    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
//    {
//        //invoco al sp para cargar el grid view
//        try
//        {
//            SqlCommand cmd = new SqlCommand("validar_id_cargos", conn);
//            cmd.CommandType = CommandType.StoredProcedure;

//            cmd.Parameters.AddWithValue("@id", clave.Text);
//            conn.Open();
//            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
//            int total_ap = 0;
//            rdr.Read();
//            if (rdr.Read())   
//            {
//                descrip.Text = (string)rdr["descripcion"]; ;
//                total_ap = rdr.GetInt32(rdr.GetOrdinal("total"));
//                if (total_ap > 0)
//                {
//                    Response.Write("atrapado");
//                    Button1.Enabled = true;
//                    Button3.Enabled = true;
//                }
//                else
//                {
//                    Label1.Visible = true;
//                    Label1.Text = "No se ha encontrado Información con el código ingresado";

//                }

//                conn.Close();
//            }
//        }
//        catch (Exception ex)
//        {
//            Label1.Visible = true;
//            Label1.Text = "Problemas en la conexión" + ex.Message;
//        }
//    }
//}

//protected void Button2_Click(object sender, EventArgs e)
//{  
//    Consulta();
//}