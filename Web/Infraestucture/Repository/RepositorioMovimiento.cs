using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    class RepositorioMovimiento : IRepositorioMovimiento
    {
        public IEnumerable<movimientoTipo> GetMovimientoTipo()
        {
            throw new NotImplementedException();
        }

        public movimientoTipo GetMovimientoTipoById(int id)
        {
            throw new NotImplementedException();
        }

        public movimientoTipo GetMovimientoTipoByTipo(int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
