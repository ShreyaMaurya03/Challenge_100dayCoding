using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions.OOPs
{
    // Create a class Car with properties like Model, Color, and a method Drive().
    public class Classes
    {
        public void TestCar() { 
            Car car = new Car();
            car.Model = "BMW";
            car.Color = "Black";
            car.Drive();
    }
    }
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }
}
