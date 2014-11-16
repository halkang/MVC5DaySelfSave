using Mvc5Day1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
using System.Xml;
using System.Text;

namespace Mvc5Day1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //var o = db.Occupation.First();

            //string a = o.MEMO2;

            return View();
        }

        public ActionResult About(string message = "Your application description page.")
        {
            ViewBag.Message = message;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CreateClient()
        {
            var db = new FabricsEntities();
            Client client = new Client()
            {
                FirstName = "Will",
                LastName = "Huang",
                CreatedOn = DateTime.Now

            };


            db.Client.Add(client);


            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                //throw ex;
                var allErrors = new List<string>();

                foreach (DbEntityValidationResult re in ex.EntityValidationErrors)
                {
                    foreach (DbValidationError err in re.ValidationErrors)
                    {
                        allErrors.Add(err.ErrorMessage);
                    }
                }

                ViewBag.Errors = allErrors;
            }


            return View(client);
        }

        public ActionResult GetClients()
        {
            var db = new FabricsEntities();

            var q = db.Client.AsQueryable().OrderByDescending(p => p.ClientId).Take(10);

            //var q = db.Client.AsQueryable();
            //q = q.Where(p => p.ClientId < 10);

            return View(q);
        }

        public ActionResult GetProduct()
        {
            return View(db.GetProduct());
        }

        public ActionResult UpdateClient(int id)
        {
            var db = new FabricsEntities();

            //var one = db.Client.Find(id);
            var one = db.Client.FirstOrDefault(p => p.ClientId == id);
            //var one = db.Client.Where(p => p.ClientId == id).First();
            one.Gender = "M";
            one.City = "Taipei";

            var c = new Client() { Gender = "M" };
            c.City = "Taiepi";

            db.SaveChanges();

            return View(one);
        }

        FabricsEntities db = new FabricsEntities();


        public ActionResult UpdateDallastoTaipei(string city)
        {
            var q = from p in db.Client
                    where p.City == city
                    select p;

            foreach (var item in q)
            {
                item.City = "Taipei";
            }
            //db.Database.ExecuteSqlCommand("UPDATE ");
            db.SaveChanges();

            return View("GetClients", q.ToList());
        }

        public void DeleteClient(int id)
        {
            var client = db.Client.First(p => p.ClientId == id);

            //foreach (var order in db.Order.Where(p => p.ClientId == data.ClientId))
            //{

            //}


            //foreach (var order in data.Order.ToList())
            //{
            //    foreach (var orderLine in order.OrderLine.ToList())
            //    {
            //        db.OrderLine.Remove(orderLine);
            //    }

            //    db.Order.Remove(order);
            //}


            foreach (var order in client.Order.ToList())
            {
                db.OrderLine.RemoveRange(order.OrderLine);
            }

            db.Order.RemoveRange(client.Order);
            
            db.Client.Remove(client);

            db.SaveChanges();
        }

    }
}