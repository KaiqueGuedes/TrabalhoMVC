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
    public class ModelEmprestimoesController : Controller
    {
        private ModelContexto db = new ModelContexto();

        // GET: ModelEmprestimoes
        public ActionResult Index()
        {
            return View(db.emprestimo.ToList());
        }

        // GET: ModelEmprestimoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelEmprestimo modelEmprestimo = db.emprestimo.Find(id);
            if (modelEmprestimo == null)
            {
                return HttpNotFound();
            }
            return View(modelEmprestimo);
        }

        // GET: ModelEmprestimoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelEmprestimoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmprestimo,RA,livro_id,qtd,data_emp,data_devol")] ModelEmprestimo modelEmprestimo)
        {
            if (ModelState.IsValid)
            {
                db.emprestimo.Add(modelEmprestimo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelEmprestimo);
        }

        // GET: ModelEmprestimoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelEmprestimo modelEmprestimo = db.emprestimo.Find(id);
            if (modelEmprestimo == null)
            {
                return HttpNotFound();
            }
            return View(modelEmprestimo);
        }

        // POST: ModelEmprestimoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEmprestimo,RA,livro_id,qtd,data_emp,data_devol")] ModelEmprestimo modelEmprestimo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelEmprestimo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelEmprestimo);
        }

        // GET: ModelEmprestimoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelEmprestimo modelEmprestimo = db.emprestimo.Find(id);
            if (modelEmprestimo == null)
            {
                return HttpNotFound();
            }
            return View(modelEmprestimo);
        }

        // POST: ModelEmprestimoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelEmprestimo modelEmprestimo = db.emprestimo.Find(id);
            db.emprestimo.Remove(modelEmprestimo);
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
