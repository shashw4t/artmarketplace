using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Art_Marketplace.ViewModels;
using Art_Marketplace.Services;

namespace Art_Marketplace.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService mailService;

        public AppController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send email
                mailService.SendMessage("dummyemail@email.com", model.Subject, $"From: {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail sent";
                ModelState.Clear(); 
                //emptys contact form
            }
            else
            {
                //throw errors
            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }
    }
}
