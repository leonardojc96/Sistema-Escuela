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
    
    public partial class Tipos_de_tarea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipos_de_tarea()
        {
            this.Clases = new HashSet<Clases>();
            this.Horarios = new HashSet<Horarios>();
        }
    
        public int id_tipotarea { get; set; }
        public string nombre { get; set; }
        public Nullable<bool> lectiva { get; set; }
        public Nullable<bool> transporte { get; set; }
        public Nullable<bool> administrativa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clases> Clases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horarios> Horarios { get; set; }
    }
}
