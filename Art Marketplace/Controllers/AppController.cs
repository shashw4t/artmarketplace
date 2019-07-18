using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Art_Marketplace.ViewModels;

namespace Art_Marketplace.Controllers
{
    public class AppController : Controller
    {
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
