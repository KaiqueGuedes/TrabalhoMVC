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
    public class ModelAlunoesController : Controller
    {
        private ModelContexto db = new ModelContexto();

        // GET: ModelAlunoes
        public ActionResult Index()
        {
            return View(db.aluno.ToList());
        }

        // GET: ModelAlunoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelAluno modelAluno = db.aluno.Find(id);
            if (modelAluno == null)
            {
                return HttpNotFound();
            }
            return View(modelAluno);
        }

        // GET: ModelAlunoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelAlunoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAluno,RA,nome,senha")] ModelAluno modelAluno)
        {
            if (ModelState.IsValid)
            {
                db.aluno.Add(modelAluno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelAluno);
        }

        // GET: ModelAlunoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelAluno modelAluno = db.aluno.Find(id);
            if (modelAluno == null)
            {
                return HttpNotFound();
            }
            return View(modelAluno);
        }

        // POST: ModelAlunoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAluno,RA,nome,senha")] ModelAluno modelAluno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelAluno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelAluno);
        }

        // GET: ModelAlunoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelAluno modelAluno = db.aluno.Find(id);
            if (modelAluno == null)
            {
                return HttpNotFound();
            }
            return View(modelAluno);
        }

        // POST: ModelAlunoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelAluno modelAluno = db.aluno.Find(id);
            db.aluno.Remove(modelAluno);
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
