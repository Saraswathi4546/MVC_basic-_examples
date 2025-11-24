using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using mvc_examples.Models;

namespace mvc_examples.Controllers
{
    public class AnnotationsController : Controller
    {

        //=============================Data Annotations Example-12 =========================

        public ActionResult validations()
        {
            return View();
        }
     
        // GET: Annotations

        public ActionResult Index()
        {
            return View();
        }

        //get method to display movie form
        public ActionResult movie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult movie(movie mve)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
//=============================== Example- 13 ============================

            //get method 
        public ActionResult exmp()
        {
            return View();
        }

        [HttpPost]     //post method 
        public ActionResult exmp(modelcls obj)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("index");
            }
            return View();
        }
        public ActionResult dis()
        {
            return View();
        }

        //========================= Example -14 ============== Layout Page ===================


        public ActionResult exmp14()
        {
            return View();
        }
        public ActionResult layout()
        {
            return View();
        }

//============= Example -15 ==============  ( Partial Page / View )================

 
        public ActionResult exmp15()
        {
            return View();
        }



    }
}