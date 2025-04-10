using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS.Interfaces
{
    // Define un contrato que obliga a implementar un metodo para cargar la lista de doctores
    public interface ICargadorDeDoctores
    {
        // TODO Metodo obligatorio para cargar doctores
        void CargarDoctores();
    }
}

    