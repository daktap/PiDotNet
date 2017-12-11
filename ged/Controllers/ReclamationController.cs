using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ged.Controllers
{
    public class ReclamationController : Controller
    {
        ReclamationService rs = new ReclamationService();
        // GET: Reclamation
        public ActionResult Index()
        {
           
            return View(rs.afficher());
        }

        // GET: Reclamation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reclamation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reclamation/Create
        [HttpPost]
        public ActionResult Create(reclamation r,FormCollection form)
        {
            // TODO: Add insert logic here
                r.subject = form["subject"];
                r.message = form["message"];
                r.type = form["type"];
               
                rs.addRec(r.subject, r.message, r.type);
                return RedirectToAction("Index");
            
             return View();
            
        }

        // GET: Reclamation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reclamation/Edit/5
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

        // GET: Reclamation/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(rs.Get(e => e.id == id));
        }

        // POST: Reclamation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, reclamation r)
        {
            try
            {
                // TODO: Add delete logic here
                rs.deleteRec(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
