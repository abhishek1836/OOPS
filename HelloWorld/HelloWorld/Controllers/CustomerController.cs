using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class CustomerBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase objContext = controllerContext.HttpContext;
            String custName = objContext.Request.Form["txtCustomerName"];
            String custCode = objContext.Request.Form["txtCustomerCode"];
            Customer obj = new Customer()
            {
                CustomerName = custName,
                CustomerCode = custCode
            };
            return obj;
        }
    }
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer obj = new Customer
            {
                CustomerCode = "1001",
                CustomerName = "Abhishek"
            };
            return View("Customer",obj);
        }
        public ActionResult Enter()
        {
            return View("EnterCustomer");
        }
        public ActionResult Submit([ModelBinder(typeof(CustomerBinder))] Customer obj)
        {
            //Customer obj = new Customer();
            //obj.CustomerName = Request.Form["CustomerName"];
            //obj.CustomerCode = Request.Form["CustomerCode"];
            return View("Customer",obj);
        }
    }
}