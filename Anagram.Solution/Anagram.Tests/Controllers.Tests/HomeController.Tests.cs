using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
        return View();
        }
    }
}
