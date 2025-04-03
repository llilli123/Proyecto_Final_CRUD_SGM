using System;
using System.Diagnostics.Eventing.Reader;
using CAPA_MODELO_DE_NEGOCIOS;
using CAPA_PRESENTACION;
using System.Windows.Forms;
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
                txt_Login_Usuario.ForeColor = Color.Black;
            }
        }

        private void txt_Login_Contrasena_Enter(object sender, EventArgs e)
        {
            if (txt_Login_Contrasena.Text == "Contraseña")
            {
                txt_Login_Contrasena.Text = "";
                txt_Login_Contrasena.ForeColor = Color.Black;
                txt_Login_Contrasena.UseSystemPasswordChar = true;

            }
        }

        private void txt_Login_Contrasena_Leave(object sender, EventArgs e)
        {
            if (txt_Login_Contrasena.Text == "")
            {
                txt_Login_Contrasena.Text = "Contraseña";
                txt_Login_Contrasena.ForeColor = Color.DimGray;
                txt_Login_Contrasena.UseSystemPasswordChar = false;

            }
        }

        private void btn_Login_Conectarse_Click(object sender, EventArgs e)
        {
            string usuario = txt_Login_Usuario.Text.Trim();
            string contrasena = txt_Login_Contrasena.Text.Trim();
            int idRol;

            if (usuario == "" || contrasena == "" || usuario == "Usuario" || contrasena == "Contraseña")
                {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                (usuario == ""  ? txt_Login_Usuario : txt_Login_Contrasena).Focus();
                return;
            }

            if (!int.TryParse(contrasena, out _))
            {
                MessageBox.Show("La contraseña debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Login_Contrasena.Clear();
                txt_Login_Contrasena.Focus();
                return;
            }

            if (logica_Login.SesionConectar(usuario, contrasena, out idRol)) 
            {
                MessageBox.Show($" Bienvenido {usuario}");


                Menu_Principal menu = new Menu_Principal();
                menu.Show();
                this.Hide();
            }
            else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Login_Contrasena.Clear();
                txt_Login_Usuario.Clear();
                txt_Login_Usuario.Focus();
                }
            } 

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Login_Contrasena.UseSystemPasswordChar = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (cbx_Mostrar_Contrasena.Checked)
            {
                if (txt_Login_Contrasena.Text != "Contraseña")
                {
                    txt_Login_Contrasena.UseSystemPasswordChar = false; 
                }
            }
            else
            {
                if (txt_Login_Contrasena.Text != "Contraseña")
                {
                    txt_Login_Contrasena.UseSystemPasswordChar = true; 
                }
            }
        }

        private void txt_Login_Usuario_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txt_Login_Contrasena.Focus();
            }
        }

        private void txt_Login_Contrasena_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_Login_Conectarse.PerformClick();
            }
        }
    }
}
