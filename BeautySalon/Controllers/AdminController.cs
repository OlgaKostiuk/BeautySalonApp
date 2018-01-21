using System;
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
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult CreatePromotion(CreatePromotionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Promotion promotion = new Promotion {Title = model.Title, Description = model.Description, Date = DateTime.Today};
                UnitOfWork.Instance.PromotionRepository.Create(promotion);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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
