using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using BeautySalon.Models;
using BeautySalon.Models.Promotions;

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
                UnitOfWork.Instance.PromotionRepository.Create(promotion);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // GET: Admin/Edit/5
        public ActionResult EditPromotion(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult EditPromotion(int id, FormCollection collection)
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
    }
}
