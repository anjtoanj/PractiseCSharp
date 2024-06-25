// Create a C# program that implements an IVehiculo interface with two methods,
//  one for Drive of type void and another for Refuel of type bool that has a 
//  parameter of type integer with the amount of gasoline to refuel. 
//  Then create a Car class with a builder that receives a parameter with the car's
//   starting gasoline amount and implements the Drive and Refuel methods of the car.

// The Drive method will print on the screen that the car is Driving, 
//if the gasoline is greater than 0. 
// The Refuel method will increase the gasoline of the car and return true.

// To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program 
// and ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car


// Input
// 50

// Output
// Driving

using System;
public class FirstInterface
{
     public static void Main(string[] args)
     {
            Car car = new Car(0);
            Console.WriteLine("Please enter the amount of gasoline to refuel. ");
            int Fuel = int.Parse(Console.ReadLine());
            if(car.Refuel(fuel))
            {
                car.Drive();
            }
     }   
     public interface IVehiculo
        {
            void Drive();   
            bool Refuel(int amt);            
        }

    class Car : IVehiculo
        {
            public int Fuel { get; set; }
            public void Car(int fuel)
            {
                Fuel = fuel;
            }
            public bool Refuel (int amt)
            {
                Fuel+ = amt;
                return true;
            }
            public void Drive()
            {
                if (Fuel >0)
                {
                    Console.WriteLine("Driving");
                }
                else{
                    Console.WriteLine("Not Fuel");
                }
        }
    }
}    