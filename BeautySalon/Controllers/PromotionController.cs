using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeautySalon.Models;
using BeautySalon.Models.Promotions;

namespace BeautySalon.Controllers
{
    public class PromotionController : Controller
    {
        // GET: Promotion
        public ActionResult Index()
        {
            List<PromotionViewModel> pageData = UnitOfWork.Instance.PromotionRepository.GetPage(1).Data
                .Select(x => new PromotionViewModel(x)).ToList();
            PageViewModel<PromotionViewModel> page = new PageViewModel<PromotionViewModel>()
            {
                Data = pageData,
                Count = pageData.Count
            };
            return View(page);
        }


        public ActionResult GetPage(PageRequestModel pageRequest)
        {
            List<PromotionViewModel> pageData = pageRequest == null
                ? UnitOfWork.Instance.PromotionRepository.GetPage(1).Data.Select(x => new PromotionViewModel(x))
                    .ToList()
                : UnitOfWork.Instance.PromotionRepository.GetPage(pageRequest.PageNumber, pageRequest.CountPerPage).Data.Select(x => new PromotionViewModel(x))
                    .ToList();
            return PartialView("_PromotionList", pageData);
        }

        // GET: Promotion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Promotion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promotion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Promotion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Promotion/Edit/5
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

        // GET: Promotion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Promotion/Delete/5
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
