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
using CAPA_MODELO_DE_NEGOCIOS;
using CAPA_LOGICA_DE_NEGOCIOS; 


namespace CAPA_PRESENTACION // Espacio de nombres que agrupa clases relacionadas con la capa de presentación
{
    public partial class Entrada_de_datos_cita : Form //Clase que representa el formulario de entrada de datos de citas
    {
        // Constructor del formulario. Se ejecuta al crear una instancia de la clase\
        public Entrada_de_datos_cita()
        {
            InitializeComponent();  // Método que inicializa los componentes del formulario
        }

        // Evento que se ejecuta cuando el formulario termina de cargar
        private void Entrada_de_datos_cita_Load(object sender, EventArgs e)
        {
            CargarDoctores(); // Llama al método para llenar el combo de doctores desde la base de datos
            CargarHoras(); // Llama al método para llenar el combo con horas disponibles
        }
        

        // Método para cargar los doctores desde la base de datos y agregarlos al comboBox cmbDoctor
        private void CargarDoctores()
        {
            cmbDoctor.Items.Clear(); // Limpia los ítems actuales del combo
            cmbDoctor.Items.Add("Seleccione una opción"); // Agrega la opción por defecto

            try
            {
                // Crea una conexión a la base de datos
                using (SqlConnection conn = new SqlConnection("Server=.;Database=Proyecto_Final_SGM;Integrated Security=true;TrustServerCertificate=True"))
                {
                    conn.Open(); // Abre la conexión

                    // Crea el comando para obtener los nombres de los doctores
                    using (SqlCommand cmd = new SqlCommand("SELECT NOMBRE FROM DOCTORES", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Lee los nombres de los doctores y los agrega al combo
                        while (reader.Read())
                        {
                            cmbDoctor.Items.Add(reader.GetString(0).Trim());
                        }
                    }
                }
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

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {   
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        // Evento que se ejecuta al hacer clic en el botón "Continuar"
        private void btncontinuar_Click(object sender, EventArgs e)
        {
            // Validación: Verifica que todos los campos obligatorios estén llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCedulaPasaporte.Text) ||
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

            // Validar que Cédula/Pasaporte solo tenga números y no más de 10 dígitos
            if (!txtCedulaPasaporte.Text.All(char.IsDigit) || txtCedulaPasaporte.Text.Length > 10)
            {
                MessageBox.Show("El campo Cédula/Pasaporte debe contener solo números y un máximo de 10 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CedulaPasaporte = txtCedulaPasaporte.Text,
                Sexo = rbtnMasculino.Checked ? "Masculino" : "Femenino",
                FechaCita = dateTimePickerFecha.Value,
                HoraCita = cmbHora.SelectedItem.ToString(),
                Doctor = cmbDoctor.SelectedItem.ToString()
            };

            // Se crea una instancia de la lógica de negocio para registrar la cita
            Logica_de_Cita logica = new Logica_de_Cita();
            try
            {  
                // Intenta registrar la cita
                bool resultado = logica.RegistrarCita(nuevaCita);
                if (resultado)
                    MessageBox.Show("Cita registrada con éxito.");
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
                var addr = new System.Net.Mail.MailAddress(email); // Usa la clase MailAddress para validar
                return addr.Address == email;
            }
            catch
            {
                return false; // Si ocurre una excepción, el correo no es válido
            }
        }

    }

}
    
        
    

