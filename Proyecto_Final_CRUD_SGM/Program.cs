using CAPA_PRESENTACION;
using CAPA_PRESENTACION.Properties;

namespace Proyecto_Final_CRUD_SGM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            ApplicationConfiguration.Initialize();

          
            var login = new Login();
            if (login.ShowDialog() == DialogResult.OK && login.FormularioParaAbrir != null)
            {
                Application.Run(login.FormularioParaAbrir);
            }
        }
    }
}