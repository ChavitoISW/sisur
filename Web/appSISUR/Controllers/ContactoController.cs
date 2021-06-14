using ApplicationCore.SERVICES;
using appSISUR.Utils;
using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace appSISUR.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        public ActionResult Index()
        {
            IEnumerable<Contacto> lista = null;
            try
            {
                IServiceContacto _ServiceContacto = new ServiceContacto();
                lista = _ServiceContacto.GetContacto();
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