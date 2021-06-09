using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    class RepositorioMarca : IRepositorioMarca
    {
        public IEnumerable<Marca> GetMarca()
        {
            throw new NotImplementedException();
        }

        public Marca GetMarcaById(int id)
        {
            throw new NotImplementedException();
        }

        public Marca GetMarcaByNombre(string marca)
        {
            throw new NotImplementedException();
        }
    }
}
