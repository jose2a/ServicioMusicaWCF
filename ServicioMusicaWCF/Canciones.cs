//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioMusicaWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Canciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Canciones()
        {
            this.DetallesConcierto = new HashSet<DetallesConcierto>();
        }
    
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Duracion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesConcierto> DetallesConcierto { get; set; }
    }
}
