//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FRENICSA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class trabajador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trabajador()
        {
            this.ingreso = new HashSet<ingreso>();
            this.venta = new HashSet<venta>();
        }
    
        public int idtrabajador { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string Sexo { get; set; }
        public System.DateTime fecha_nac { get; set; }
        public string cedula { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string acceso { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ingreso> ingreso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> venta { get; set; }
    }
}
