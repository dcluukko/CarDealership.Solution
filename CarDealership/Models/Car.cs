using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel;
    public string Color;
    public int Price;
    public int Miles;
    private static List<Car> _cars = new List<Car>() {};

   public Car(string makeModel, string color, int price, int miles)
    {
      MakeModel = makeModel;
      Color = color;
      Price = price;
      Miles = miles;
      _cars.Add(this);
    }
    
     public static List<Car> GetAll()
     {
       return _cars;
     }

     public static void ClearAll()
     {
       _cars.Clear();
     }
  }
}