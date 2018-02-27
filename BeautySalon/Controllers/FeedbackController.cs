using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeautySalon.Models;
using BeautySalon.Models.Feedbacks;
using Microsoft.AspNet.Identity;

namespace BeautySalon.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult Index()
        {
            List<Feedback> feedbacksData;
            if (User.Identity.IsAuthenticated && User.IsInRole(RoleTypes.Admin))
            {
                feedbacksData = UnitOfWork.Instance.FeedbackRepository.GetAll().ToList();
            }
            else
            {
                feedbacksData = UnitOfWork.Instance.FeedbackRepository.GetAllApproved();
            }
            List<FeedbackViewModel> feedbacks = feedbacksData
                .Select(x => new FeedbackViewModel() {Id = x.Id, Text = x.Text, Date = x.Date, UserName = x.User.Name, IsApproved = x.IsApproved})
                .ToList();
            return View(feedbacks);
        }

        // GET: Feedback/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: Feedback/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(FeedbackViewModel model)
        {
            if (ModelState.IsValid)
            {
                Feedback feedback = new Feedback()
                {
                    Text = model.Text,
                    Date = DateTime.Now,
                    UserId = User.Identity.GetUserId()
                };
                UnitOfWork.Instance.FeedbackRepository.Create(feedback);
                return Json(new { response = "OK" });
            }
            return Json(new {response = "Error", msg = "Invalid data"});
        }

        // GET: Feedback/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Feedback/Edit/5
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

        // GET: Feedback/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Feedback/Delete/5
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
