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
    public class AccountCodesController : Controller
    {
        private RomeDBEntities db = new RomeDBEntities();

        //
        // GET: /AccountCodes/

        public ActionResult Index()
        {
            var accountcodes = db.AccountCodes.Include(a => a.ClusterAccount);
            return View(accountcodes.ToList());
        }

        //
        // GET: /AccountCodes/Details/5

        public ActionResult Details(int id = 0)
        {
            AccountCode accountcode = db.AccountCodes.Find(id);
            if (accountcode == null)
            {
                return HttpNotFound();
            }
            return View(accountcode);
        }

        //
        // GET: /AccountCodes/Create

        public ActionResult Create()
        {
            ViewBag.clusterAcct = new SelectList(db.ClusterAccounts, "clusterAcct", "description");
            return View();
        }

        //
        // POST: /AccountCodes/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AccountCode accountcode)
        {
            if (ModelState.IsValid)
            {
                db.AccountCodes.Add(accountcode);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.clusterAcct = new SelectList(db.ClusterAccounts, "clusterAcct", "description", accountcode.clusterAcct);
            return View(accountcode);
        }

        //
        // GET: /AccountCodes/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AccountCode accountcode = db.AccountCodes.Find(id);
            if (accountcode == null)
            {
                return HttpNotFound();
            }
            ViewBag.clusterAcct = new SelectList(db.ClusterAccounts, "clusterAcct", "description", accountcode.clusterAcct);
            return View(accountcode);
        }

        //
        // POST: /AccountCodes/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AccountCode accountcode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountcode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.clusterAcct = new SelectList(db.ClusterAccounts, "clusterAcct", "description", accountcode.clusterAcct);
            return View(accountcode);
        }

        //
        // GET: /AccountCodes/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AccountCode accountcode = db.AccountCodes.Find(id);
            if (accountcode == null)
            {
                return HttpNotFound();
            }
            return View(accountcode);
        }

        //
        // POST: /AccountCodes/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountCode accountcode = db.AccountCodes.Find(id);
            db.AccountCodes.Remove(accountcode);
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