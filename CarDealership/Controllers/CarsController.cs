using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cars.Models;

namespace Cars.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/DisplayIndex")]
    public ActionResult DisplayIndex()
    {
      List<Car> newList = Car.CarItems;
      return View(newList);
    }

    [HttpGet("/CreateCarForm/new")]
    public ActionResult CreateCarForm()
    {
      return View();
    }

    [HttpPost("/CreateCarForm")]
    public ActionResult Create(string makeModel, string color, int price, int miles)
    {
      Car newCar = new Car(makeModel, color, price, miles);
      return RedirectToAction("DisplayCars");
    }


  }
}