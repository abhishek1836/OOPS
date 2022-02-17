using GlobleTimesNow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GlobleTimesNow.Controllers
{
    public class HomeController : Controller
    {
        Demo_LearningEntities dbaccess = new Demo_LearningEntities();
        public ActionResult Index()
        {
            
            var emplist = dbaccess.tbl_Employees.ToList();
            return View(emplist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Employees model)
        {
            dbaccess.tbl_Employees.Add(model);
            dbaccess.SaveChanges();
            ViewBag.Message = "Data Insert Successfully";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = dbaccess.tbl_Employees.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(tbl_Employees Model)
        {
            var data = dbaccess.tbl_Employees.Where(x => x.Id == Model.Id).FirstOrDefault();
            if (data != null)
            {
                data.FirstName = Model.FirstName;
                data.LastName = Model.LastName;
                data.Location = Model.Location;
                data.Gender=Model.Gender;
                data.Salary=Model.Salary;
                dbaccess.SaveChanges();
            }

            return RedirectToAction("index");
        }

        public ActionResult Detail(int id)
        {
            List<tbl_Employees> emp = new List<tbl_Employees>();
            var empfilter = (from temp in emp where temp.Salary > 1000 select temp).ToList();
            foreach(var temp in empfilter)
            {
                emp.Add(temp);
            }
            var data = dbaccess.tbl_Employees.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        public ActionResult Delete(int id)
        {
            var data = dbaccess.tbl_Employees.Where(x => x.Id == id).FirstOrDefault();
            dbaccess.tbl_Employees.Remove(data);
            dbaccess.SaveChanges();
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("index");
        }
    }
}