using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;

namespace NorthWind.Controllers
{
    public class PersonaController : Controller
    {
        private SaludMovilEntities db = new SaludMovilEntities();

        // GET: Persona
        public async Task<ActionResult> Index()
        {
            var sm_Persona = db.sm_Persona.Include(s => s.sm_Paciente).Include(s => s.sm_Paciente1).Include(s => s.sm_PacientePrograma);
            return View(await sm_Persona.ToListAsync());
        }

        // GET: Persona/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sm_Persona sm_Persona = await db.sm_Persona.FindAsync(id);
            if (sm_Persona == null)
            {
                return HttpNotFound();
            }
            return View(sm_Persona);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_Paciente, "idTipoIdentificacion", "segmento");
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_Paciente, "idTipoIdentificacion", "segmento");
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_PacientePrograma, "idTipoIdentificacion", "observaciones");
            return View();
        }

        // POST: Persona/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idTipoIdentificacion,numeroIdentificacion,primerNombre,segundoNombre,primerApellido,segundoApellido,idTipo,fechaNacimiento,idCiudad,celular,telefonoFijo,correo,createdDate,createdBy,updatedDate,updatedBy")] sm_Persona sm_Persona)
        {
            if (ModelState.IsValid)
            {
                db.sm_Persona.Add(sm_Persona);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idTipoIdentificacion = new SelectList(db.sm_Paciente, "idTipoIdentificacion", "segmento", sm_Persona.idTipoIdentificacion);
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_Paciente, "idTipoIdentificacion", "segmento", sm_Persona.idTipoIdentificacion);
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_PacientePrograma, "idTipoIdentificacion", "observaciones", sm_Persona.idTipoIdentificacion);
            return View(sm_Persona);
        }

        // GET: Persona/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sm_Persona sm_Persona = await db.sm_Persona.FindAsync(id);
            if (sm_Persona == null)
            {
                return HttpNotFound();
            }
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_Paciente, "idTipoIdentificacion", "segmento", sm_Persona.idTipoIdentificacion);
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_Paciente, "idTipoIdentificacion", "segmento", sm_Persona.idTipoIdentificacion);
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_PacientePrograma, "idTipoIdentificacion", "observaciones", sm_Persona.idTipoIdentificacion);
            return View(sm_Persona);
        }

        // POST: Persona/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idTipoIdentificacion,numeroIdentificacion,primerNombre,segundoNombre,primerApellido,segundoApellido,idTipo,fechaNacimiento,idCiudad,celular,telefonoFijo,correo,createdDate,createdBy,updatedDate,updatedBy")] sm_Persona sm_Persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sm_Persona).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_Paciente, "idTipoIdentificacion", "segmento", sm_Persona.idTipoIdentificacion);
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_Paciente, "idTipoIdentificacion", "segmento", sm_Persona.idTipoIdentificacion);
            ViewBag.idTipoIdentificacion = new SelectList(db.sm_PacientePrograma, "idTipoIdentificacion", "observaciones", sm_Persona.idTipoIdentificacion);
            return View(sm_Persona);
        }

        // GET: Persona/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sm_Persona sm_Persona = await db.sm_Persona.FindAsync(id);
            if (sm_Persona == null)
            {
                return HttpNotFound();
            }
            return View(sm_Persona);
        }

        // POST: Persona/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            sm_Persona sm_Persona = await db.sm_Persona.FindAsync(id);
            db.sm_Persona.Remove(sm_Persona);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
