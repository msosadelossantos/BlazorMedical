using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Entities
{
    public class Pais
    {
        public string PaisId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual IEnumerable<Medico> Medicos { get; set; }
        public virtual IEnumerable<Medico> MedicosRecidencia { get; set; }
        public virtual IEnumerable<Paciente> Pacientes { get; set; }
        public virtual IEnumerable<Paciente> PacientesRecidencia { get; set; }


    }
}
