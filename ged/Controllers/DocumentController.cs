using Data.Models;
using Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ged.Controllers
{
    public class DocumentController : Controller
    {
        DocumentService ds = new DocumentService();
        AnomalyService aas = new AnomalyService();
        // GET: Document
        public ActionResult Index()
        {
            return View(ds.GetAll());
        }

        // GET: Document/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Document/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Document/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Document/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Document/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Document/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Document/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult GoToAnomaly(int id)
        {
            int count=0;
            count=aas.GetAll().Where(e => e.DocId == id).Count();
            document d = ds.Get(e => e.Id == id);
            TempData["document"] = d;
            Session["document"] = d;
            if (count!=0)
            {
                return RedirectToAction("Index", "Anomaly");
            }
            else
            {
                return RedirectToAction("noAn", "Document");
            }

        }
        public ActionResult noAn()
        {
            document dd = Session["document"] as document;
            return View(dd);
        }
        public ActionResult GoToAdd(int id)
        {

            document d = ds.Get(e => e.Id == id);
            TempData["document"] = d;
            Session["document"] = d;
            return RedirectToAction("Create", "Anomaly");
        }
        public  ActionResult Stat()
        {
            List<int> repartitions = new List<int>();
             var all = ds.GetAll();
            var types = all.Select(e => e.Type).Distinct();
            foreach (var item in types)
            {
                repartitions.Add(all.Count(x => x.Type.Equals(item)));

            }
            var rep = repartitions;
            ViewBag.TYPES = types;
            ViewBag.REP = repartitions.ToList();
            return View();
        }
    }
}
