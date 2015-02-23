using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HelloWordController : Controller
    {

        /*
         
        // 
        // GET: /HelloWorld/ 
        //Cap 2
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        //Cap 3
        public ActionResult Index()
        {
            return View();
        }
        
        //// 
        //// GET: helloword/welcome?name=Scott&numtimes=4
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //} 

        // 
        // GET: HelloWorld/Welcome/3?name=Rick
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
        
        // GET: helloword/Welcome/Rick/3
             //routes.MapRoute(
             //    name: "Hello",
             //    url: "{controller}/{action}/{name}/{id}"
             //);


        */

        //Cap 3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

    }
}