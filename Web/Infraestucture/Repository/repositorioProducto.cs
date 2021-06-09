using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    class repositorioProducto : IRepositorioProducto
    {
        public Producto GetProductoByCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoById(int id)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByMarca(string marca)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByNombreProducto(string nombre)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByProveedor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetProductos()
        {
            throw new NotImplementedException();
        }
    }
}
