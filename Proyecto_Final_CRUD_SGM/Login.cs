namespace Proyecto_Final_CRUD_SGM
{
    public partial class Login : Form
    {
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
    }
}
