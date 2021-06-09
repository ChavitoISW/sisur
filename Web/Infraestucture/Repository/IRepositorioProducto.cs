using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
   public interface IRepositorioProducto
    {
        IEnumerable<Producto> GetProductos();
        Producto GetProductoById(int id);
        Producto GetProductoByCodigo(int id);
        Producto GetProductoByProveedor(int id);
        Producto GetProductoByMarca(String  marca);
        Producto GetProductoByNombreProducto(String nombre);
    }
}
