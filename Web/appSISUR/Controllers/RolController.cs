using ApplicationCore.Services;
using appSISUR.Utils;
using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Util;

namespace appSISUR.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {

            IEnumerable<Rol> lista = null;
            try
            {
                IServiceRol _ServiceRol = new ServiceRol();
                lista = _ServiceRol.GetRol();
            }
            catch (Exception ex)
            {
                //using web utils
                Log.Error(ex, MethodBase.GetCurrentMethod());
            }
            return View(lista);
        }
    }
}