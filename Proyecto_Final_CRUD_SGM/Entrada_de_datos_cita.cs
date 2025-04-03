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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CAPA_PRESENTACION // Espacio de nombres que agrupa clases relacionadas con la capa de presentación
{
    public partial class Entrada_de_datos_cita : Form //Clase que representa el formulario de entrada de datos de citas
    {
        public Entrada_de_datos_cita() 
        {
            InitializeComponent();  // Método que inicializa los componentes del formulario
        }

        private void Entrada_de_datos_cita_Load(object sender, EventArgs e)
        {
            // Restringir la selección de fechas anteriores a hoy
            dateTimePicker2.MinDate = DateTime.Today;

            // Agrega opciones a la lista desplegable de seguros médicos
            cmbSeguro.Items.Add("Seleccione una opción");
            cmbSeguro.Items.Add("Seguros Universal");
            cmbSeguro.Items.Add("Mapfre BHD Seguros");
            cmbSeguro.Items.Add("Seguros Sura");
            cmbSeguro.Items.Add("Humano Seguros");
            cmbSeguro.Items.Add("La Colonial de Seguros");
            cmbSeguro.Items.Add("Seguros Banreservas");
            cmbSeguro.Items.Add("Seguros Crecer");
            cmbSeguro.Items.Add("Atlántica Seguros");
            cmbSeguro.SelectedIndex = 0;  // Establece la opción por defecto

            // Agrega opciones a la lista desplegable de doctores disponibles
            cmbDoctor.Items.Add("Seleccione una opción");
            cmbDoctor.Items.Add("Dr. Jorge Parra");
            cmbDoctor.Items.Add("Dra. María Rodríguez");
            cmbDoctor.Items.Add("Dr. Carlos Sánchez");
            cmbDoctor.Items.Add("Dra. Laura Martínez");

            cmbDoctor.SelectedIndex = 0; // Establece la opción por defecto


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si todos los campos obligatorios están llenos
             if (string.IsNullOrEmpty(txtNombre.Text) ||
                 string.IsNullOrEmpty(txtApellido.Text) ||
                 string.IsNullOrEmpty(txtCedulaPasaporte.Text) ||
                 string.IsNullOrEmpty(txtTelefono.Text) ||
                 string.IsNullOrEmpty(txtCorreoElectronico.Text) ||
                 string.IsNullOrEmpty(cmbDoctor.Text) ||
                 string.IsNullOrEmpty(cmbSeguro.Text))

                {
                    MessageBox.Show("Por favor, llene todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución si hay campos vacíos
                }

                // Validación del campo Nombre (solo letras y espacios)
                if (!txtNombre.Text.All(c => char.IsLetter(c) || c == ' '))
                {
                    MessageBox.Show("El campo 'Nombre' debe contener solo letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validación del campo Apellido (solo letras y espacios)
                if (!txtApellido.Text.All(c => char.IsLetter(c) || c == ' '))
                {
                    MessageBox.Show("El campo 'Apellido' debe contener solo letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validación del número de teléfono (debe ser un número de 10 dígitos)
                if (!IsValidPhoneNumber(txtTelefono.Text))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido (10 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validación del correo electrónico
                if (!IsValidEmail(txtCorreoElectronico.Text))
                {
                    MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de Cédula/Pasaporte
                if (string.IsNullOrWhiteSpace(txtCedulaPasaporte.Text))
                {
                    MessageBox.Show("El campo 'Cédula/Pasaporte' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Si todas las validaciones son correctas, se muestra un mensaje de éxito
                MessageBox.Show("Cita registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier error inesperado
                MessageBox.Show("Ocurrió un error inesperado: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para validar número de teléfono (10 dígitos numéricos)
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10}$"); // Solo acepta números con 10 dígitos
        }

        // Función para validar correo electrónico
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Expresión regular para un correo electrónico válido
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }

}
    
        
    

