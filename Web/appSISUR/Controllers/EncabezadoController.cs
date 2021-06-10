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
    public class EncabezadoController : Controller
    {
        // GET: Encabezado
        public ActionResult Index()
        {
            IEnumerable<encabezadoMovimiento> lista = null;
            try
            {
                IServicoEncabezado _ServiceEncabezado = new ServicioEncabezado();
                lista = _ServiceEncabezado.GetEncabezadoMovimientos();
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