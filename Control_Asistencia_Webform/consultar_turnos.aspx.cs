﻿using System;
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
    public partial class consultar_turnos : System.Web.UI.Page
    {
        public int total_ap = 0;
        public bool IsPostback { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostback)
            {
                Label1.Visible = false;
                // cargar_grid();
            }
        }

     

        public void cargar_grid()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                //invoco al sp para cargar el grid view

                SqlCommand cmd = new SqlCommand("mostrar_id_turno", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = clave.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grid_turno.DataSource = dt;
                grid_turno.DataBind();
            }
        }
        public void consulta()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                //invoco al sp para cargar el grid view

                SqlCommand cmd = new SqlCommand("validar_turnos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", clave.Text);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int total_ap = 0;
                rdr.Read();
                //while(rdr.Read())    // En caso de que exista varios valores de retorno sin usar DataTable
                // {
                total_ap = rdr.GetInt32(rdr.GetOrdinal("total"));
                if (total_ap > 0)
                {
                    cargar_grid();
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "No se ha encontrado Información con el código ingresado";

                }
                // }
                conn.Close();


            }
        }

        protected void Button2_Click(object sender, EventArgs e)

        {
            consulta();

        }
    }
}