using Microsoft.AspNetCore.Mvc;
using SimpleSubjectApp.Models;
using SimpleSubjectApp.Service.Interface;
using System.Diagnostics;
using System.Text.Json;

namespace SimpleSubjectApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SubjectServiceInterface _subjectServiceInterface;

        public HomeController(SubjectServiceInterface subjectService)
        {

            _subjectServiceInterface = subjectService;
        }

        public IActionResult Index()
        {
            var items = _subjectServiceInterface.getAllSubjects();
            return View(items);
        }

        public IActionResult AddSubject()
        {
            
            return View();
        }



        [HttpPost]
        public IActionResult AddSubject(Subject subject)
        {
            if (ModelState.IsValid)
            {

                var items = _subjectServiceInterface.getAllSubjects();
                subject.Id = items.LastOrDefault().Id + 1;

                string lit = subject.LiteratureUsed.ToArray()[0];
                List<string> lista = lit.Split(",").ToList();

                subject.LiteratureUsed = lista;
                _subjectServiceInterface.addSubject(subject);

                return RedirectToAction("Index");
            }
            return View("AddSubject", subject);
        }


        public IActionResult AddSubjectJSON()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AddSubjectJSON(string json)
        {

            try { 
            Subject subject = JsonSerializer.Deserialize<Subject>(json);
             var items = _subjectServiceInterface.getAllSubjects();
             subject.Id = items.LastOrDefault().Id + 1;
             _subjectServiceInterface.addSubject(subject);

            return RedirectToAction("Index");
            }
            catch (JsonException ex)
            {
                
                return BadRequest("Invalid JSON format");
            }
        }

        [HttpPost]
        public IActionResult SubjectDetails(int subjectId)
        {
            var subject = _subjectServiceInterface.getSubjectDetails(subjectId);
   
            return View("SubjectDetails", subject);
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}