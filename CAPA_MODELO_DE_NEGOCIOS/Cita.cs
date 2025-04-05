using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    public class Cita
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCita { get; set; }
        public string HoraCita { get; set; }
        public string CedulaPasaporte { get; set; }
        public string Sexo { get; set; }
        public string Doctor { get; set; }
    }
}
