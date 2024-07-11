using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string filePath = Server.MapPath("~/Data/ScientistInputData.json");
            var jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var scientistInput = JsonConvert.DeserializeObject<List<ScientistInputModel>>(jsonData) ?? new List<ScientistInputModel>();
            Session["scientistInput"] = scientistInput;

            filePath = Server.MapPath("~/Data/AnimalData.json");
            jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var animalData = JsonConvert.DeserializeObject<List<AnimalDataModel>>(jsonData) ?? new List<AnimalDataModel>();
            Session["animalData"] = animalData;

            return View();
        }

        [HttpPost]
        public ActionResult Index(ScientistInputModel objScientistInputModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string filePath = Server.MapPath("~/Data/ScientistInputData.json");
                    var jsonData = System.IO.File.ReadAllText(filePath);
                    // De-serialize to object or create new list
                    var scientistInput = JsonConvert.DeserializeObject<List<ScientistInputModel>>(jsonData) ?? new List<ScientistInputModel>();

                    // Add any new employees
                    scientistInput.Add(objScientistInputModel);
                    jsonData = JsonConvert.SerializeObject(scientistInput);
                    System.IO.File.WriteAllText(filePath, jsonData);

                    jsonData = System.IO.File.ReadAllText(filePath);
                    // De-serialize to object or create new list
                    scientistInput = JsonConvert.DeserializeObject<List<ScientistInputModel>>(jsonData) ?? new List<ScientistInputModel>();
                    Session["scientistInput"] = scientistInput;

                    ModelState.Clear();
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}