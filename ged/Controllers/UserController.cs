using Data.Models;
<<<<<<< HEAD
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
=======
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
>>>>>>> 2440b7b0c49bed0929fe97c937a840dc48039fe8

namespace ged.Controllers
{
    public class UserController : Controller
    {
<<<<<<< HEAD
        UserService us = new UserService();
        // GET: User
        public ActionResult Index()
        {
            return View(us.GetAll());
        }
        public ActionResult GoToEvents(String cin)
        {
            user u = us.Get(e => e.cin.Equals(cin));
            Session["Evenement"] = u ;


            return RedirectToAction("Index","Event");
=======

        public List<user> getAllUsers()
        {
            string url = "http://localhost:18080/ged-web/rest/classPath";
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(url);
            getRequest.Method = "GET";
            getRequest.Credentials = new NetworkCredential("UN", "PW");
            ServicePointManager.ServerCertificateValidationCallback = new
               RemoteCertificateValidationCallback
               (
                  delegate { return true; }
               );

            var getResponse = (HttpWebResponse)getRequest.GetResponse();
            Stream newStream = getResponse.GetResponseStream();
            StreamReader sr = new StreamReader(newStream);
            var result = sr.ReadToEnd();
            var splashInfo = JsonConvert.DeserializeObject(result);
            string json = splashInfo.ToString();


            JavaScriptSerializer js = new JavaScriptSerializer();
            List<user> users = js.Deserialize<List<user>>(json);
            return users;
        }


        // GET: User
        public ActionResult Index()
        {
            return View();
>>>>>>> 2440b7b0c49bed0929fe97c937a840dc48039fe8
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
<<<<<<< HEAD
        public ActionResult Create()
=======
        public ActionResult Login()
>>>>>>> 2440b7b0c49bed0929fe97c937a840dc48039fe8
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
<<<<<<< HEAD
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
=======
        public ActionResult Login(user u)
        {
            bool test =false;
            List<user> users = getAllUsers();
            foreach (var item in users)
            {
                if (item.login.Equals(u.login) && item.password.Equals(u.password))
                {
                    test = true;
                }

            }
            if (test==true)
            {
                return RedirectToAction("Index", "Document");

            }
            return RedirectToAction("noLog", "User");
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
>>>>>>> 2440b7b0c49bed0929fe97c937a840dc48039fe8
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
<<<<<<< HEAD
=======
        public ActionResult noLog()
        {
            return View();
        }
>>>>>>> 2440b7b0c49bed0929fe97c937a840dc48039fe8
    }
}
