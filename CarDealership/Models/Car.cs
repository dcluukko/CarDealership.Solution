using System.Collections.Generic;

namespace Cars.Models
{
  public class Car
  {
    public string MakeModel;
    public string Color;
    public int Price;
    public int Miles;
    public static List<Car> CarItems = new List<Car>() {};

   public Car(string makeModel, string color, int price, int miles)
    {
      MakeModel = makeModel;
      Color = color;
      Price = price;
      Miles = miles;
      CarItems.Add(this);
    } 
  }
}