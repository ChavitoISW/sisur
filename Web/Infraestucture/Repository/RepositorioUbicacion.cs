using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    class RepositorioUbicacion : IRepositorioUbicacion
    {
        public IEnumerable<Ubicacion> GetUbicacion()
        {
            throw new NotImplementedException();
        }

        public Ubicacion GetUbicacionByEstado(int estado)
        {
            throw new NotImplementedException();
        }

        public Ubicacion GetUbicacionByName(string ubicacion)
        {
            throw new NotImplementedException();
        }
    }
}
