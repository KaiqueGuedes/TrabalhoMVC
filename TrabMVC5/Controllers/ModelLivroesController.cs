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
    public class ModelLivroesController : Controller
    {
        private ModelContexto db = new ModelContexto();

        // GET: ModelLivroes
        public ActionResult Index()
        {
            return View(db.livro.ToList());
        }

        // GET: ModelLivroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelLivro modelLivro = db.livro.Find(id);
            if (modelLivro == null)
            {
                return HttpNotFound();
            }
            return View(modelLivro);
        }

        // GET: ModelLivroes/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelLivroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "idLivro,autor,descri,editora,genero,livro,qtd")] ModelLivro modelLivro)
        {
            if (ModelState.IsValid)
            {
                db.livro.Add(modelLivro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelLivro);
        }

        // GET: ModelLivroes/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelLivro modelLivro = db.livro.Find(id);
            if (modelLivro == null)
            {
                return HttpNotFound();
            }
            return View(modelLivro);
        }

        // POST: ModelLivroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "idLivro,autor,descri,editora,genero,livro,qtd")] ModelLivro modelLivro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelLivro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelLivro);
        }

        // GET: ModelLivroes/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelLivro modelLivro = db.livro.Find(id);
            if (modelLivro == null)
            {
                return HttpNotFound();
            }
            return View(modelLivro);
        }

        // POST: ModelLivroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelLivro modelLivro = db.livro.Find(id);
            db.livro.Remove(modelLivro);
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
