using System;
using CAPA_MODELO_DE_NEGOCIOS;
using CAPA_PRESENTACION;

namespace Proyecto_Final_CRUD_SGM
{
    public partial class Login : Form
    {
        private Logica_Login logica_Login = new Logica_Login();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Salir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txt_Login_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Login_Usuario.Text == "")
            {
                txt_Login_Usuario.Text = "Usuario";
                txt_Login_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_Login_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Login_Usuario.Text == "Usuario")
            {
                txt_Login_Usuario.Text = "";
                txt_Login_Usuario.ForeColor = Color.Gold;
            }
        }

        private void txt_Login_Contrasena_Enter(object sender, EventArgs e)
        {
            if (txt_Login_Contrasena.Text == "Contraseña")
            {
                txt_Login_Contrasena.Text = "";
                txt_Login_Contrasena.ForeColor = Color.Gold;

            }
        }

        private void txt_Login_Contrasena_Leave(object sender, EventArgs e)
        {
            if (txt_Login_Contrasena.Text == "")
            {
                txt_Login_Contrasena.Text = "Contraseña";
                txt_Login_Contrasena.ForeColor = Color.DimGray;

            }
        }

        private void btn_Login_Conectarse_Click(object sender, EventArgs e)
        {
            string usuario = txt_Login_Usuario.Text.Trim();
            string contrasena = txt_Login_Contrasena.Text.Trim();
            int idRol; 

            bool resultado = logica_Login.SesionConectar(usuario, contrasena, out idRol);

            if (resultado)
            {
                MessageBox.Show($" Bienvenido {usuario}");

                
                Menu_Principal menu = new Menu_Principal();
                menu.Show();
                this.Hide();  
            }
        }
    }
}
