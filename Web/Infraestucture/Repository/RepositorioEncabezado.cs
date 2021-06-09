using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    class RepositorioEncabezado : IRepositorioEncabezado
    {
        public IEnumerable<encabezadoMovimiento> GetEncabezadoMovimientos()
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByCliente(int cedulaCliente)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByConsecutivo(int consecutivo)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByEmpleado(int empleado)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByFecha(string fecha)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByPersona(int idPersona)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByProveedor(int cedulaProveedor)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByTipo(int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
