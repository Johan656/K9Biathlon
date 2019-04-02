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
        //private readonly IMailService _mailService;
        //private readonly IK9Repository _repository;

        //public AppController(IMailService mailService, IK9Repository repository)
        //{
        //    //_mailService = mailService;
        //    //_repository = repository;
        //}

        public AppController()
        {
            //_mailService = mailService;
            //_repository = repository;
        }

        public IActionResult Index()
        {
            //var result = _repository.getAllTavlingar();
            return View();
        }

        //[HttpGet("Registrera")]
        //[HttpGet()]
        public IActionResult Register()
        {
            ViewBag.BackgroundImage = "Segersjö1.jpg";

            return View();  
        }

        public IActionResult Regler()
        {
            ViewBag.BackgroundImage = "Hund.jpg";
            @ViewBag.BackgroundText1 = "Regler";

            return View();
        }


        //[HttpPost()]
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

        //[Route("/App/Sponsorer", Name = "Samarbetspartners")]
        public IActionResult Sponsorer()
        {
            ViewBag.BackgroundImage = "banträning-5083.jpg";
            @ViewBag.BackgroundText1 = "Samarbetspartners";
            return View();
        }

        //[HttpGet("Kontakt")]
        [HttpGet()]
        public IActionResult Contact()
        {
            ViewBag.BackgroundImage = "Segersjö1.jpg";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                // Send Email
                //_mailService.SendMessage("johanohberg6@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
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
            //var results = _repository.getAllAnmalningar();

            return View();
        }

        public IActionResult Anmalan()
        {
            ViewBag.BackgroundImage = "banträning-5260k.jpg";
            @ViewBag.BackgroundText1 = "Anmälan";
            return View();
        }

        [HttpGet("Om oss")]
        public IActionResult About()
        {
            ViewBag.BackgroundImage = "banträning-5242-2k.jpg";
            @ViewBag.BackgroundText1 = "Om oss";
            return View();
        }
    }
}
