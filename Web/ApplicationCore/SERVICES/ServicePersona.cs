using ApplicationCore.Utils;
using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServicePersona : IServicePersona
    {
        public IEnumerable<Persona> GetPersona()
        {
            IRepositorioPersona repositoryPersona = new RepositorioPersona();
            return repositoryPersona.GetPersona();
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

        public Persona GetPersonaLogin(string idPersona, string password)
        {
            IRepositorioPersona repository = new RepositorioPersona();
            // Encriptar el password para poder compararlo
            string crytpPasswd = Cryptography.EncrypthAES(password);
            return repository.GetPersonaLogin(idPersona, crytpPasswd);
        }

    }
}
