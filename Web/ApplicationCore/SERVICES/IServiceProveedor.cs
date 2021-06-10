using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public interface IServiceProveedor
    {
        IEnumerable<Proveedor> GetProveedor();
        Proveedor GetProveedorByCodigo(int codigo);
        Proveedor GetProveedorByNombre(String nombre);
        Proveedor GetProveedorByestado(int estado);
    }
}
