//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestucture.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalleCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public detalleCompra()
        {
            this.Ubicacion = new HashSet<Ubicacion>();
        }
    
        public int idCompra { get; set; }
        public int codProducto { get; set; }
        public int cantidad { get; set; }
        public int idUbicacion { get; set; }
    
        public virtual EncabezadoCompra EncabezadoCompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ubicacion> Ubicacion { get; set; }
    }
}
