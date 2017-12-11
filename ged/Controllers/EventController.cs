using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ged.Controllers
{
    public class EventController : Controller
    {
        EventService eventservice = new EventService();
        UserService us = new UserService();

        // GET: Event
        public ActionResult Index()
        {
            user u = new user();
            u.cin = "09192735";
            if (Session["Evenement"] != null)
            {
                u = Session["Evenement"] as user;
               

            }
             return View(eventservice.GetAll().Where(e => e.cin.Equals(u.cin)));

        }

        public ActionResult googleMap(int id)
        {
            Event e=eventservice.GetById(id);

            String result = "";
            String place = e.EventPlace;
            result += place.Replace(" ", "+");
            String Url = "https://www.google.com/maps/embed/v1/place?key=" + "AIzaSyDNRB0z7ot6ziI_r3so0iegfpsqLAc9ciA" + "&q=" + place;
            ViewBag.Maps = Url;

            return View();
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            Event e = eventservice.GetById(id);
            return View(e);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(Event e, HttpPostedFileBase Imag)
        {
            try
            {
                

                String imgname = "";

                int x =Imag.FileName.LastIndexOf("\\");
                imgname = Imag.FileName.Substring(x+1);
                e.EventAffiche = imgname;
                Imag.SaveAs(Path.Combine(Server.MapPath("~/Content/"), imgname));
                e.cin = "09192735";
                eventservice.Add(e);
                eventservice.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View(eventservice.Get(e=>e.EventId==id));
        }

        // POST: Event/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Event e, HttpPostedFileBase Imag)
        {
            try
            {
                String imgname = "";

                int x = Imag.FileName.LastIndexOf("\\");
                imgname = Imag.FileName.Substring(x + 1);
                e.EventAffiche = imgname;
                Imag.SaveAs(Path.Combine(Server.MapPath("~/Content/"), imgname));

                Event e1 = new Event();
                e1 = eventservice.GetById(id);
                e1.EventTitle = e.EventTitle;
                e1.EventPlace = e.EventPlace;
                e1.EventDate = e.EventDate;
                e1.EventAffiche = e.EventAffiche;
                eventservice.Update(e1);
                eventservice.Commit();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            Event e = eventservice.GetById(id);
            return View(e);
        }

        // POST: Event/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Event e)
        {
            try
            {

                // TODO: Add delete logic here
                e = eventservice.GetById(id);
                eventservice.Delete(e);
                eventservice.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
