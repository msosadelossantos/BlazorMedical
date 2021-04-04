using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Entities
{
   public class Especialidad
    {
        public int EspecialidadId { get; set; }
        public string Nombre { get; set; }
        public int Descripcion { get; set; }
  
        public virtual IEnumerable<MedicoEspecialidad> MedicoEspecialidades { get; set; }
    }
}
