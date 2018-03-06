using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using BeautySalon.Models;
using BeautySalon.Models.Orders;
using BeautySalon.Models.Promotions;
using BeautySalon.Models.Services;

namespace BeautySalon.Controllers
{
    [Authorize(Roles = RoleTypes.Admin)]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult CreatePromotion()
        {
            ViewBag.Title = "Добавить новость";
            return View(new PromotionViewModel());
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult CreatePromotion(PromotionViewModel model, IEnumerable<HttpPostedFileBase> pictures)
        {
            if (ModelState.IsValid)
            {
                Promotion promotion = new Promotion
                {
                    Title = model.Title,
                    Description = model.Description,
                    Date = DateTime.Now,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate
                };
                if (pictures.FirstOrDefault() != null)
                {
                    foreach (var image in pictures)
                    {
                        string uniqueName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                        string localPath = Path.Combine(Server.MapPath($"~{WebConfigurationManager.AppSettings["ImagesFolder"]}"), uniqueName);

                        image.SaveAs(localPath);
                        promotion.Images.Add(new PromotionImage { Path = uniqueName });
                    }
                }
                UnitOfWork.Instance.PromotionRepository.Create(promotion);

                return RedirectToAction("Index", "Promotion");
            }
            return View(model);
        }

        // GET: Admin/Edit/5
        public ActionResult EditPromotion(int id)
        {
            Promotion promotion = UnitOfWork.Instance.PromotionRepository.GetById(id);
            if (promotion == null)
            {
                ViewBag.Title = "Добавить новость";
                return View("CreatePromotion", new PromotionViewModel());
            }
            ViewBag.Title = "Редактировать новость";
            return View("CreatePromotion", new PromotionViewModel(promotion));
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult EditPromotion(PromotionViewModel model, IEnumerable<HttpPostedFileBase> pictures)
        {
            if (ModelState.IsValid)
            {
                Promotion promotion = new Promotion
                {
                    Id = model.Id,
                    Title = model.Title,
                    Description = model.Description,
                    Date = DateTime.Today,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate
                };
                if (pictures.FirstOrDefault() != null)
                {
                    foreach (var image in pictures)
                    {
                        string uniqueName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                        string localPath = Path.Combine(Server.MapPath($"~{WebConfigurationManager.AppSettings["ImagesFolder"]}"), uniqueName);

                        image.SaveAs(localPath);
                        promotion.Images.Add(new PromotionImage { Path = uniqueName });
                    }
                }
                UnitOfWork.Instance.PromotionRepository.Update(promotion);

                return RedirectToAction("Index", "Promotion");
            }
            return RedirectToAction("EditPromotion", model.Id);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
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

        [HttpPost]
        public ActionResult DeleteFeedback(int id)
        {

            UnitOfWork.Instance.FeedbackRepository.Delete(id);
            return Json(new { response = "OK" });
        }

        [HttpPost]
        public ActionResult DeletePromotion(int id)
        {

            UnitOfWork.Instance.PromotionRepository.Delete(id);
            return Json(new { response = "OK" });
        }

        [HttpPost]
        public ActionResult ApproveFeedback(int id)
        {

            UnitOfWork.Instance.FeedbackRepository.Approve(id);
            return Json(new { response = "OK" });
        }

        public ActionResult CallbackOrdersList()
        {
            List<CallbackOrderViewModel> viewModel = UnitOfWork.Instance.OrderRepository.GetAllCallbackOrders()
                .Select(x => new CallbackOrderViewModel() { Id = x.Id, Name = x.Name, PhoneNumber = x.PhoneNumber, DateTime = x.DateTime }).ToList();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult DeleteCallbackOrder(int id)
        {
            UnitOfWork.Instance.OrderRepository.Delete(id);
            return Json(new { response = "OK" });
        }

        public ActionResult BookingsList()
        {
            List<BookingViewModel> viewModel = UnitOfWork.Instance.OrderRepository.GetAllBookings()
                .Select(x => new BookingViewModel() { Id = x.Id, Name = x.Name, PhoneNumber = x.PhoneNumber, Date = x.Date, Time = x.Time, ServiceId = x.ServiceId}).ToList();
            List<ServiceViewModel> serviceList = UnitOfWork.Instance.ServiceRepository.GetAll()
                .Select(x => new ServiceViewModel() { Id = x.Id, Category = x, Services = x.Services.ToList() }).ToList();
            ViewBag.ServiceList = serviceList;
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult DeleteBooking(int id)
        {
            UnitOfWork.Instance.OrderRepository.DeleteBooking(id);
            return Json(new { response = "OK" });
        }
    }
}
