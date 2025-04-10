using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS.Interfaces
{ }/*
    public interface ICargadores
    {
        DataTable CargarDoctores();
        DataTable CargarTurnos(int doctorId, DateTime fecha);
    }

    public class CargadorDatosLogica : ICargadores
    {
        private  CONEXIONDATOS conexion = new CONEXIONDATOS();

        public DataTable CargarDoctores()
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "SELECT ID_DOCTOR, NOMBRE + ' ' + APELLIDO AS NombreCompleto FROM DOCTORES";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable CargarTurnos(int doctorId, DateTime fecha)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                SELECT T.ID_TURNO, P.NOMBRE, P.APELLIDO, T.ESTADOTURNO
                FROM TURNOSCONSULTA T
                JOIN PACIENTES P ON T.PACIENTE_ID = P.PACIENTE_ID
                WHERE T.ID_DOCTOR = @doctorId AND CONVERT(DATE, T.FECHATURNO) = @fecha";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@fecha", fecha);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}

    */