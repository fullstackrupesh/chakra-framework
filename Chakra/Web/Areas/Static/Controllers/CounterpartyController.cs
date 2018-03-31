using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Chakra.Web.Areas.Static.Models;
using Web.Models;

namespace Chakra.Web.Areas.Static.Controllers
{
    public class CounterpartyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Static/Counterparty
        public async Task<ActionResult> Index()
        {
            return View(await db.Counterparties.ToListAsync());
        }

        // GET: Static/Counterparty/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counterparty counterparty = await db.Counterparties.FindAsync(id);
            if (counterparty == null)
            {
                return HttpNotFound();
            }
            return View(counterparty);
        }

        // GET: Static/Counterparty/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Static/Counterparty/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,ShortCode,ClearingCode,CPartyAddress")] Counterparty counterparty)
        {
            if (ModelState.IsValid)
            {
                db.Counterparties.Add(counterparty);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(counterparty);
        }

        // GET: Static/Counterparty/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counterparty counterparty = await db.Counterparties.FindAsync(id);
            if (counterparty == null)
            {
                return HttpNotFound();
            }
            return View(counterparty);
        }

        // POST: Static/Counterparty/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,ShortCode,ClearingCode,CPartyAddress")] Counterparty counterparty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(counterparty).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(counterparty);
        }

        // GET: Static/Counterparty/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counterparty counterparty = await db.Counterparties.FindAsync(id);
            if (counterparty == null)
            {
                return HttpNotFound();
            }
            return View(counterparty);
        }

        // POST: Static/Counterparty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Counterparty counterparty = await db.Counterparties.FindAsync(id);
            db.Counterparties.Remove(counterparty);
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
