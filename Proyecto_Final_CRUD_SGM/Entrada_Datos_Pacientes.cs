using CAPA_MODELO_DE_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.Properties
{
    public partial class Entrada_Datos_Pacientes : Form
    {
        public Entrada_Datos_Pacientes()
        {
            InitializeComponent();

        }


        private bool esNuevoPaciente = false;
        private int idPacienteActual = 0;
        private void HabilitarCampos(bool estado)
        {

            txt_Paciente_Nombre.ReadOnly = !estado;
            txt_Paciente_Apellido.ReadOnly = !estado;
            txt_Paciente_Documento.ReadOnly = !estado;
            txt_Paciente_Correo.ReadOnly = !estado;
            txt_Paciente_Telefono.ReadOnly = !estado;


            cmb_Paciente_Genero.Enabled = estado;
            cmb_Paciente_Nacionalidad.Enabled = estado;


            dtp_Paciente_FDN.Enabled = estado;


            btn_Paciente_Cancelar.Enabled = estado;
            btn_Paciente_Guardar.Enabled = estado;
            btn_Paciente_Eliminar.Enabled = !estado;    
        }
        private void CargarCombos()
        {

            cmb_Paciente_Genero.Items.Clear();
            cmb_Paciente_Genero.Items.Add("Masculino");
            cmb_Paciente_Genero.Items.Add("Femenino");


            cmb_Paciente_Nacionalidad.Items.Clear();
            cmb_Paciente_Nacionalidad.Items.AddRange(new string[]
            {
        "Argentino", "Boliviano", "Brasileño", "Canadiense", "Chileno", "Colombiano", "Costarricense", "Cubano",
    "Dominicano", "Ecuatoriano", "Salvadoreño", "Estadounidense", "Granadino", "Guatemalteco", "Guyanés",
    "Haitiano", "Hondureño", "Jamaicano", "Mexicano", "Nicaragüense", "Panameño", "Paraguayo", "Peruano",
    "Kittiano", "Santalucense", "Sanvicentino", "Surinamés", "Trinitense", "Uruguayo", "Venezolano"
            });


            cmb_Paciente_Genero.SelectedIndex = -1;
            cmb_Paciente_Nacionalidad.SelectedIndex = -1;
        }
        private void LimpiarCampos()
        {
            txt_Paciente_Nombre.Clear();
            txt_Paciente_Apellido.Clear();
            txt_Paciente_Documento.Clear();
            cmb_Paciente_Genero.SelectedIndex = -1;
            txt_Paciente_Correo.Clear();
            txt_Paciente_Telefono.Clear();
            dtp_Paciente_FDN.Value = DateTime.Today;
            cmb_Paciente_Nacionalidad.SelectedIndex = -1;
        }

        private void Entrada_Datos_Pacientes_Load(object sender, EventArgs e)
        {
            CargarCombos();
            HabilitarCampos(false);
        }

        private void btn_Paciente_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Paciente_Nombre.Text) ||
    string.IsNullOrWhiteSpace(txt_Paciente_Apellido.Text) ||
    string.IsNullOrWhiteSpace(txt_Paciente_Documento.Text) ||
    string.IsNullOrWhiteSpace(txt_Paciente_Correo.Text) ||
    string.IsNullOrWhiteSpace(txt_Paciente_Telefono.Text) ||
    string.IsNullOrWhiteSpace(cmb_Paciente_Genero.Text) ||
    string.IsNullOrWhiteSpace(cmb_Paciente_Nacionalidad.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar formato del correo
            if (!EsCorreoValido(txt_Paciente_Correo.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar teléfono (solo números y máx 10 dígitos)
            if (!txt_Paciente_Telefono.Text.All(char.IsDigit) || txt_Paciente_Telefono.Text.Length > 10)
            {
                MessageBox.Show("El teléfono debe contener solo números y un máximo de 10 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txt_Paciente_Nombre.Text.Trim();
            string apellido = txt_Paciente_Apellido.Text.Trim();
            string documento = txt_Paciente_Documento.Text.Trim();
            string genero = cmb_Paciente_Genero.Text;
            string correo = txt_Paciente_Correo.Text.Trim();
            string telefono = txt_Paciente_Telefono.Text.Trim();
            DateTime fechaNacimiento = dtp_Paciente_FDN.Value;
            string nacionalidad = cmb_Paciente_Nacionalidad.Text;

            //esNuevoPaciente = false; // Noo es nuevo porque se acaba de guardar
            btn_Paciente_Modificar.Enabled = true; // Ahora podemos modificar

            Logica_Del_Paciente logica = new Logica_Del_Paciente();

            if (esNuevoPaciente)
            {
                int nuevoId = logica.GuardarPaciente(nombre, apellido, documento, genero, correo, telefono, fechaNacimiento, nacionalidad);

                if (nuevoId > 0)
                {
                    idPacienteActual = nuevoId;
                    esNuevoPaciente = false;
                    MessageBox.Show("Paciente guardado correctamente.");
                    HabilitarCampos(false);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar.");
                }
            }
            else
            {
                bool modificado = logica.ModificarPaciente(idPacienteActual, nombre, apellido, documento, genero, correo, telefono, fechaNacimiento, nacionalidad);

                if (modificado)
                {
                    MessageBox.Show("Paciente modificado correctamente.");
                    HabilitarCampos(false);
                }
                else
                {
                    MessageBox.Show("Error al modificar el paciente.");
                }
            }

        }
        private bool EsCorreoValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btn_Paciente_Cancelar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            LimpiarCampos();
            esNuevoPaciente = false;
            btn_Paciente_Modificar.Enabled = true;

        }

        private void btn_Paciente_Modificar_Click(object sender, EventArgs e)
        {
            if (idPacienteActual != 0)
            {
                esNuevoPaciente = false;
                HabilitarCampos(true);
                txt_Paciente_Nombre.Focus();
            }
            else
            {
                MessageBox.Show("Primero debes buscar o seleccionar un paciente.");
            }
        }


        private void btn_Paciente_Eliminar_Click(object sender, EventArgs e)
        {
            {
                if (idPacienteActual == 0)
                {
                    MessageBox.Show("No hay paciente seleccionado.");
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este paciente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    Logica_Del_Paciente logica = new Logica_Del_Paciente();
                    bool eliminado = logica.EliminarPaciente(idPacienteActual);

                    if (eliminado)
                    {
                        MessageBox.Show("Paciente eliminado correctamente.");
                        LimpiarCampos();
                        HabilitarCampos(false);
                        idPacienteActual = 0;
                        esNuevoPaciente = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el paciente.");
                    }
                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            esNuevoPaciente = true;
            idPacienteActual = 0;
            HabilitarCampos(true);
            LimpiarCampos();
            txt_Paciente_Nombre.Focus();
            btn_Paciente_Modificar.Enabled = false;
            btn_Paciente_Eliminar.Enabled = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Busqueda_Paciente buscador = new Busqueda_Paciente();

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                var p = buscador.PacienteSeleccionado;

                txt_Paciente_Nombre.Text = p.Nombre;
                txt_Paciente_Apellido.Text = p.Apellido;
                txt_Paciente_Documento.Text = p.Documento;
                cmb_Paciente_Genero.Text = p.Genero;
                txt_Paciente_Correo.Text = p.Correo;
                txt_Paciente_Telefono.Text = p.Telefono;
                dtp_Paciente_FDN.Value = p.FechaNacimiento;
                cmb_Paciente_Nacionalidad.Text = p.Nacionalidad;

                idPacienteActual = p.ID;
                esNuevoPaciente = false;
                HabilitarCampos(false);
            }
        }
    }
}
