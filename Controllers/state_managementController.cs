using mvc_examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_examples.Models;

namespace mvc_examples.Controllers
{
    public class state_managementController : Controller
    {
        // GET: state_management

//==================== ecample -6 ============== creating different routes=============================

        public ActionResult routers(int id)  // create view 
        {
            return View(id);  //default root config.cs file (in the url /20 we have to give then only it consider the id value )
        }

        public ActionResult routing2(int b)  //creating view 
        {
            return View(b);// b is not default parameter  (in url "{control_name}/{action}/{b}")
        }
//============================ example- 7 ==========================================

        //======================= creating model class ============================
         public ActionResult studentdetails() // create view and write logic
        {
            List<student> sobj = new List<student>(); //using collection generic class to access multiple value
            {
                student obj1 = new student() { sid = 1001, sname = "Anusha", marks = 56 };
                student obj2 = new student() { sid = 1002, sname = "priya", marks = 89 };
                student obj3 = new student() { sid = 1003, sname = "mohini", marks = 79 };
                sobj.Add(obj1);
                sobj.Add(obj2);  //using predefine methods we are adding the values from the student object class 
                sobj.Add(obj3);    

                return View(sobj);  // returning the object of list class  to view 

            }
        }

    //==================================== statemanagement -===========================

        public ActionResult  show()
        {
            return View();
        }
        //=========================== View Bag ============================
        public ActionResult view_bag()//method name can be any user defined name 
        {
            ViewBag.msg = "WelCome Anusha"; //pass the data b/w controller to view 
            return View();
        }

        //================= View Data =================================

        public ActionResult view_data()  //pass the data b/w controller and view ==>create view for this method
        {
            ViewData["msg"] = "Good Afternoon Everyone";
            return View();
        }

        //====================== Temp Data ===============================

        public ActionResult temp()  //method_1  the data maintained when page is redirect to another page 
        {
            TempData["name"] = "Anusha";
            TempData.Keep("name");
            return View();
        }

        public ActionResult temp2()  //method_2 the data is carring from method_1 
        {
            string s;
            if(TempData.ContainsKey("name"))
                s = TempData["name"].ToString();
            return View();
        }

        //================== @HTML Helpers ================== example -8 ========================

        //======================= creating standard View ============== registation form==========================

        public ActionResult htmlhelpers()
        {
            return View();
        }
        
        public ActionResult create() // create view and write htmlhelper code in view 
        {
            return View();
        }

//=================== example-9 ================== reg_form -2 =======================================

       
        
    public ActionResult Display() // create view for display method and write html code using html helper
       {
           return View();
       }
//======================================================================================
//====================== Strongly Typed View =======================================

//-------------------------------- example -10 ----------------- college ------------------

       public ActionResult index() // create view 
        {
            return View();
        }
        
        public ActionResult department() // method _1 (no argumenths) method _overloading concept is applided here 
        {
            return View();
        }
        [HttpPost]
        public ActionResult department(college clg) //methos_2 (1 argument )
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("index");
            }
            return View();
        }

//=========================== Assigment-1 (Addition of 2 numbers) =================


        public ActionResult Add()
        {
            return View(new Addition());
        }

        [HttpPost]
        public ActionResult Add(Addition obj)
        {
            obj.result = obj.num1 + obj.num2;
            return View(obj);
        }

        //=============================== Assigment- 3 (Arthametic operations)=============
        //----------------------(method-1) -------------------------------

        public ActionResult Assigments()
        {
            return View();
        }  

        //get method 
        public ActionResult method1() //get method we need to create view 
        {
            return View();
        }

        [HttpPost]
        public ActionResult A_Add(Arthametic arth) //in post method no need to create view for all this methods
        {
            arth.result = arth.num1 + arth.num2;  //we are redirecting all this methods to method1 view 
            return View("method1",arth); //we have created view for method1  
        }


        [HttpPost]
        public ActionResult sub(Arthametic arth)
        {
            arth.result = arth.num1 - arth.num2;
            return View("method1", arth);
        }


        [HttpPost]
        public ActionResult mul(Arthametic arth)
        {
            arth.result = arth.num1 * arth.num2;
            return View("method1", arth);
        }


        [HttpPost]
        public ActionResult div(Arthametic arth)
        {
            arth.result = arth.num1 / arth.num2;
            return View("method1", arth);
        }

        //===========================ASSIGEMENT-3 ======================================================

        //-------------- Calculation OF Total and Avg marks ====================

        [HttpGet]//get method
     public ActionResult  std_details()
        {
            return View();
        }

        [HttpPost]
        public ActionResult std_details(std_marks std)
        {
            std.total = std.phy + std.che + std.maths;
            std.average =Math.Round( std.total / 3,2);
            
            if(std.average>=90)
            {
                std.grade = "A-Grade";
            }
            else if(std.average>=75)
            {
                std.grade = "B-Grade";
            }

            else if (std.average >= 50)
            {
                std.grade = "C-Grade";
            }
            else
            {
                std.grade = "Fail";
            }
                return View(std);
        }

//================================= example -11 ================================
  
        public ActionResult reg()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult reg(usermodel obj)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("show_reg");
            }
            return View();
        }

        public ActionResult show_reg()
        {
            return View();
        }











    }
}