using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_MODELO_DE_NEGOCIOS;
using CAPA_MODELO_DE_NEGOCIOS.Interfaces;

namespace CAPA_PRESENTACION
{
    public partial class Listado_Citas : Form, ICargadorDeDoctores
    {
        public Listado_Citas()
        {
            InitializeComponent();
        }

        private void Listado_Citas_Load(object sender, EventArgs e)
        {
            CargarCitas();
            CargarDoctores();
        }

        private void CargarCitas()
        {
            if (cmb_Doctor_Listado.SelectedIndex <= 0 || cmb_Doctor_Listado.SelectedItem == null)
                return;

            DateTime fechaSeleccionada = dtp_consultafech.Value.Date;
            string nombreDoctor = cmb_Doctor_Listado.SelectedItem.ToString();

            LogicaCitas logica = new LogicaCitas();
            DataTable citas = logica.ObtenerCitasPorFechaYDoctor(fechaSeleccionada, nombreDoctor);

            dgvCitas.DataSource = citas;

        }
        public void CargarDoctores()
        {
            try
            {
                cmb_Doctor_Listado.Items.Clear();
                cmb_Doctor_Listado.Items.Add("Seleccione un doctor"); // Opción por defecto

                Logica_de_Cita logica = new Logica_de_Cita();
                List<string> doctores = logica.ObtenerNombresDoctores();

                foreach (var nombre in doctores)
                {
                    cmb_Doctor_Listado.Items.Add(nombre);
                }

                cmb_Doctor_Listado.SelectedIndex = 0; // Selecciona por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar doctores: " + ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                int citaId = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["ID_CITA"].Value);
                string nombreDoctor = cmb_Doctor_Listado.SelectedItem.ToString();

                // Obtener el correo del paciente antes de eliminar
                string correoPaciente = dgvCitas.SelectedRows[0].Cells["CORREO"].Value.ToString();
                string nombrePaciente = dgvCitas.SelectedRows[0].Cells["PACIENTE_NOMBRE"].Value.ToString();
                string fecha = dtp_consultafech.Value.ToString("dd/MM/yyyy");
                string hora = dgvCitas.SelectedRows[0].Cells["HORA"].Value.ToString();
                
                LogicaCitas logica = new LogicaCitas();
                if (logica.EliminarCita(citaId))
                {
                    MessageBox.Show("Cita eliminada correctamente");
                    CargarCitas();

                    // Enviar correo de notificación
                    CorreoCitaCancelada correo = new CorreoCitaCancelada();
                    string asunto = "Cancelación de Cita";
                    string cuerpo = $"Hola {nombrePaciente}, su cita programada para el {fecha} a las {hora} ha sido cancelada.";

                    correo.EnviarCorreo(correoPaciente, asunto, cuerpo);

                    string correoDoctor = correo.ObtenerCorreoDoctor(nombreDoctor);
                    if (!string.IsNullOrWhiteSpace(correoDoctor))
                    {
                        CorreoCitaCancelada correoADoctor = new CorreoCitaCancelada();
                        string asuntoDoctor = "Cancelación de Cita";
                        string cuerpoDoctor = $@"
                        Hola Dr. {nombreDoctor},

                        Le informamos que una cita que tenía asignada ha sido cancelada por el paciente {nombrePaciente} a las {hora} para el {fecha}.

                        Por favor verifique su panel de citas.

                        Atentamente,
                        Centro Médico UCE";

                        correoADoctor.EnviarCorreo(correoDoctor, asuntoDoctor, cuerpoDoctor);
                    }

                }
                
                else
                {
                    MessageBox.Show("Error al eliminar la cita");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["ID_CITA"].Value);
                string nombre = dgvCitas.SelectedRows[0].Cells["PACIENTE_NOMBRE"].Value.ToString();
                string apellido = dgvCitas.SelectedRows[0].Cells["APELLIDO"].Value.ToString();
                string correo = dgvCitas.SelectedRows[0].Cells["CORREO"].Value.ToString();
                int telefono = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["TELEFONO"].Value);
                DateTime fecha = Convert.ToDateTime(dgvCitas.SelectedRows[0].Cells["FECHA"].Value);
                string hora = dgvCitas.SelectedRows[0].Cells["HORA"].Value.ToString();


                Editar_citas form = new Editar_citas(id, nombre, apellido, correo, telefono, fecha, hora);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LogicaCitas logica = new LogicaCitas();
                    if (logica.ModificarCita(form.IdCita, form.Nombre, form.Apellido, form.Correo, form.Telefono, form.Fecha, form.Hora))
                    {
                        MessageBox.Show("Cita actualizada");
                        CargarCitas();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la cita");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }
        private void CargarCitasFiltradas()
        {
            if (cmb_Doctor_Listado.SelectedIndex > 0) // Verifica que no esté en "Seleccione un doctor"
            {
                string doctor = cmb_Doctor_Listado.SelectedItem.ToString();
                DateTime fecha = dtp_consultafech.Value.Date;

                LogicaCitas logica = new LogicaCitas();
                DataTable citas = logica.ObtenerCitasPorFechaYDoctor(fecha, doctor);
                dgvCitas.DataSource = citas;
            }
        }
        private void cmb_Doctor_Listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCitasFiltradas();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CargarCitasFiltradas();
        }
    }
}