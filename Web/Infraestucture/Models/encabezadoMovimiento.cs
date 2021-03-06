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
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(encabezadoMetadata))]

    public partial class encabezadoMovimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public encabezadoMovimiento()
        {
            this.detalleMovimiento = new HashSet<detalleMovimiento>();
        }
    
        public int consMovimiento { get; set; }
        public int idMovimientoTipo { get; set; }
        public string idPersona { get; set; }
        public Nullable<int> codProveedor { get; set; }
        public string idEmpleado { get; set; }
        public string fecha { get; set; }
        public string documento { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleMovimiento> detalleMovimiento { get; set; }
        public virtual movimientoTipo movimientoTipo { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Persona Persona1 { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
