using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Models
{
   internal partial class posicionMetadata
    {
        [Display(Name="Identificador Ubicación")]
        public int idUbicacion { get; set; }

        [Display(Name = "Codigo Producto")]
        public int codProducto { get; set; }

        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        public virtual ICollection<detalleMovimiento> detalleMovimiento { get; set; }

        [Display(Name = "Producto")]
        public virtual Producto Producto { get; set; }

        [Display(Name = "Ubicación")]
        public virtual Ubicacion Ubicacion { get; set; }
    }

    internal partial class productoMetadata
    {
        [Display(Name = "Id. Producto")]
        public int idProducto { get; set; }

        [Display(Name = "Codigo")]
        public int codProducto { get; set; }

        [Display(Name = "Cod. Proveedor")]
        public int codProveedor { get; set; }

        [Display(Name = "Id Marca")]
        public int idMarca { get; set; }

        [Display(Name = "Nombre Producto")]
        public string descripcionProducto { get; set; }

        [Display(Name = "Modelo")]
        public string modeloProducto { get; set; }

        [Display(Name = "Cantidad Maxima")]
        public int cantMaxima { get; set; }

        [Display(Name = "Cantidad Minima")]
        public int cantMinima { get; set; }

        [Display(Name = "Precio")]
        public int costo { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        [Display(Name = "Contacto")]
        public virtual ICollection<Contacto> Contacto { get; set; }

        [Display(Name = "Detalle Movimiento")]
        public virtual ICollection<detalleMovimiento> detalleMovimiento { get; set; }

        [Display(Name = "Marca")]
        public virtual Marca Marca { get; set; }

        [Display(Name = "Posicion")]
        public virtual ICollection<posicion> posicion { get; set; }
    }

    internal partial class ubicacionMetadata
    {
        [Display(Name = "Id Ubicación")]
        public int idUbicacion { get; set; }

        [Display(Name = "Ubicación")]
        public string descUbicacion { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        [Display(Name = "Posición")]
        public virtual ICollection<posicion> posicion { get; set; }

    }


}
