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
    
    public partial class EncabezadoCompra
    {
        public int idCompra { get; set; }
        public Nullable<int> idProveedor { get; set; }
        public Nullable<int> idMovimiento { get; set; }
        public string documento { get; set; }
        public string estado { get; set; }
    
        public virtual detalleCompra detalleCompra { get; set; }
        public virtual movimientoTipo movimientoTipo { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
