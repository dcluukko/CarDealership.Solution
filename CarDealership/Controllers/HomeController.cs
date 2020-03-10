using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
   [Route("/")]
    public ActionResult Index()
    {
      Car carItem = new Car("Add a car");
      return View(carItem);
    }
    [Route("/cars/new")]
    public ActionResult CreateCarForm()
    {
      return View();
    }
  }
}