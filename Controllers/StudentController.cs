using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SayItWebsiteNet5.Models;
using SayItWebsiteNet5.Data;

using System;
using System.Linq;
using System.Collections.Generic;

namespace SayItWebsiteNet5.Controllers
{
    public class StudentController : Controller
    {

        private UserManager<ApplicationUser> _userManager;
        private DBFactory _dbFactory;
        public StudentController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _dbFactory = new DBFactory();
        }

        //get all 
        public ActionResult Index()
        {
            var collection = _dbFactory.GetAllDocuments<Student>("SayItWebsiteInfo", "Students");

            return View(collection);
        }

        public ActionResult ActiveStudents()
        {
            var collection = _dbFactory.GetAllDocuments<Student>("SayItWebsiteInfo", "Students").Where(x => x.Active == true);

            return View(collection);
        }

        [HttpGet]
        [Route("Student/ChangeActivity/{userid}")]
        public IActionResult ChangeActivity(Guid userid)
        {
            var student = _dbFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", userid.ToString(), true);
            student.Active = !student.Active;

            var x = _dbFactory.UpdateOneDocument("SayItWebsiteInfo", "Students", student);



            return RedirectToAction("Index");

        }


        [HttpGet]
        [Route("Student/GetStudent/{userid}")]
        public IActionResult GetStudent(Guid userid)
        {

            var student = _dbFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", userid.ToString(), true);
            var protocols = _dbFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol");
            var relevantProtocols = protocols.Where(x => x.StudentProtocol.ContainsKey(userid.ToString()));
            List<ProtocolData> protocolsData = new List<ProtocolData>();
            List<DateTime> relevantDates = new List<DateTime>();

            foreach (Protocol protocol in relevantProtocols)
            {
                protocol.StudentProtocol.TryGetValue(userid.ToString(), out var protocolData);
                protocolsData.Add(protocolData);
                relevantDates.Add(protocol.Date);
            }
            //fix
            int totalDays = 0;
            int presentDays = 0;
            int datecount = 0;

            List<dynamic> dataPoints = new List<dynamic>();


            foreach (var p in protocolsData)
            {
                totalDays++;
                if (p.Present == true)
                {
                    presentDays++;
                }
                //hvis note = "" og ikke null - ændrer
                var temp = ((float)presentDays / (float)totalDays) * 100f;
                int attendance = (int)temp;
                dynamic x = new
                {
                    label = $"{relevantDates[datecount].ToShortDateString()}",
                    y = attendance,
                    tooltip = p.Note ?? "Ingen Note"
                };

                dataPoints.Add(x);
                datecount++;


            }

            ViewBag.dataPoints = dataPoints;

            
            var projectCollection = _dbFactory.GetAllDocuments<Project>("SayItWebsiteInfo", "Projects");
            List<Project> MyProjects = projectCollection.Where(x => x.Owner._Id.ToString() == userid.ToString() && x.Active == true).ToList()
                                                     .Concat(projectCollection.Where(y => y.Participants.FirstOrDefault(s => s._Id.ToString() == userid.ToString()) != null && y.Active == true)).ToList();

            ViewBag.ProjectCollection = MyProjects;

            return View(student);
        }

        [HttpPost]
        [Route("Student/AddNote/{userid}")]
        public IActionResult AddNote(Guid userid)
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1980, 1, 1);

            var student = _dbFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", userid.ToString(), true);
            student.Notes.Add(new Note
            {
                Date = DateTime.Now,
                Id = (int)t.TotalSeconds,
                Message = Request.Form["Message"]

            });
            _dbFactory.UpdateOneDocument<Student>("SayItWebsiteInfo", "Students", student);



            return RedirectToAction("GetStudent", new { id = userid });
        }
        [HttpGet]
        [Route("Student/DeleteNote/{userid}")]
        public IActionResult DeleteNote(Guid userid)
        {

            string noteId = HttpContext.Request.Query["id2"].ToString();
            var student = _dbFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", userid.ToString(), true);
            var noteToDelete = student.Notes.FirstOrDefault(x => x.Id.ToString() == noteId);
            student.Notes.Remove(noteToDelete);
            _dbFactory.UpdateOneDocument<Student>("SayItWebsiteInfo", "Students", student);


            return RedirectToAction("GetStudent", new { id = userid });
        }

      
    }
}


