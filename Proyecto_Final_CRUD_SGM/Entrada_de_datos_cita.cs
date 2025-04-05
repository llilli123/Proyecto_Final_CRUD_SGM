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
        public Entrada_de_datos_cita()
        {
            InitializeComponent();  // Método que inicializa los componentes del formulario
        }

        private void Entrada_de_datos_cita_Load(object sender, EventArgs e)
        {
            CargarDoctores();
            CargarHoras();
        }
        private void CargarDoctores()
        {
            cmbDoctor.Items.Clear();
            cmbDoctor.Items.Add("Seleccione una opción");

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=.;Database=Proyecto_Final_SGM;Integrated Security=true;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT NOMBRE FROM DOCTORES", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
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

            cmbDoctor.SelectedIndex = 0;
        }

        private void CargarHoras()
        {
            cmbHora.Items.Clear();
            cmbHora.Items.Add("Seleccione una hora");
            cmbHora.Items.Add("09:30 AM");
            cmbHora.Items.Add("10:00 AM");
            cmbHora.Items.Add("10:30 AM");
            cmbHora.Items.Add("11:00 AM");
            cmbHora.Items.Add("11:30 AM");
            cmbHora.Items.Add("12:00 PM");

            cmbHora.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
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

            Logica_de_Cita logica = new Logica_de_Cita();
            try
            {
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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
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

            Logica_de_Cita logica = new Logica_de_Cita();
            try
            {
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
    }

}
    
        
    

