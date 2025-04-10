using CAPA_MODELO_DE_NEGOCIOS;
using CAPA_MODELO_DE_NEGOCIOS.Interfaces;
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
    public partial class Doctor_Consulta_Reporte : Form, ICargadorDeDoctores
    {
        public Doctor_Consulta_Reporte()
        {
            InitializeComponent();
        }
        private void MostrarCitasAtendidas()
        {
            var rowView = cmb_Doctor_Seleccion.SelectedItem as DataRowView;
            if (rowView != null)
            {
                int doctorId = Convert.ToInt32(rowView["ID_DOCTOR"]);
                Consulta_Reporte_Logica logica = new Consulta_Reporte_Logica();
                DateTime fecha = dtp_Fecha_Seleccion_Doctor.Value.Date;
                dgv_Pacientes_Atender_Doctor.DataSource = logica.ObtenerCitasAtendidas(doctorId, fecha);
                
            }
        }
        public void CargarDoctores()
        {
            LogicaConsultaGestion logica = new LogicaConsultaGestion();
            cmb_Doctor_Seleccion.DataSource = logica.ObtenerDoctores();
            cmb_Doctor_Seleccion.DisplayMember = "NombreCompleto";
            cmb_Doctor_Seleccion.ValueMember = "ID_DOCTOR";
        }

        private void Doctor_Consulta_Reporte_Load(object sender, EventArgs e)
        {
            CargarDoctores();
        }

        private void cmb_Doctor_Seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarCitasAtendidas();
        }

        private void dtp_Fecha_Seleccion_Doctor_ValueChanged(object sender, EventArgs e)
        {
            MostrarCitasAtendidas();
        }

        private void btn_start_asistencia_Click(object sender, EventArgs e)
        {
            if (dgv_Pacientes_Atender_Doctor.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgv_Pacientes_Atender_Doctor.SelectedRows[0];

                int turnoId = Convert.ToInt32(fila.Cells["ID_TURNO"].Value);
                int pacienteId = Convert.ToInt32(fila.Cells["PACIENTE_ID"].Value);
                var rowView = cmb_Doctor_Seleccion.SelectedItem as DataRowView;

                if (rowView == null)
                {
                    MessageBox.Show("Debe seleccionar un doctor.");
                    return;
                }

                int doctorId = Convert.ToInt32(rowView["ID_DOCTOR"]);
                DateTime fecha = dtp_Fecha_Seleccion_Doctor.Value.Date;

                Consulta_Reporte_Logica logica = new Consulta_Reporte_Logica();

                bool yaHayUno = logica.PacienteAtendiendo(doctorId, fecha);
                if (yaHayUno)
                {
                    MessageBox.Show("Ya hay un paciente siendo atendido.");
                    return;
                }

                bool actualizado = logica.Atendiendo(turnoId, doctorId, fecha, "Atendiendo");
                if (actualizado)
                {
                    MostrarCitasAtendidas();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el estado.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente.");
            }
        }

        private void dgv_Pacientes_Atender_Doctor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = dgv_Pacientes_Atender_Doctor.Rows[e.RowIndex];
            if (row.Cells["ESTADOTURNO"].Value?.ToString() == "Atendiendo")
            {
                row.DefaultCellStyle.Font = new Font(dgv_Pacientes_Atender_Doctor.Font, FontStyle.Bold);
            }
        }

        private void btn_Terminar_Ass_Click(object sender, EventArgs e)
        {
            if (dgv_Pacientes_Atender_Doctor.SelectedRows.Count > 0)
            {
                var fila = dgv_Pacientes_Atender_Doctor.SelectedRows[0];

                int turnoId = Convert.ToInt32(fila.Cells["ID_TURNO"].Value);
                int pacienteId = Convert.ToInt32(fila.Cells["PACIENTE_ID"].Value);
                int doctorId = Convert.ToInt32(fila.Cells["ID_DOCTOR"].Value);
                DateTime fechaTurno = Convert.ToDateTime(fila.Cells["FECHATURNO"].Value);

                DialogResult result = MessageBox.Show(
                    "¿Deseas crear un reporte para este paciente?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    FormReporte formularioReporte = new FormReporte(turnoId, pacienteId, doctorId, fechaTurno);
                    formularioReporte.ShowDialog();
                }

                // Actualizar estado a "Atendido"
                Consulta_Reporte_Logica logica = new Consulta_Reporte_Logica();
                logica.Atendido(turnoId);

                MostrarCitasAtendidas();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un paciente.");
            }
        }
    }
}


