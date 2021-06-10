using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
   public class ServiceProducto : IServiceProducto
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
            IRepositorioProducto repositoryProducto = new repositorioProducto();
            return repositoryProducto.GetProductos();
        }
    }
}
