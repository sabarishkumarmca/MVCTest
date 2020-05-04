using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SabariTest.Models;

namespace SabariTest.Controllers
{
    public class ExceptionLoggersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: ExceptionLoggers
        public async Task<ActionResult> Index()
        {
            return View(await db.ExceptionLoggers.ToListAsync());
        }

        public PartialViewResult IndexView()
        {
            return PartialView("_IndexView", db.ExceptionLoggers.ToList());
        }
        // GET: ExceptionLoggers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExceptionLogger exceptionLogger = await db.ExceptionLoggers.FindAsync(id);
            if (exceptionLogger == null)
            {
                return HttpNotFound();
            }
            return View(exceptionLogger);
        }

        // GET: ExceptionLoggers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExceptionLoggers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,ExceptionMessage,ControllName,ExceptionStackTrace,LogTime")] ExceptionLogger exceptionLogger)
        {
            if (ModelState.IsValid)
            {
                db.ExceptionLoggers.Add(exceptionLogger);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(exceptionLogger);
        }

        // GET: ExceptionLoggers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExceptionLogger exceptionLogger = await db.ExceptionLoggers.FindAsync(id);
            if (exceptionLogger == null)
            {
                return HttpNotFound();
            }
            return View(exceptionLogger);
        }

        // POST: ExceptionLoggers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,ExceptionMessage,ControllName,ExceptionStackTrace,LogTime")] ExceptionLogger exceptionLogger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exceptionLogger).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(exceptionLogger);
        }

        // GET: ExceptionLoggers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExceptionLogger exceptionLogger = await db.ExceptionLoggers.FindAsync(id);
            if (exceptionLogger == null)
            {
                return HttpNotFound();
            }
            return View(exceptionLogger);
        }

        // POST: ExceptionLoggers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ExceptionLogger exceptionLogger = await db.ExceptionLoggers.FindAsync(id);
            db.ExceptionLoggers.Remove(exceptionLogger);
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
