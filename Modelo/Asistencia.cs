//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscuelaForm.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asistencia
    {
        public int id_asistencia { get; set; }
        public Nullable<int> id_clase { get; set; }
        public Nullable<int> id_alumnoengrupo { get; set; }
        public Nullable<bool> asiste { get; set; }
        public Nullable<bool> falta_justificada { get; set; }
    
        public virtual Alumnos_en_grupos Alumnos_en_grupos { get; set; }
        public virtual Clases Clases { get; set; }
    }
}
