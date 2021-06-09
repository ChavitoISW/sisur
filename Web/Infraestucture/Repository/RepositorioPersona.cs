using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    class RepositorioPersona : IRepositorioPersona
    {
        public IEnumerable<Persona> GetPersona()
        {
            throw new NotImplementedException();
        }

        public Persona GetPersonaById(int id)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersonaByNombre(string nombrePersona)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersonaByRol(int rol)
        {
            throw new NotImplementedException();
        }
    }
}
