
using System.Web.Mvc;
using FeedbackManagementSystem.Models;

namespace FeedbackManagementSystem.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                ViewBag.SuccessMessage =
                    "Thank you! Your feedback was submitted successfully.";

                ModelState.Clear();

                return View(new Feedback());
            }

            return View(feedback);
        }
    }
}
