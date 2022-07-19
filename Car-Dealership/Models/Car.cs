using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Description { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string description)
    {
      Description = description;
      _instances.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

//   public class Car
//   {
//     private string _makeModel;
//     private int _price;
//     private int _miles;

//     public Car(string makeModel, int price, int miles)
//     {
//       _makeModel = makeModel;
//       _price = price;
//       _miles = miles;
//     }

//     public string GetMakeModel()
//     {
//       return _makeModel;
//     }

//     public int GetPrice()
//     {
//       return _price;
//     }

//     public int GetMiles()
//     {
//       return _miles;
//     }

//     public void SetPrice(int newPrice)
//     {
//       _price = newPrice;
//     }

//     public bool WorthBuying(int maxPrice)
//     {
//       return (_price <= maxPrice);
//     }
//       public static string MakeSound(string sound)
//     {
//       return "Our cars sound like " + sound;
//     }
//   }
