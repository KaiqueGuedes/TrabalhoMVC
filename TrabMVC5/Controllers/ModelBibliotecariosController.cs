using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TMVC5.Models;

namespace TrabMVC5.Controllers
{
    public class ModelBibliotecariosController : Controller
    {
        private ModelContexto db = new ModelContexto();

        // GET: ModelBibliotecarios
        public ActionResult Index()
        {
            return View(db.bibliotecario.ToList());
        }

        // GET: ModelBibliotecarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelBibliotecario modelBibliotecario = db.bibliotecario.Find(id);
            if (modelBibliotecario == null)
            {
                return HttpNotFound();
            }
            return View(modelBibliotecario);
        }

        // GET: ModelBibliotecarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelBibliotecarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idBibliotecario,nome,usuario,senha")] ModelBibliotecario modelBibliotecario)
        {
            if (ModelState.IsValid)
            {
                db.bibliotecario.Add(modelBibliotecario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelBibliotecario);
        }

        // GET: ModelBibliotecarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelBibliotecario modelBibliotecario = db.bibliotecario.Find(id);
            if (modelBibliotecario == null)
            {
                return HttpNotFound();
            }
            return View(modelBibliotecario);
        }

        // POST: ModelBibliotecarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idBibliotecario,nome,usuario,senha")] ModelBibliotecario modelBibliotecario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelBibliotecario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelBibliotecario);
        }

        // GET: ModelBibliotecarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelBibliotecario modelBibliotecario = db.bibliotecario.Find(id);
            if (modelBibliotecario == null)
            {
                return HttpNotFound();
            }
            return View(modelBibliotecario);
        }

        // POST: ModelBibliotecarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelBibliotecario modelBibliotecario = db.bibliotecario.Find(id);
            db.bibliotecario.Remove(modelBibliotecario);
            db.SaveChanges();
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
