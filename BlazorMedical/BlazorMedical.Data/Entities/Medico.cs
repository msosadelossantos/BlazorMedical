using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Entities
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }

        public string Apellido { get; set; }
        public string Apellido2 { get; set; }
        public string Dni { get; set; }

        public string Cuit { get; set; }



        public DateTime FechaDeNacimiento { get; set; }

        public string DireccionCalle { get; set; }

        public string DireccionNumero { get; set; }

        public string DireccionProvincia { get; set; }

        public string DireccionLocalidad { get; set; }

        public string DireccionCp { get; set; }

        public string DireccionPais { get; set; }

        public string PaisNacimiento { get; set; }

        public virtual IEnumerable<MedicoEspecialidad> MedicoEspecialidades { get; set; }

    }
}
