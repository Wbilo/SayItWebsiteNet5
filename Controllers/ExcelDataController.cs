using Microsoft.AspNetCore.Mvc;
using SayItWebsiteNet5.Data;
using SayItWebsiteNet5.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Microsoft.Net.Http.Server;
namespace SayItWebsiteNet5.Controllers
{
    public class ExcelDataController : Controller
    {
        private DBFactory _dBFactory;

        public ExcelDataController()
        {
            _dBFactory = new DBFactory();

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Export(string GridHtml)
        {
            // https://www.excelbuzz.com/character-list-for-char-function/
            // string HanÆdderKage = "=\"Han \"&CHAR(230)&\"dder kage\"";
            // i excel felt ="Han"&CHAR(230)&"dder kage"

            GridHtml = GridHtml.Replace("æ", "ae");
            GridHtml = GridHtml.Replace("ø", "oe");
            GridHtml = GridHtml.Replace("å", "aa");
            GridHtml = GridHtml.Replace("Æ", "Ae");
            GridHtml = GridHtml.Replace("Ø", "Oe");
            GridHtml = GridHtml.Replace("Å", "Aa");

            var filname = "ExportedProtocol" + DateTime.Now.ToString() + ".xls";
            return File(System.Text.Encoding.ASCII.GetBytes(GridHtml), "application/vnd.ms-excel", filname);
        }

        public IActionResult CreateTable()
        {
            int WeekNumber = ISOWeek.GetWeekOfYear(DateTime.Now);
            var allprotocolsByWeek = _dBFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol").Where(x => x.WeekNumber == WeekNumber).ToList();



            ExcelData excelData = new ExcelData(WeekNumber, allprotocolsByWeek);

            return View(excelData);
        }

        [HttpPost]

        [Route("ExcelData/CreateTable/{WeekNumber}")]

        public IActionResult CreateTable(int WeekNumber)

        {



            var allprotocolsByWeek = _dBFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol").Where(x => x.WeekNumber == WeekNumber).ToList();



            ExcelData excelData = new ExcelData(WeekNumber, allprotocolsByWeek);




            return View(excelData);

        }



    }
}
