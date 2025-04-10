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

namespace CAPA_PRESENTACION
{
    //TODO Esta clase representa un formulario de búsqueda de pacientes.
    public partial class Busqueda_Paciente : Form
    {
        // Esta propiedad almacena el paciente seleccionado.
        public PacienteSeleccionado PacienteSeleccionado { get; set; }

        // Constructor de la clase Busqueda_Paciente.
        public Busqueda_Paciente()
        {
            InitializeComponent();
        }

        //
        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            // Verifica si hay filas seleccionadas en el DataGridView.
            if (dgv_Busqueda_Pax.SelectedRows.Count > 0)
            {
                var fila = dgv_Busqueda_Pax.SelectedRows[0];

                // Crea una nueva instancia de PacienteSeleccionado y asigna los valores de la fila seleccionada.
                PacienteSeleccionado = new PacienteSeleccionado
                {
                    ID = Convert.ToInt32(fila.Cells["PACIENTE_ID"].Value),
                    Nombre = fila.Cells["NOMBRE"].Value.ToString(),
                    Apellido = fila.Cells["APELLIDO"].Value.ToString(),
                    Documento = fila.Cells["DOCUMENTO"].Value.ToString(),
                    Genero = fila.Cells["GENERO"].Value.ToString(),
                    Correo = fila.Cells["CORREO"].Value.ToString(),
                    Telefono = fila.Cells["TELEFONO"].Value.ToString(),
                    FechaNacimiento = Convert.ToDateTime(fila.Cells["FECHA_NACIMIENTO"].Value),
                    Nacionalidad = fila.Cells["NACIONALIDAD"].Value.ToString()
                };
                // Cierra el formulario
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txt_BuscarNombreyApellido_TextChanged(object sender, EventArgs e)
        {
            {
                
                string texto = txt_BuscarNombreyApellido.Text.Trim();
                LogicaBusquedaPAx logica = new LogicaBusquedaPAx();
                dgv_Busqueda_Pax.DataSource = logica.BuscarPacientes(texto);
                // Verifica si hay filas en el DataGridView.
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
