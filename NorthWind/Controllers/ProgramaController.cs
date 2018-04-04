using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWind.Controllers
{
    public class ProgramaController : Controller
    {
        // GET: Programa
        public ActionResult Index()
        {
            var Context = new Model.SaludMovilEntities();
            return View(Context.sm_Programa.ToList());
        }

        public JsonResult Details(int id)
        {
            JsonResult resultado;
            var Context = new SaludMovilEntities();
            return resultado = Json(Context.sm_Programa.Find(id),JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Proporciones los datos del programa";
            ViewBag.TimeServer = DateTime.UtcNow;
            sm_Programa programa = new sm_Programa();
            var Context = new SaludMovilEntities();
            var Estados = Context.sm_Estado.Select(e => new { e.idEstado,e.nombre });
            ViewBag.idEstado = new SelectList(Estados,"idEstado","nombre");
            var Poblaciones = Context.sm_Poblacion.Select(p => new { p.idPoblacion , p.descripcion });
            ViewBag.poblacionObjetivo = new SelectList(Poblaciones, "idPoblacion", "descripcion");
            return View(programa);
        }
        [HttpPost]
        public ActionResult Create(sm_Programa programa)
        {
            ActionResult Result;
            
            if (ModelState.IsValid)
            {
                var Context = new SaludMovilEntities();
                Context.sm_Programa.Add(programa);
                Context.SaveChanges();
                Result = RedirectToAction("Details",new { id = programa.idPrograma});
            }
            else
            {
                Result = View(programa);
            }
            return Result;
        }

        public ActionResult NoAutorizado() => new HttpUnauthorizedResult("Acceso denegado");
        public ActionResult HacerAlgoSinRespuesta() => new EmptyResult();
        [ChildActionOnly]
        public ActionResult Total()
        {
            var Context = new SaludMovilEntities();
            var Result = string.Format($"<strong>{Context.sm_Programa.Count()} productos </strong>");
            return Content(Result);
        }

        public ActionResult GetProgramaByName(string name)
        {
            ActionResult Result;

            var Context = new SaludMovilEntities();
            var Programa = Context.sm_Programa.FirstOrDefault(p => p.descripcion.Contains(name));
            if (Programa != null)
            {
                Result = View("Details",Programa);
            }
            else
            {
                Result = HttpNotFound($"Producto {name} no encontrado");
            }
            return Result;
        }
    }
}