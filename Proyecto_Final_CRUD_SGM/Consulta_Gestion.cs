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

        private void CargarTurnos()
        {
            if (cmb_Consulta_Gestion_Doctor.SelectedValue != null)
            {
                int doctorId = Convert.ToInt32(cmb_Consulta_Gestion_Doctor.SelectedValue);
                DateTime fecha = dtp_Consulta_Gestion_Fecha.Value;

                DataTable tabla = Selct.ObtenerTurnosPendientes(doctorId, fecha);
                dgv_Paciente_Espera.DataSource = tabla;
            }
        }

        private void CargarTurnosAtendidos()
        {
            if (cmb_Consulta_Gestion_Doctor.SelectedValue != null)
            {
                int doctorId = Convert.ToInt32(cmb_Consulta_Gestion_Doctor.SelectedValue);
                DateTime fecha = dtp_Consulta_Gestion_Fecha.Value;

                DataTable tabla = Selct.ObtenerTurnosAtendidos(doctorId, fecha);
                dataGridView2.DataSource = tabla;
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

                    int doctorId = Convert.ToInt32(cmb_Consulta_Gestion_Doctor.SelectedValue);
                    DateTime fecha = dtp_Consulta_Gestion_Fecha.Value;

                    Selector_Turnos_Logica logica = new Selector_Turnos_Logica();
                    bool ok = logica.InsertarTurno(paciente.ID, doctorId, fecha, turno);

                    if (ok)
                    {
                        MessageBox.Show("Turno asignado correctamente.");
                        CargarTurnos();
                        CargarTurnosAtendidos();
                    }
                    else
                    {
                        MessageBox.Show("Error al asignar turno.");
                    }
                }
            }
        }

        private void Consulta_Gestion_Load(object sender, EventArgs e)
        {
            CargarDoctores();
            CargarTurnos();
            CargarTurnosAtendidos();
        }

        private void CargarDoctores()
        {
            cmb_Consulta_Gestion_Doctor.DataSource = Selct2.ObtenerDoctores();
            cmb_Consulta_Gestion_Doctor.DisplayMember = "NombreCompleto";
            cmb_Consulta_Gestion_Doctor.ValueMember = "ID_DOCTOR";
        }

        private void dtp_Consulta_Gestion_Fecha_Valor_Cambio(object sender, EventArgs e)
        {
            CargarTurnos();
            CargarTurnosAtendidos();
        }

        private void dgv_Paciente_Espera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_Paciente_Espera.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este turno?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    var fila = dgv_Paciente_Espera.SelectedRows[0];
                    int turnoId = Convert.ToInt32(fila.Cells["ID_TURNO"].Value);

                    Selector_Turnos_Logica logica = new Selector_Turnos_Logica();
                    bool eliminado = logica.EliminarTurno(turnoId);

                    if (eliminado)
                    {
                        MessageBox.Show("Turno eliminado correctamente.");
                        CargarTurnos(); // Actualiza la tabla
                        CargarTurnosAtendidos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el turno.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un turno de la tabla para eliminar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_Paciente_Espera.SelectedRows.Count > 0)
            {
                int turnoId = Convert.ToInt32(dgv_Paciente_Espera.SelectedRows[0].Cells["ID_TURNO"].Value);

                // Llamamos al método MarcarComoAtendido
                bool actualizado = Selct.MarcarComoAtendido(turnoId);
                if (actualizado)
                {
                    MessageBox.Show("Paciente marcado como atendido.");
                    CargarTurnos(); // Refrescar la tabla
                    CargarTurnosAtendidos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el turno.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila primero.");
            }
        }
    }
}
