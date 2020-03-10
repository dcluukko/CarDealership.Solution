using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cars.Models;

namespace Cars.Controllers
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