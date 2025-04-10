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
    public partial class Listado_Citas : Form
    {
        public Listado_Citas()
        {
            InitializeComponent();
        }

        private void Listado_Citas_Load(object sender, EventArgs e)
        {
            CargarCitas();
        }
        private void CargarCitas()
        {
            LogicaCitas logica = new LogicaCitas();
            dgvCitas.DataSource = logica.ObtenerCitas();

        }




        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            {
                if (dgvCitas.SelectedRows.Count > 0)
                {
                    int citaId = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["ID_CITA"].Value);
                    LogicaCitas logica = new LogicaCitas();
                    if (logica.EliminarCita(citaId))
                    {
                        MessageBox.Show("Cita eliminada correctamente");
                        CargarCitas();
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
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["ID_CITA"].Value);
                string nombre = dgvCitas.SelectedRows[0].Cells["NOMBRE"].Value.ToString();
                string apellido = dgvCitas.SelectedRows[0].Cells["APELLIDO"].Value.ToString();
                string correo = dgvCitas.SelectedRows[0].Cells["CORREO"].Value.ToString();
                int telefono = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["TELEFONO"].Value);
                DateTime fecha = Convert.ToDateTime(dgvCitas.SelectedRows[0].Cells["FECHA"].Value);
                string hora = dgvCitas.SelectedRows[0].Cells["HORA"].Value.ToString();
                

                Editar_citas form = new Editar_citas (id, nombre, apellido, correo, telefono, fecha, hora);

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
        }     }    }