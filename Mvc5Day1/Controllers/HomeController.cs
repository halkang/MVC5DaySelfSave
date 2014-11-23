using Mvc5Day1.ActionFilters;
using Mvc5Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Day1.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
#if DEBUG
        [NonAction]
#endif
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //return new ViewResult() { ViewName = "About" };
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult About2()
        {
            return View("About", "_Layout2");
        }

        public ActionResult About3()
        {
            return View();
        }

        public ActionResult DoAction()
        {
            return Content("<script>alert('xxxx'); location.href='/';</script>");
        }

        public ActionResult Content1()
        {
            return Content("1");
        }
        public string Content2()
        {
            return "1";
        }

        public ActionResult File1()
        {
            return File(Server.MapPath("~/Content/people.jpg"), "image/jpeg");
        }


        public ActionResult File2()
        {
            return File(Server.MapPath("~/Content/people.jpg"), "image/jpeg", "my_people.jpg");
        }

        public ActionResult File3()
        {
            var contents = new System.Net.WebClient().DownloadData("http://lorempixel.com/400/400/cats/");

            return File(contents, "image/jpeg");
        }

        public ActionResult ReadJson()
        {
            return View();
        }

        public ActionResult Json1()
        {
            return Json(new
            {
                id = 1,
                name = "Will"
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Redirect1()
        {
            return Redirect("/");
        }

        public ActionResult Redirect2()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Redirect3()
        {
            return RedirectToRoute(new { action = "Index" });
        }

        public ActionResult TempData1()
        {
            TempData["name"] = "Will";

            return RedirectToAction("TempData2");
        }

        public ActionResult TempData2()
        {
            ViewData.Model = TempData["name"];
            return View();
        }

        public ActionResult SimpleBindingForm()
        {
            return View();
        }

        public ActionResult SimpleBinding(string name, string tel)
        {
            return Content("Name = " + name + " , Tel = " + tel);
        }

        [HttpPost]
        public ActionResult SimpleBinding2(FormCollection form)
        {
            return Content("Name = " + form["name"] + " , Tel = " + form["tel"]);
        }

        public ActionResult SimpleBinding3Form()
        {
            return View();
        }


        /*
         * data.name
         * data.tel
         * data2.name
         * data2.tel
         */

        [HttpPost]
        public ActionResult SimpleBinding3(NameTelVM data)
        {
            if (ModelState.IsValid)
            {
                return Content("Name = " + data.name + " , Tel = " + data.tel);
            }
            else
            {
                return Content("Name = " + data.name + " , Tel = " + data.tel + "(Required)");
            }
        }

        [HandleError(ExceptionType = typeof(ArgumentException), View = "ErrorArgumentException")]
        //[HandleError(ExceptionType = typeof(Exception), View = "Error")]
        public ActionResult GetError(int? i)
        {
            if (i.HasValue && i == 1)
            {
                throw new ArgumentException("錯誤發生");
            }
            else
            {
                throw new Exception("General Error");
            }

            return View();
        }

        public ActionResult CustomFilter()
        {
            return View();
        }

        [ShareData]
        public ActionResult CustomFilter2()
        {
            return View("CustomFilter");
        }


        public ActionResult Razor1()
        {
            ViewBag.IsEnabled = true;


            ViewBag.Array = new int[] { 1, 2, 3, 4, 5 };


            return PartialView();
        }

    }


}