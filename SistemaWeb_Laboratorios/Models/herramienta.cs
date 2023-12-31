//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaWeb_Laboratorios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class herramienta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public herramienta()
        {
            this.detalle_prestamo = new HashSet<detalle_prestamo>();
            this.prestamo = new HashSet<prestamo>();
        }
    
        public int IdHerramienta { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public bool activo { get; set; }
        public string observaciones { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<int> id_marca { get; set; }
        public Nullable<int> id_categoria { get; set; }
    
        public virtual categoria_herramienta categoria_herramienta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_prestamo> detalle_prestamo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prestamo> prestamo { get; set; }
        public virtual marca_herramienta marca_herramienta { get; set; }
    }
}
