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
    public class TaxAuthorityController : Controller
    {
        private RomeDBEntities db = new RomeDBEntities();

        //
        // GET: /TaxAuthority/

        public ActionResult Index()
        {
            var taxauthorities = db.TaxAuthorities.Include(t => t.AccountCode);
            return View(taxauthorities.ToList());
        }

        //
        // GET: /TaxAuthority/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    TaxAuthority taxauthority = db.TaxAuthorities.Find(id);
        //    if (taxauthority == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(taxauthority);
        //}

        ////
        //// GET: /TaxAuthority/Create

        public ActionResult Create()
        {
            ViewBag.Account = new SelectList(db.AccountCodes, "acctCode", "acctCode");
            return View();
        }

        //
        // POST: /TaxAuthority/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaxAuthority taxauthority)
        {
            if (ModelState.IsValid)
            {
                TaxAuthority model = new TaxAuthority()
                {
                    ID = taxauthority.ID,
                    Name = taxauthority.Name,
                    ShortName = taxauthority.ShortName,
                    Account = taxauthority.Account,
                    TR1Minimum = (taxauthority.TR1Minimum == null) ? 0.00 : taxauthority.TR1Minimum,
                    TR1Maximum = (taxauthority.TR1Maximum == null) ? 0.00 : taxauthority.TR1Maximum,
                    TR1FlatTaxFee = (taxauthority.TR1FlatTaxFee == null) ? 0.00 : taxauthority.TR1FlatTaxFee,
                    TR1TaxRate = (taxauthority.TR1TaxRate == null) ? 0.00 : taxauthority.TR1TaxRate,
                    TR1ApplyFeeRate = taxauthority.TR1ApplyFeeRate,

                    TR2Minimum = (taxauthority.TR2Minimum == null) ? 0.00 : taxauthority.TR2Minimum,
                    TR2Maximum = (taxauthority.TR2Maximum == null) ? 0.00 : taxauthority.TR2Maximum,
                    TR2FlatTaxFee = (taxauthority.TR2FlatTaxFee == null) ? 0.00 : taxauthority.TR2FlatTaxFee,
                    TR2TaxRate = (taxauthority.TR2TaxRate == null) ? 0.00 : taxauthority.TR2TaxRate,
                    TR2ApplyFeeRate = taxauthority.TR2ApplyFeeRate,

                    TR3Minimum = (taxauthority.TR3Minimum == null) ? 0.00 : taxauthority.TR3Minimum,
                    TR3Maximum = (taxauthority.TR3Maximum == null) ? 0.00 : taxauthority.TR3Maximum,
                    TR3FlatTaxFee = (taxauthority.TR3FlatTaxFee == null) ? 0.00 : taxauthority.TR3FlatTaxFee,
                    TR3TaxRate = (taxauthority.TR3TaxRate == null) ? 0.00 : taxauthority.TR3TaxRate,
                    TR3ApplyFeeRate = taxauthority.TR3ApplyFeeRate,

                    TR4Minimum = (taxauthority.TR4Minimum == null) ? 0.00 : taxauthority.TR4Minimum,
                    TR4Maximum = (taxauthority.TR4Maximum == null) ? 0.00 : taxauthority.TR4Maximum,
                    TR4FlatTaxFee = (taxauthority.TR4FlatTaxFee == null) ? 0.00 : taxauthority.TR4FlatTaxFee,
                    TR4TaxRate = (taxauthority.TR4TaxRate == null) ? 0.00 : taxauthority.TR4TaxRate,
                    TR4ApplyFeeRate = taxauthority.TR4ApplyFeeRate,

                    TR5Minimum = (taxauthority.TR5Minimum == null) ? 0.00 : taxauthority.TR5Minimum,
                    TR5Maximum = (taxauthority.TR5Maximum == null) ? 0.00 : taxauthority.TR5Maximum,
                    TR5FlatTaxFee = (taxauthority.TR5FlatTaxFee == null) ? 0.00 : taxauthority.TR5FlatTaxFee,
                    TR5TaxRate = (taxauthority.TR5TaxRate == null) ? 0.00 : taxauthority.TR5TaxRate,
                    TR5ApplyFeeRate = taxauthority.TR5ApplyFeeRate,

                };
                db.TaxAuthorities.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Account = new SelectList(db.AccountCodes, "acctCode", "acctCode", taxauthority.Account);
            return View(taxauthority);
        }

        //
        // GET: /TaxAuthority/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TaxAuthority taxauthority = db.TaxAuthorities.Find(id);
            if (taxauthority == null)
            {
                return View();
            }
            ViewBag.Account = new SelectList(db.AccountCodes, "acctCode", "acctCode", taxauthority.Account);
            return View(taxauthority);
        }

        //
        // POST: /TaxAuthority/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TaxAuthority taxauthority)
        {
            if (ModelState.IsValid)
            {
                TaxAuthority model = new TaxAuthority()
                {
                    ID = taxauthority.ID,
                    Name = taxauthority.Name,
                    ShortName = taxauthority.ShortName,
                    Account = taxauthority.Account,
                    TR1Minimum = (taxauthority.TR1Minimum == null) ? 0.00 : taxauthority.TR1Minimum,
                    TR1Maximum = (taxauthority.TR1Maximum == null) ? 0.00 : taxauthority.TR1Maximum,
                    TR1FlatTaxFee = (taxauthority.TR1FlatTaxFee == null) ? 0.00 : taxauthority.TR1FlatTaxFee,
                    TR1TaxRate = (taxauthority.TR1TaxRate == null) ? 0.00 : taxauthority.TR1TaxRate,
                    TR1ApplyFeeRate = taxauthority.TR1ApplyFeeRate,

                    TR2Minimum = (taxauthority.TR2Minimum == null) ? 0.00 : taxauthority.TR2Minimum,
                    TR2Maximum = (taxauthority.TR2Maximum == null) ? 0.00 : taxauthority.TR2Maximum,
                    TR2FlatTaxFee = (taxauthority.TR2FlatTaxFee == null) ? 0.00 : taxauthority.TR2FlatTaxFee,
                    TR2TaxRate = (taxauthority.TR2TaxRate == null) ? 0.00 : taxauthority.TR2TaxRate,
                    TR2ApplyFeeRate = taxauthority.TR2ApplyFeeRate,

                    TR3Minimum = (taxauthority.TR3Minimum == null) ? 0.00 : taxauthority.TR3Minimum,
                    TR3Maximum = (taxauthority.TR3Maximum == null) ? 0.00 : taxauthority.TR3Maximum,
                    TR3FlatTaxFee = (taxauthority.TR3FlatTaxFee == null) ? 0.00 : taxauthority.TR3FlatTaxFee,
                    TR3TaxRate = (taxauthority.TR3TaxRate == null) ? 0.00 : taxauthority.TR3TaxRate,
                    TR3ApplyFeeRate = taxauthority.TR3ApplyFeeRate,

                    TR4Minimum = (taxauthority.TR4Minimum == null) ? 0.00 : taxauthority.TR4Minimum,
                    TR4Maximum = (taxauthority.TR4Maximum == null) ? 0.00 : taxauthority.TR4Maximum,
                    TR4FlatTaxFee = (taxauthority.TR4FlatTaxFee == null) ? 0.00 : taxauthority.TR4FlatTaxFee,
                    TR4TaxRate = (taxauthority.TR4TaxRate == null) ? 0.00 : taxauthority.TR4TaxRate,
                    TR4ApplyFeeRate = taxauthority.TR4ApplyFeeRate,

                    TR5Minimum = (taxauthority.TR5Minimum == null) ? 0.00 : taxauthority.TR5Minimum,
                    TR5Maximum = (taxauthority.TR5Maximum == null) ? 0.00 : taxauthority.TR5Maximum,
                    TR5FlatTaxFee = (taxauthority.TR5FlatTaxFee == null) ? 0.00 : taxauthority.TR5FlatTaxFee,
                    TR5TaxRate = (taxauthority.TR5TaxRate == null) ? 0.00 : taxauthority.TR5TaxRate,
                    TR5ApplyFeeRate = taxauthority.TR5ApplyFeeRate,

                };
                
                    db.TaxAuthorities.Add(model);
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
            }
            ViewBag.Account = new SelectList(db.AccountCodes, "acctCode", "acctCode", taxauthority.Account);
            return View(taxauthority);
        }

        //
        // GET: /TaxAuthority/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TaxAuthority taxauthority = db.TaxAuthorities.Find(id);
            db.TaxAuthorities.Remove(taxauthority);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        //
        // POST: /TaxAuthority/Delete/5

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    TaxAuthority taxauthority = db.TaxAuthorities.Find(id);
        //    db.TaxAuthorities.Remove(taxauthority);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}