using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    // Clase que representa el modelo de una cita médica dentro de la capa de modelo de negocios
    public class Cita
    {
        // Nombre del paciente que agenda la cita
        public string Nombre { get; set; }

        // Apellido del paciente
        public string Apellido { get; set; }

        // Correo electrónico del paciente
        public string Correo { get; set; }

        // Número de teléfono del paciente
        public string Telefono { get; set; }

        // Fecha en la que se agendó la cita
        public DateTime FechaCita { get; set; }

        // Hora en la que se realizará la cita
        public TimeSpan HoraCita { get; set; }

        // Cédula o pasaporte del paciente, usado como identificador
        public string CedulaPasaporte { get; set; }

        // Sexo del paciente (Masculino o Femenino)
        public string Sexo { get; set; }

        // Nombre del doctor asignado a la cita
        public string Doctor { get; set; }
    }
}