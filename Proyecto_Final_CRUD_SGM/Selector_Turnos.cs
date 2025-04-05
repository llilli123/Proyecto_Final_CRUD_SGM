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
    public partial class Selector_Turnos : Form
    {

        public int TurnoSeleccionado { get; private set; }
        public Selector_Turnos()
        {
            InitializeComponent();
        }

        public void CargarTurnosConsulta(DataTable tabla)
        {
            dgv_Turnos.DataSource = tabla;
        }

        private void Selector_Turnos_Load(object sender, EventArgs e)
        {
            dgv_Turnos.DataSource = Selector_Turnos_Logica.TomaTurno();
        }
        private void dgvTurnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TurnoSeleccionado = Convert.ToInt32(dgv_Turnos.Rows[e.RowIndex].Cells["ID_TURNO"].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_Turnos_Seleccionar_Click(object sender, EventArgs e)
        {
            if (dgv_Turnos.SelectedRows.Count > 0)
            {
                var fila = dgv_Turnos.SelectedRows[0];
                TurnoSeleccionado = Convert.ToInt32(fila.Cells["ID_TURNO"].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un turno de la lista.");
            }
        }
    }

}
