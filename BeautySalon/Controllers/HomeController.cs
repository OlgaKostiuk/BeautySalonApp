using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeautySalon.Models.Orders;
using BeautySalon.Models.Services;

namespace BeautySalon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult HaircutAndStyling()
        {
            return View();
        }

        public ActionResult HairColoring()
        {
            return View();
        }

        public ActionResult HairProcedures()
        {
            return View();
        }

        public ActionResult MakeUp()
        {
            return View();
        }

        public ActionResult Nails()
        {
            return View();
        }

        public ActionResult Cosmetology()
        {
            return View();
        }

        public ActionResult Massage()
        {
            return View();
        }
        public ActionResult ManSalon()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult OurTeam()
        {
            return View();
        }

        public ActionResult Header()
        {
            List<ServiceViewModel> viewModel = UnitOfWork.Instance.ServiceRepository.GetAll()
                .Select(x => new ServiceViewModel() { Id = x.Id, Category = x, Services = x.Services.ToList() }).ToList();
            return View("_Header", viewModel);
        }

        public ActionResult CreateCallbackOrder(CallbackOrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                CallbackOrder callbackOrder = new CallbackOrder()
                {
                    Name = model.Name,
                    DateTime = DateTime.Now,
                    IsPending = true,
                    PhoneNumber = model.PhoneNumber
                };
                UnitOfWork.Instance.OrderRepository.Create(callbackOrder);
                return Json(new { response = "OK" });
            } else {
                //List<ModelErrorCollection> errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                List<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors).ToList();
                List<string> allErrorsMessages = allErrors.Select(x => x.ErrorMessage).ToList();
                return Json(new { response = "Error", msg = allErrorsMessages });
            }      
        }
    }
}