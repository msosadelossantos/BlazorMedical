using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Entities
{
    public class MedicoEspecialidad
    {
        public int MedicoEspecialidadId { get; set; }

      

        public int EspecialidadId { get; set; }
        public virtual Especialidad Especialidad { get; set; }


        public int MedicoId { get; set; }

        public virtual Medico Medico { get; set; }
    }
}
