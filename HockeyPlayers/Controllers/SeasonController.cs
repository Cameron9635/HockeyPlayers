﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HockeyPlayers.DAL;
using HockeyPlayers.Models;

namespace HockeyPlayers.Controllers
{
    public class SeasonController : Controller
    {
        private HockeyContext db = new HockeyContext();

        // GET: Season
        public ActionResult Index()
        {
            return View(db.Seasons.ToList());
        }

        // GET: Season/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season season = db.Seasons.Find(id);
            if (season == null)
            {
                return HttpNotFound();
            }
            return View(season);
        }

        // GET: Season/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Season/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SeasonID,StartDate,EndDate,Champion")] Season season)
        {
            if (ModelState.IsValid)
            {
                db.Seasons.Add(season);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(season);
        }

        // GET: Season/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season season = db.Seasons.Find(id);
            if (season == null)
            {
                return HttpNotFound();
            }
            return View(season);
        }

        // POST: Season/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SeasonID,StartDate,EndDate,Champion")] Season season)
        {
            if (ModelState.IsValid)
            {
                db.Entry(season).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(season);
        }

        // GET: Season/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Season season = db.Seasons.Find(id);
            if (season == null)
            {
                return HttpNotFound();
            }
            return View(season);
        }

        // POST: Season/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Season season = db.Seasons.Find(id);
                db.Seasons.Remove(season);
                db.SaveChanges();
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
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
