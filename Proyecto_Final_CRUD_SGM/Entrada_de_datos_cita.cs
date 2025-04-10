using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using CAPA_MODELO_DE_NEGOCIOS;
using CAPA_MODELO_DE_NEGOCIOS.Interfaces;


namespace CAPA_PRESENTACION // Espacio de nombres que agrupa clases relacionadas con la capa de presentación
{
    public partial class Entrada_de_datos_cita : Form, ICargadorDeDoctores //Clase que representa el formulario de entrada de datos de citas
    {
        // Constructor del formulario. Se ejecuta al crear una instancia de la clase\
        public Entrada_de_datos_cita()
        {
            InitializeComponent();  // Método que inicializa los componentes del formulario
        }

        // Evento que se ejecuta cuando el formulario termina de cargar
        private void Entrada_de_datos_cita_Load(object sender, EventArgs e)
        {
            dateTimePickerFecha.MinDate = DateTime.Today;
            CargarDoctores(); // Llama al método para llenar el combo de doctores desde la base de datos
            CargarHoras(); // Llama al método para llenar el combo con horas disponibles
        }


        // Método para cargar los doctores desde la base de datos y agregarlos al comboBox cmbDoctor
        public void CargarDoctores()
        {
            cmbDoctor.Items.Clear(); // Limpia los ítems actuales del combo
            cmbDoctor.Items.Add("Seleccione una opción"); // Agrega la opción por defecto

            cmbDoctor.Items.Clear();
            cmbDoctor.Items.Add("Seleccione una opción");

            try
            {
                // 2) Crear instancia de tu clase de negocio
                Logica_de_Cita logica = new Logica_de_Cita();

                // 3) Obtener la lista de doctores desde el método
                List<string> listaDoctores = logica.ObtenerNombresDoctores();

                // 4) Rellenar el ComboBox con los datos obtenidos
                foreach (string doctor in listaDoctores)
                {
                    cmbDoctor.Items.Add(doctor);
                }

                // 5) Establecer por defecto el primer elemento (“Seleccione una opción”)
                cmbDoctor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los doctores: " + ex.Message);
            }

            cmbDoctor.SelectedIndex = 0; // Establece la opción por defecto 
        }

        // Método para cargar las horas disponibles en el comboBox cmbHora
        private void CargarHoras()
        {
            cmbHora.Items.Clear(); // Limpia los ítems actuales
            cmbHora.Items.Add("Seleccione una hora");// Agrega opción por defecto
            cmbHora.Items.Add("09:30 AM");
            cmbHora.Items.Add("10:00 AM");
            cmbHora.Items.Add("10:30 AM");
            cmbHora.Items.Add("11:00 AM");
            cmbHora.Items.Add("11:30 AM");
            cmbHora.Items.Add("12:00 PM");

            cmbHora.SelectedIndex = 0; // Establece la opción por defecto
        }

        // Evento que se ejecuta al hacer clic en el botón "Continuar"
        private void btncontinuar_Click(object sender, EventArgs e)
        {
            
            Logica_de_Cita logica = new Logica_de_Cita();
            if (cmbHora.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar una hora válida.");
                return;
            }

            //string hora = cmbHora.Text; // Mantiene el formato "09:30 AM"

            if (cmbDoctor.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un doctor.");
                return;
            }

            DateTime fecha = dateTimePickerFecha.Value.Date;
            TimeSpan hora = DateTime.ParseExact(cmbHora.Text, "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
            int doctorId = logica.ObtenerIdDoctorPorNombre(cmbDoctor.SelectedItem.ToString());

            
            

            if (logica.CitaYaExiste(fecha, hora, doctorId))
            {
                MessageBox.Show("Ya existe una cita para este doctor en esta fecha y hora.", "Conflicto de horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validación: Verifica que todos los campos obligatorios estén llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                
                cmbHora.SelectedIndex == 0 ||
                cmbDoctor.SelectedIndex == 0 ||
                (!rbtnMasculino.Checked && !rbtnFemenino.Checked))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar que el Nombre solo tenga letras y espacios
            if (!txtNombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo Nombre solo debe contener letras.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que el Apellido solo tenga letras y espacios
            if (!txtApellido.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo Apellido solo debe contener letras.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar formato de correo electrónico básico
            if (!IsValidEmail(txtCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que Teléfono solo tenga números y no más de 10 dígitos
            if (!txtTelefono.Text.All(char.IsDigit) || txtTelefono.Text.Length > 10)
            {
                MessageBox.Show("El campo Teléfono debe contener solo números y un máximo de 10 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            // Si todo está correcto
            MessageBox.Show("Todos los datos son válidos. Puedes continuar.", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);



            // Se crea un objeto de tipo Cita con los datos ingresados
            Cita nuevaCita = new Cita()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreoElectronico.Text,
                Telefono = txtTelefono.Text,
                Sexo = rbtnMasculino.Checked ? "Masculino" : "Femenino",
                FechaCita = dateTimePickerFecha.Value,
                HoraCita = hora,
                Doctor = cmbDoctor.SelectedItem.ToString()
            };

            // Se crea una instancia de la lógica de negocio para registrar la cita
            
            try
            {
                // Intenta registrar la cita
                bool resultado = logica.RegistrarCita(nuevaCita);
                if (resultado)
                { MessageBox.Show("Cita registrada con éxito.");

                    CorreoCitaCreada correo = new CorreoCitaCreada();
                    correo.EnviarCorreo(
                         txtCorreoElectronico.Text,
                        "Confirmación de Cita Médica",
                        $@"
                        Hola {txtNombre.Text},

                        Tu cita médica ha sido registrada exitosamente.

                        🗓 Fecha: {dateTimePickerFecha.Value.ToShortDateString()}
                        ⏰ Hora: {cmbHora.Text}
                        👨‍⚕️ Doctor: {cmbDoctor.SelectedItem}

                        Por favor, preséntate con 20 minutos de antelación. 
                        Si no puedes asistir, contáctanos para cancelarla.

                        Gracias por confiar en nuestro centro médico.

                        Atentamente,  
                        Centro Medico UCE"


);
                    string correoDoctor = correo.ObtenerCorreoDoctor(cmbDoctor.SelectedItem.ToString());
                    if (!string.IsNullOrWhiteSpace(correoDoctor))
                    {
                        CorreoCitaCreada correoADoctor = new CorreoCitaCreada();
                        correoADoctor.EnviarCorreo(
                            correoDoctor,
                            "Nueva cita asignada",
                            $@"Hola Dr. {cmbDoctor.SelectedItem},

                            Se le ha asignado una nueva cita con los siguientes datos:

                            🧑 Paciente: {txtNombre.Text} {txtApellido.Text}
                            📅 Fecha: {dateTimePickerFecha.Value.ToShortDateString()}
                            🕒 Hora: {cmbHora.Text}

                            Por favor, asegúrese de estar disponible en el horario indicado.

                            Atentamente,
                            Centro Médico UCE"
                        );
                    }

                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCorreoElectronico.Clear();
                    txtTelefono.Clear();
                    
                    cmbHora.SelectedIndex = 0;
                    cmbDoctor.SelectedIndex = 0;
                    rbtnMasculino.Checked = false;
                    rbtnFemenino.Checked = false;
                    dateTimePickerFecha.Value = DateTime.Today;
                }
                else
                    MessageBox.Show("No se pudo registrar la cita.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método privado para validar si el correo electrónico tiene un formato válido
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true; // Ya no hacemos comparación
            }
            catch
            {
                return false;
            }
        }

    }

}
    
        
    

