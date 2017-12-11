using Data.Models;
using Newtonsoft.Json;
using Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ged.Controllers
{
    public class AnomalyController : Controller
    {

        AnomalyService aas = new AnomalyService();
        // GET: Anomaly
  
        public ActionResult Index()
        {
            
            document d=new document();
            
            if (Session["document"]!=null)
            {
                 d = Session["document"] as document;
                ViewBag.document = d.Titre1;
                
            }
            return View(aas.GetAll().Where(e=>e.DocId==d.Id));
        }

        // GET: Anomaly/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Anomaly/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Anomaly/Create
        [HttpPost]
        public ActionResult Create(Anomaly a)
        {
            document d;
            List<Anomaly> lc = Session["AnomalySession"] as List<Anomaly>;
            if (Session["document"] != null)
            {
                d = Session["document"] as document;
                a.DocId = d.Id;
            }
            if (lc == null)
            {
                lc = new List<Anomaly>();

            }

            lc.Add(a);
            Session["ClientSession"] = lc;
            aas.Add(a);
            aas.Commit();
            // TODO: Add insert logic here

            return RedirectToAction("Index");
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Anomaly/Edit/5
        public ActionResult Edit(int id)
        {
            return View(aas.Get(e=>e.AnomalyID==id));
        }

        // POST: Anomaly/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Anomaly a1)
        {
          
                // TODO: Add update logic here

                Anomaly a2 = new Anomaly();
                a2 = aas.GetById(id);
                a2.TitleAnomaly = a1.TitleAnomaly;
                a2.DescAnomaly = a1.DescAnomaly;
                a2.DocId = a1.DocId;
                aas.Update(a2);
                aas.Commit();

                return RedirectToAction("Index");

            //try
            //{
                //    return RedirectToAction("Index");
                //}
                //catch
                //{
                //    return View();
                //}
            }

        // GET: Anomaly/Delete/5
        public ActionResult Delete(int id)
        {
            Anomaly a = aas.GetById(id);
            return View(a);
        }

        // POST: Anomaly/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Anomaly a)
        {
            a = aas.GetById(id);
            aas.Delete(a);
            aas.Commit();

            return RedirectToAction("Index");


            //try
            //{
            //    // TODO: Add delete logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }
        public ActionResult GoToDocument()
        {
            return RedirectToAction("Index", "Document");
        }
    }
}
