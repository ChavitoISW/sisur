using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServiceProveedor : IServiceProveedor
    {
        public IEnumerable<Proveedor> GetProveedor()
        {
            IRepositorioProveedor repositoryProveedor = new RepositorioProveedor();
            return repositoryProveedor.GetProveedor();
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
