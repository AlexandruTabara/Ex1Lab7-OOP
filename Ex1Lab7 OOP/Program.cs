using System;

namespace Ex1Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //          In metoda Main, creati autoturisme si afisati - le descrierea
            //          Creati diagrama UML si salvati-o in git, alaturi de proiect

            Vehicle car1 = new Vehicle("Toyota", "Camry", 2019, 4)
            {
                Motor = new Motor { cylinderCapacity = 2.5, fuel = "Diesel", enginePower = 200 }
            };

            Vehicle car2 = new Vehicle("VW", "Golf", 2019, 4)
            {
                Motor = new Motor { cylinderCapacity = 1.4, fuel = "Gasoline", enginePower = 120 }
            };

            Console.WriteLine(car1.GetDescription());
            Console.WriteLine(car2.GetDescription());

            car1.StartCar();
            car2.StopCar();

            Console.WriteLine(Vehicle.nrMasini);

        }
    }
}
