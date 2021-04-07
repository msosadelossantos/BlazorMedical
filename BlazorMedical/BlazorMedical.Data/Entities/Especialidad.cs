using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Entities
{
   public class Especialidad
    {
        public string EspecialidadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
  
        public virtual IEnumerable<MedicoEspecialidad> MedicoEspecialidades { get; set; }
    }
}
