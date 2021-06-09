using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    class RepositorioProveedor : IRepositorioProveedor
    {
        public IEnumerable<Proveedor> GetProveedor()
        {
            throw new NotImplementedException();
        }

        public Proveedor GetProveedorByCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public Proveedor GetProveedorByestado(int estado)
        {
            throw new NotImplementedException();
        }

        public Proveedor GetProveedorByNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
