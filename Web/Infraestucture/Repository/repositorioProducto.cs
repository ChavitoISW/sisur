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
   public class repositorioProducto : IRepositorioProducto
    {
        public Producto GetProductoByCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoById(int id)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByMarca(string marca)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByNombreProducto(string nombre)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByProveedor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetProductos()
        {
            try
            {
                IEnumerable<Producto> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.Producto.ToList<Producto>();
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
    }
}
