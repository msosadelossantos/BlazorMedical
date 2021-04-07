using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Entities
{
    public class MedicoEspecialidad
    {
        public string MedicoEspecialidadId { get; set; }

        public string EspecialidadId { get; set; }
        public virtual Especialidad Especialidad { get; set; }

        public string MedicoId { get; set; }

        public virtual Medico Medico { get; set; }
    }
}
