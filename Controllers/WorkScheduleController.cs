
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SayItWebsiteNet5.Controllers
{
    public class WorkScheduleController : Controller
    {
        // GET: WokrScheduleController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WokrScheduleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WokrScheduleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WokrScheduleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WokrScheduleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WokrScheduleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WokrScheduleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WokrScheduleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
