using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RegistroCompletoAPP.Models.Validaciones;

namespace RegistroCompletoAPP.Models
{
    public class Personas
    {
        [Key]
        [IdValidacion]
        public int PersonaId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir un nombre")]
        [NombresValidacion]
        public string Nombres { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir un teléfono")]
        [TelefonoValidacion]
        public string Telefono { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir una cédula")]
        [CedulaValidacion]
        public string Cedula { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir una dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir una fecha")]
        [FechaNacimientoValidacion]
        public DateTime FechaNacimiento { get; set; }
    }
}
