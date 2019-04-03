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

        }

        public IActionResult Index()
        {

            return View();
        }


        [Route("Regler")]
        public IActionResult Regler()
        {
            ViewBag.BackgroundImage = "Hund.jpg";
            @ViewBag.BackgroundText1 = "Regler";

            return View();
        }


        [Route("Samarbetspartners")]
        public IActionResult Samarbetspartners()
        {
            ViewBag.BackgroundImage = "banträning-5083.jpg";
            @ViewBag.BackgroundText1 = "Samarbetspartners";
            return View();
        }

        public IActionResult Admin()
        {
            //var results = _repository.getAllAnmalningar();

            return View();
        }

        [Route("Anmalan")]
        public IActionResult Anmalan()
        {
            ViewBag.BackgroundImage = "banträning-5260k.jpg";
            @ViewBag.BackgroundText1 = "Anmälan";
            return View();
        }

        [Route("Om")]
        public IActionResult Om()
        {
            ViewBag.BackgroundImage = "banträning-5242-2k.jpg";
            @ViewBag.BackgroundText1 = "Om oss";
            return View();
        }
    }
}
