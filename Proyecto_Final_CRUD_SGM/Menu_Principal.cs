using CAPA_PRESENTACION.Properties;
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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void gESTIONARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrada_de_datos_cita? Abierto = Application.OpenForms.OfType<Entrada_de_datos_cita>().FirstOrDefault();

            if (Abierto == null)
            {

                Entrada_de_datos_cita form = new Entrada_de_datos_cita();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void gestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Entrada_Datos_Pacientes? Abierto = Application.OpenForms.OfType<Entrada_Datos_Pacientes>().FirstOrDefault();

            if (Abierto == null)
            {

                Entrada_Datos_Pacientes form = new Entrada_Datos_Pacientes();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Gestion? Abierto = Application.OpenForms.OfType<Consulta_Gestion>().FirstOrDefault();

            if (Abierto == null)
            {

                Consulta_Gestion form = new Consulta_Gestion();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Citas? Abierto = Application.OpenForms.OfType<Listado_Citas>().FirstOrDefault();

            if (Abierto == null)
            {

                Listado_Citas form = new Listado_Citas();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }



        private void btn_Menu_Principal_Cita_Click(object sender, EventArgs e)
        {
            Entrada_de_datos_cita? Abierto = Application.OpenForms.OfType<Entrada_de_datos_cita>().FirstOrDefault();

            if (Abierto == null)
            {

                Entrada_de_datos_cita form = new Entrada_de_datos_cita();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void btn_Menu_Principal_Pacientes_Click(object sender, EventArgs e)
        {
            Entrada_Datos_Pacientes? Abierto = Application.OpenForms.OfType<Entrada_Datos_Pacientes>().FirstOrDefault();

            if (Abierto == null)
            {

                Entrada_Datos_Pacientes form = new Entrada_Datos_Pacientes();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void btn_Menu_Principal_Consulta_Click(object sender, EventArgs e)
        {
            Consulta_Gestion? Abierto = Application.OpenForms.OfType<Consulta_Gestion>().FirstOrDefault();

            if (Abierto == null)
            {

                Consulta_Gestion form = new Consulta_Gestion();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaPaciente_Reporte? Abierto = Application.OpenForms.OfType<ListaPaciente_Reporte>().FirstOrDefault();

            if (Abierto == null)
            {

                ListaPaciente_Reporte form = new ListaPaciente_Reporte();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void btn_Menu_Principal_Reportes_Click(object sender, EventArgs e)
        {
            ListaPaciente_Reporte? Abierto = Application.OpenForms.OfType<ListaPaciente_Reporte>().FirstOrDefault();

            if (Abierto == null)
            {

                ListaPaciente_Reporte form = new ListaPaciente_Reporte();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void listadoDeDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorLista? Abierto = Application.OpenForms.OfType<DoctorLista>().FirstOrDefault();

            if (Abierto == null)
            {

                DoctorLista form = new DoctorLista();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_De? Abierto = Application.OpenForms.OfType<Acerca_De>().FirstOrDefault();

            if (Abierto == null)
            {

                Acerca_De form = new Acerca_De();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }
        }

        private void verConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor_Consulta_Reporte? Abierto = Application.OpenForms.OfType<Doctor_Consulta_Reporte>().FirstOrDefault();

            if (Abierto == null)
            {

                Doctor_Consulta_Reporte form = new Doctor_Consulta_Reporte();
                form.Show();
            }
            else
            {

                Abierto.BringToFront();
                Abierto.Focus();
            }

        }
    }
}
