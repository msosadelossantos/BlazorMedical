using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Entities
{
    public class Paciente
    {

        public string PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }

        public string Apellido { get; set; }
        public string Apellido2 { get; set; }
        public string Dni { get; set; }

        public string Cuit { get; set; }

        public DateTime FechaDeNacimiento { get; set; }

        public string DireccionCalle { get; set; }

        public string DireccionNumero { get; set; }

        public string DireccionProvinciaId { get; set; }
        public virtual Provincia DireccionProvincia { get; set; }

        public string DireccionLocalidad { get; set; }

        public string DireccionCp { get; set; }

        public string DireccionPaisId { get; set; }
        public virtual Pais DireccionPais { get; set; }

        public string PaisNacimientoId { get; set; }
        public virtual Pais PaisNacimiento { get; set; }
    }
}
