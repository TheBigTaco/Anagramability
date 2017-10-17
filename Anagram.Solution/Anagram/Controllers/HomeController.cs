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
      [HttpPost("/results")]
      public ActionResult Results()
      {
          List<string> wordsToCompare = new List<string> {};
          foreach (string listItem in Request.Form["list-items[]"])
          {
            wordsToCompare.Add(listItem);
          }
          Word newWord = new Word(wordsToCompare, Request.Form["base-word"]);
          List<string> successfulAnagrams = newWord.AnagramChecker(newWord);
          return View(successfulAnagrams);
      }
    }
}
