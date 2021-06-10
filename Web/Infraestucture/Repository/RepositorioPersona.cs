using Infraestucture.Models;
using Infraestucture.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public class RepositorioPersona : IRepositorioPersona
    {
        public IEnumerable<Persona> GetPersona()
        {
            try
            {
                IEnumerable<Persona> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.Persona.ToList<Persona>();
                }
                return lista;
            }
            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
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
