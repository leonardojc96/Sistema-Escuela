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
    
    public partial class Tipos_de_cancelacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipos_de_cancelacion()
        {
            this.Clases = new HashSet<Clases>();
        }
    
        public int id_tipocancelacion { get; set; }
        public string nombre { get; set; }
        public bool clase_impartida { get; set; }
        public Nullable<bool> implica_pago_profesor { get; set; }
        public Nullable<bool> implica_cobro_cliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clases> Clases { get; set; }
    }
}
