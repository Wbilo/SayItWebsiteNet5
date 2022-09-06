using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using SayItWebsiteNet5.Models;
using SayItWebsiteNet5.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace SayItWebsiteNet5.Controllers
{
    public class SIEventsController : Controller
    {
        // GET: SIEventsController
        private UserManager<ApplicationUser> _userManager;
        private DBFactory dBFactory;
        public SIEventsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;

            dBFactory = new DBFactory();
        }
        public ActionResult Index()
        {
            //add allEvents to viewbag then manage in view
            var allEvents = dBFactory.GetAllDocuments<SIEvents>("SayItWebsiteInfo", "Events");
            var currentEvents = from events in allEvents
                                where events.Date.Date > DateTime.Now.AddDays(-30).Date
                                select events;

            return View(currentEvents);
        }

        public ActionResult Create()
        {

            return View();
        }

        //tilføj noget tjek + viewbag med success
        [HttpPost]
        public ActionResult Create(SIEvents SIevent)
        {

            if (ModelState.IsValid)
            {
                SIevent.Participants = new List<Student>();
                SIevent.Creator = _userManager.GetUserId(HttpContext.User);
                var htprq = HttpContext.Request.Form["AddAll"].ToString();
                if (htprq == "on")
                {
                    SIevent.Participants = dBFactory.GetAllDocuments<Student>("SayItWebsiteInfo", "Students").Where(x => x.Active == true).ToList();
                }


                var result = dBFactory.CreateDocument<SIEvents>("SayItWebsiteInfo", "Events", SIevent);

                if (result == null)
                {
                    ViewBag.ResultType = "Succes";
                    ViewBag.Message = "Event Oprettet";
                    return RedirectToAction("Index");

                }
                else
                {
                    ViewBag.ResultType = "Error";
                    ViewBag.Message = result.Message;
                    return View();
                }

            }
            return View();

        }
        [HttpGet]
        [Route("SIEvents/SubscribeEvent/{EventId}")]
        public ActionResult SubscribeEvent(string EventId)
        {
            var fullCollection = dBFactory.GetAllDocuments<SIEvents>("SayItWebsiteInfo", "Events");
            SIEvents updatedEvent = fullCollection.Where(x => x.Id.ToString() == EventId).FirstOrDefault();

            string AppUserId = _userManager.GetUserId(HttpContext.User);
            var participant = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", AppUserId, true);
            if (!updatedEvent.Participants.Any(x => x._Id == participant._Id))
            {
                updatedEvent.Participants.Add(participant);
                var db = dBFactory.GetDb("SayItWebsiteInfo");
                var doc = db.GetCollection<SIEvents>("Events");
                var result = doc.ReplaceOne(Builders<SIEvents>.Filter.Eq("_id", updatedEvent.Id), updatedEvent);
                //var result = dBFactory.UpdateOneDocument("SayItWebsiteInfo", "Events", collection);
                if (result.IsAcknowledged == true)
                {
                    ViewBag.Message = "Du er nu tilmeldt til eventet";
                }
            }
            else
            {
                ViewBag.Message = "Du er allerede tilmeldt";

            }

            var allEvents = dBFactory.GetAllDocuments<SIEvents>("SayItWebsiteInfo", "Events");
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("SIEvents/DetailedEvent/{EventId}")]
        public IActionResult DetailedEvent(string eventId)
        {
            var fullCollection = dBFactory.GetAllDocuments<SIEvents>("SayItWebsiteInfo", "Events");
            List<SIEvents> collection = fullCollection.Where(x => x.Id.ToString() == eventId).ToList();
            ViewBag.Creator = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", collection.First().Creator, true).Name;

            return View(collection.First());
        }

        public ActionResult MyEvents()
        {
            string AppUserId = _userManager.GetUserId(HttpContext.User);
            var fullCollection = dBFactory.GetAllDocuments<SIEvents>("SayItWebsiteInfo", "Events");
            var participant = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", AppUserId, true);
            List<SIEvents> collection = fullCollection.Where(x => x.Participants.Any(y => y?._Id == participant._Id)).ToList();

            return View(collection);
        }

        [HttpGet]
        [Route("SIEvents/UnSubscribeEvent/{EventId}")]
        public ActionResult UnSubscribeEvent(string EventId)
        {
            string AppUserId = _userManager.GetUserId(HttpContext.User);
            var fullCollection = dBFactory.GetAllDocuments<SIEvents>("SayItWebsiteInfo", "Events");
            SIEvents updateEvent = fullCollection.Where(x => x.Id.ToString() == EventId).FirstOrDefault();
            updateEvent.Participants.RemoveAll(s => s._Id.ToString() == AppUserId);
            var doc = dBFactory.GetDb("SayItWebsiteInfo").GetCollection<SIEvents>("Events");
            var result = doc.ReplaceOne(Builders<SIEvents>.Filter.Eq("_id", updateEvent.Id), updateEvent);
            if (result.IsAcknowledged == true)
            {
                ViewBag.Message = "Du er nu tilmeldt til eventet";
            }

            var participant = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", AppUserId, true);
            List<SIEvents> collection = fullCollection.Where(x => x.Participants.Any(y => y?._Id == participant._Id)).ToList();

            return RedirectToAction("MyEvents");


        }

        [HttpGet]
        [Route("SIEvents/DeleteEvent/{EventId}")]
        public ActionResult DeleteEvent(string EventId)
        {

            var appUserId = _userManager.GetUserId(HttpContext.User);
            var fullCollection = dBFactory.GetAllDocuments<SIEvents>("SayItWebsiteInfo", "Events");
            SIEvents updateEvent = fullCollection.Where(x => x.Id.ToString() == EventId).FirstOrDefault();


            if (User.IsInRole("Admin") || updateEvent.Creator == appUserId)
            {
                dBFactory.DeleteDocument<SIEvents>("SayItWebsiteInfo", "Events", updateEvent);
            }
            ModelState.AddModelError("DeleteEventError", "Event blev ikke slettet.");

            return RedirectToAction("Index");



        }


    }
}
