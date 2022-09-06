using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using SayItWebsiteNet5.Data;
using SayItWebsiteNet5.Models;
using System.Collections.Generic;
using System.Linq;

namespace SayItWebsiteNet5.Controllers
{
    public class ProjectController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private DBFactory dBFactory;
        public ProjectController(UserManager<ApplicationUser> user)
        {
            _userManager = user;
            dBFactory = new DBFactory();
        }

        public IActionResult Create()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {

            string AppUserId = _userManager.GetUserId(HttpContext.User);
            var participant = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", AppUserId, true);
            project.Owner = participant;
            project.Active = true;
            project.Participants = new List<Student>();
            if (ModelState.IsValid)
            {
                
                var result = dBFactory.CreateDocument<Project>("SayItWebsiteInfo", "Projects", project);
                if (result == null)
                {
                    ViewBag.ResultType = "Success";
                    ViewBag.Message = "Projekt Oprettet";
                    var fullCollection = dBFactory.GetAllDocuments<Project>("SayItWebsiteInfo", "Projects");
                    return View("AllProjects", fullCollection);
                }
                else
                {
                    ViewBag.ResultType = "Error";
                    ViewBag.Message = result.Message;
                }

            }

            return View();
        }

        public IActionResult AllProjects()
        {
 
            var fullCollection = dBFactory.GetAllDocuments<Project>("SayItWebsiteInfo", "Projects");

            return View(fullCollection);
        }


        [HttpGet]
        [Route("Project/GetProject/{projectId}")]
        public IActionResult GetProject(string projectId)
        {
            var fullCollection = dBFactory.GetAllDocuments<Project>("SayItWebsiteInfo", "Projects");
            Project project = fullCollection.Where(x => x.Id.ToString() == projectId).FirstOrDefault();


            return View(project);
        }

        

        [HttpGet]
        [Route("Project/DeleteProject/{projectid}")]
        public IActionResult DeleteProject(string projectId)
        {
            var appUserId = _userManager.GetUserId(HttpContext.User);
            var fullCollection = dBFactory.GetAllDocuments<Project>("SayItWebsiteInfo", "Projects");
            Project updateProject = fullCollection.Where(x => x.Id.ToString() == projectId.ToString()).FirstOrDefault();


            if (User.IsInRole("Admin") || updateProject.Owner._Id.ToString() == appUserId)
            {
                dBFactory.DeleteDocument<Project>("SayItWebsiteInfo", "Projects", updateProject);
            }
            ModelState.AddModelError("DeleteProjectError", "Projektet blev ikke slettet.");

            return RedirectToAction("AllProjects");
        }



        public IActionResult MyProjects()
        {
            string AppUserId = _userManager.GetUserId(HttpContext.User);
            var fullCollection = dBFactory.GetAllDocuments<Project>("SayItWebsiteInfo", "Projects");
            List<Project> collection = fullCollection.Where(x => x.Owner._Id.ToString() == AppUserId).ToList()
                                                     .Concat(fullCollection.Where(y => y.Participants.FirstOrDefault(s => s._Id.ToString() == AppUserId) != null)).ToList();

            return View(collection);
        }


        [HttpGet]
        [Route("Project/SubscribeProject/{projectId}")]
        public ActionResult SubscribeProject(string projectId)
        {
            var fullCollection = dBFactory.GetAllDocuments<Project>("SayItWebsiteInfo", "Projects");
            Project updatedProject = fullCollection.Where(x => x.Id.ToString() == projectId).FirstOrDefault();

            string AppUserId = _userManager.GetUserId(HttpContext.User);
            var participant = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", AppUserId, true);
            if (!updatedProject.Participants.Any(x => x._Id == participant._Id) && updatedProject.Owner._Id.ToString() != participant._Id.ToString() )
            {
                updatedProject.Participants.Add(participant);
                var db = dBFactory.GetDb("SayItWebsiteInfo");
                var doc = db.GetCollection<Project>("Projects");
                var result = doc.ReplaceOne(Builders<Project>.Filter.Eq("_id", updatedProject.Id), updatedProject);
    
                if (result.IsAcknowledged == true)
                {
                    ViewBag.Message = "Du er nu tilmeldt til Projektet";
                }
            }
            else
            {
                ViewBag.Message = "Du er allerede tilmeldt";

            }

            return RedirectToAction("AllProjects");
        }

        [HttpGet]
        [Route("Project/UnSubscribeProject/{projectId}")]
        public ActionResult UnSubscribeProject(string projectId)
        {
            string AppUserId = _userManager.GetUserId(HttpContext.User);
            var fullCollection = dBFactory.GetAllDocuments<Project>("SayItWebsiteInfo", "Projects");
            Project updateProject = fullCollection.Where(x => x.Id.ToString() == projectId).FirstOrDefault();
            updateProject.Participants.RemoveAll(s => s._Id.ToString() == AppUserId);
            var doc = dBFactory.GetDb("SayItWebsiteInfo").GetCollection<Project>("Projects");
            var result = doc.ReplaceOne(Builders<Project>.Filter.Eq("_id", updateProject.Id), updateProject);
            if (result.IsAcknowledged == true)
            {
                ViewBag.Message = "Du er nu tilmeldt til eventet";
            }

            var participant = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", AppUserId, true);
            List<Project> collection = fullCollection.Where(x => x.Participants.Any(y => y?._Id == participant._Id)).ToList();

            return RedirectToAction("AllProjects");


        }

        [HttpGet]
        [Route("Project/ChangeStatus/{projectId}")]
        public IActionResult ChangeStatus(string projectId)
        {

            var project = dBFactory.GetOneDocument<Project>("SayItWebsiteInfo", "Projects", projectId,false);
            project.Active = !project.Active;

            var x = dBFactory.UpdateOneDocument("SayItWebsiteInfo", "Projects", project);


            return RedirectToAction("AllProjects");
        }
    }
}
