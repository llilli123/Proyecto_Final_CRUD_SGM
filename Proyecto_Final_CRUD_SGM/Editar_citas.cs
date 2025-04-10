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

namespace CAPA_PRESENTACION
{
    public partial class Editar_citas : Form
    {
        public int IdCita { get; set; }

        public string Nombre => txtNombre.Text;
        public string Apellido => txtApellido.Text;
        public string Correo => txtCorreo.Text;
        public int Telefono => int.Parse(txtTelefono.Text);
        public DateTime Fecha => dtp_Fecha.Value;
        public string Hora => txtHora.Text;
        

        public Editar_citas(int id, string nombre, string apellido, string correo, int telefono, DateTime fecha, string hora)
        {
            InitializeComponent();

            IdCita = id;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtCorreo.Text = correo;
            txtTelefono.Text = telefono.ToString();
            dtp_Fecha.Value = fecha;
            txtHora.Text = hora;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Puedes validar si quieres
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos sean válidos (no estén vacíos)
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtTelefono.Text))
                
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                // Obtener los datos modificados en los campos de texto
                int idCita = this.IdCita; // Asumimos que este es el ID de la cita actual
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string correo = txtCorreo.Text;
                int telefono = Convert.ToInt32(txtTelefono.Text);
                DateTime fecha = dtp_Fecha.Value;
                string hora = txtHora.Text;
                

                // Llamar al método para guardar los cambios
                LogicaCitas logica = new LogicaCitas();
                bool resultado = logica.ModificarCita(idCita, nombre, apellido, correo, telefono, fecha, hora);

                if (resultado)
                {
                    MessageBox.Show("Cita guardada correctamente.");
                    this.DialogResult = DialogResult.OK; // Cierra el formulario y devuelve el resultado OK
                    this.Close(); // Cierra el formulario de edición
                }
                else
                {
                    MessageBox.Show("Error al guardar la cita. Intenta nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message);
            }
        }    }    }