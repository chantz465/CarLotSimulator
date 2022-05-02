using System;

namespace Exercise1
{
    public class Car
    { 
        public int Year { get; set; }
        public string Make { get; set; }

        public string model { get; set; }

        public void CarOut(int yearMade, string madeBy, string modelOf)
        {
            Console.WriteLine($"My car is a {yearMade} {madeBy} {modelOf} and I love it!");
        
        }
    
    
    
    
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Year = 2005;
            car.Make = "Bmw";
            car.model = "F650gs";

            car.CarOut(2005,"bmw","f650gs");


        }
    }
}
