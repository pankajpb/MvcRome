using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRome.Models;

namespace MvcRome.Controllers
{
    public class ClusterAccountController : Controller
    {
        private RomeDBEntities db = new RomeDBEntities();

        //
        // GET: /ClusterAccount/

        public ActionResult Index()
        {
            return View(db.ClusterAccounts.ToList());
        }

        //
        // GET: /ClusterAccount/Details/5

        public ActionResult Details(string id = null)
        {
            ClusterAccount clusteraccount = db.ClusterAccounts.Find(id);
            if (clusteraccount == null)
            {
                return HttpNotFound();
            }
            return View(clusteraccount);
        }

        //
        // GET: /ClusterAccount/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ClusterAccount/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClusterAccount clusteraccount)
        {
            if (ModelState.IsValid)
            {
                db.ClusterAccounts.Add(clusteraccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clusteraccount);
        }

        //
        // GET: /ClusterAccount/Edit/5

        public ActionResult Edit(string id = null)
        {
            ClusterAccount clusteraccount = db.ClusterAccounts.Find(id);
            if (clusteraccount == null)
            {
                return HttpNotFound();
            }
            return View(clusteraccount);
        }

        //
        // POST: /ClusterAccount/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClusterAccount clusteraccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clusteraccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clusteraccount);
        }

        //
        // GET: /ClusterAccount/Delete/5

        public ActionResult Delete(string id = null)
        {
            ClusterAccount clusteraccount = db.ClusterAccounts.Find(id);
            if (clusteraccount == null)
            {
                return HttpNotFound();
            }
            return View(clusteraccount);
        }

        //
        // POST: /ClusterAccount/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ClusterAccount clusteraccount = db.ClusterAccounts.Find(id);
            db.ClusterAccounts.Remove(clusteraccount);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}