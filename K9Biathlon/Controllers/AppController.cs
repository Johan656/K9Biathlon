using K9Biathlon.Data;
using K9Biathlon.Services;
using K9Biathlon.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Controllers

{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IK9Repository _repository;

        public AppController(IMailService mailService, IK9Repository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            var result = _repository.getAllTavlingar();
            return View();
        }

        //[HttpGet("Registrera")]
        [HttpGet()]
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Regler()
        {
            return View();
        }


        [HttpPost()]
        public IActionResult Register(object model)
        {
            if(ModelState.IsValid)
            {
                // Do something
              
            } 
            else
            {
                // Show error 
            }

            return View();
        }

        public IActionResult Sponsorer()
        {
            return View();
        }

        //[HttpGet("Kontakt")]
        [HttpGet()]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                // Send Email
                _mailService.SendMessage("johanohberg6@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "E-post skickad";
                ModelState.Clear();
            }
            else
            {
                // Show error 
            }

            return View();
        }

        public IActionResult Admin()
        {
            var results = _repository.getAllAnmalningar();

            return View(results);
        }

        public IActionResult Anmalan()
        {
            return View();
        }

        [HttpGet("Om oss")]
        public IActionResult About()
        {    
            return View();
        }
    }
}
