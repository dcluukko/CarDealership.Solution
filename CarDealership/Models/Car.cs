using System.Collections.Generic;

namespace Cars.Models
{
  public class Car
  {
    public string MakeModel {get; set;}
    public string Color {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}
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