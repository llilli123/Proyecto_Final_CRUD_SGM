using CAPA_DATOS;
using CAPA_MODELO_DE_NEGOCIOS;
using Microsoft.Data.SqlClient;
using Proyecto_Final_CRUD_SGM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class Consulta_Gestion : Form
    {
        public Consulta_Gestion()
        {
            InitializeComponent();
        }
        private Selector_Turnos_Logica Selct = new Selector_Turnos_Logica();
        private LogicaConsultaGestion Selct2 = new LogicaConsultaGestion();

        private void CargarDoctores()
        {
            cmb_Consulta_Gestion_Doctor.DataSource = Selct2.ObtenerDoctores();
            cmb_Consulta_Gestion_Doctor.DisplayMember = "NombreCompleto";
            cmb_Consulta_Gestion_Doctor.ValueMember = "ID_DOCTOR";
        }
        private void CargarTurnos()
        {
            if (cmb_Consulta_Gestion_Doctor.SelectedValue != null)
            {
                var rowView = cmb_Consulta_Gestion_Doctor.SelectedItem as DataRowView;

                if (rowView != null)
                {
                    int doctorId = Convert.ToInt32(rowView["ID_DOCTOR"]);
                    DateTime fecha = dtp_Consulta_Gestion_Fecha.Value;

                    DataTable tabla = Selct.ObtenerTurnosPendientes(doctorId, fecha);
                    dgv_Paciente_Espera.DataSource = tabla;
                }
            }
        }

        private void btn_Consulta_Gestion_Agregar_Click(object sender, EventArgs e)
        {
            Busqueda_Paciente buscador = new Busqueda_Paciente();
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                var paciente = buscador.PacienteSeleccionado;

                Selector_Turnos turnoSelector = new Selector_Turnos();
                if (turnoSelector.ShowDialog() == DialogResult.OK)
                {
                    int turno = turnoSelector.TurnoSeleccionado;

                    // Obtener doctor y fecha seleccionados
                    if (cmb_Consulta_Gestion_Doctor.SelectedValue != null)
                    {
                        int doctorId = Convert.ToInt32(cmb_Consulta_Gestion_Doctor.SelectedValue);
                        DateTime fecha = dtp_Consulta_Gestion_Fecha.Value;

                        // Lógica para insertar turno
                        Selector_Turnos_Logica logica = new Selector_Turnos_Logica();
                        bool ok = logica.InsertarTurno(paciente.ID, doctorId, fecha, turno);

                        if (ok)
                        {
                            MessageBox.Show("Turno asignado correctamente.");
                            CargarTurnos();
                        }
                        else
                        {
                            MessageBox.Show("El turno ya está ocupado o ocurrió un error.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un doctor válido.");
                    }
                }
            }
        }

        private void Consulta_Gestion_Load(object sender, EventArgs e)
        {

            CargarDoctores();
            CargarTurnos();
        }



        private void dtp_Consulta_Gestion_Fecha_Valor_Cambio(object sender, EventArgs e)
        {
            CargarTurnos();
        }

        private void cmb_Consulta_Gestion_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Consulta_Gestion_Doctor.SelectedIndex != -1)
            {
                CargarTurnos();
            }
        }

        private void dgv_Paciente_Espera_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = dgv_Paciente_Espera.Rows[e.RowIndex];
            if (row.Cells["ESTADOTURNO"].Value?.ToString() == "Atendiendo")
            {
                row.DefaultCellStyle.Font = new Font(dgv_Paciente_Espera.Font, FontStyle.Bold);
            }
        }

    }
}
