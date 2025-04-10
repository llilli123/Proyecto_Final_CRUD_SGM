using CAPA_MODELO_DE_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FormReporte : Form
    {
        private int TurnoId, IdPaciente, IdDoctor;
        private DateTime FechaTurno;

        public FormReporte(int turnoId, int pacienteId, int doctorId, DateTime fechaTurno)
        {
            InitializeComponent();
            TurnoId = turnoId;
            IdPaciente = pacienteId;
            IdDoctor = doctorId;
            FechaTurno = fechaTurno;
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            {
                this.Size = new Size(870, 1200);       
                gb_Reporte.Size = new Size(820, 1100); 
                gb_Reporte.Location = new Point(20, 20);

                var logica = new LogicaDelReporte(TurnoId);

                // Obtener datos del paciente
                var paciente = logica.ObtenerDatosPaciente(IdPaciente);
                if (paciente != null)
                {
                    txt_Nombre_Reporte.Text = paciente.Nombre;
                    txt_Apellido_Reporte.Text = paciente.Apellido;
                    txt_Genero_Reporte.Text = paciente.Genero;
                    txt_Documento_Reporte.Text = paciente.Documento;
                    txt_FDN_Reporte.Text = paciente.FechaNacimiento.ToShortDateString();
                }

                // Obtener datos del doctor
                var doctor = logica.ObtenerDatosDoctor(IdDoctor);
                if (doctor != null)
                {
                    txt_DoctorMostrar_Reporte.Text = doctor.Nombre + " " + doctor.Apellido;
                    txt_Fecha_Reporte.Text = FechaTurno.ToShortDateString();
                }

                // Fecha de reporte
                txt_Fecha_Reporte.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void btn_Guardar_Reporte_Click(object sender, EventArgs e)
        {
            var logica = new LogicaDelReporte(TurnoId);

            bool guardado = logica.InsertarReporteMedico(
                IdPaciente,
                IdDoctor,
                rtb_MotivoConsulta.Text,
                rtb_Diagnostico.Text,
                rtb_Tratamiento.Text,
                rtb_Observaciones.Text
            );

            if (guardado)
            {
                MessageBox.Show("Reporte guardado correctamente.");
                Bitmap imagen = CapturarControl(gb_Reporte); // Asegúrate que este sea el panel que contiene TODO el reporte
                ImprimirFormulario(imagen);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el reporte.");
            }
        }
        private Bitmap CapturarControl(Control control)
        {
            control.PerformLayout();
            control.Refresh();

            Bitmap bmp = new Bitmap(control.Width, control.Height);

            control.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
        private void ImprimirFormulario(Bitmap imagen)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) =>
            {
                int x = (e.PageBounds.Width - imagen.Width) / 2;
                int y = 50;
                e.Graphics.DrawImage(imagen, x, y);
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

    }   
}
