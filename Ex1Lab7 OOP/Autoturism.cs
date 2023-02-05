using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab7
{
    //            • Un autoturism detine un motor precum si un numar de usi.De asemenea autovehiculul este caracterizat de
    //            marca, model si an de fabricatie
    //          • Autoturismul va avea urmatoarele metode / proprietati
    //             GetDescription
    //             Va returna descrierea completa a autovehicolului sub forma unui sir de caractere
    //                 “Marca, model, anDeFabricatie,capacitate cilindrica, combustibil,putere motor, numar de usi
    public class Vehicle
    {
        public string manufacturer { get; set; }
        public string model { get; set; }
        public int yearOfManufacture { get; set; }
        public int numberOfDoors { get; set; }
        public Motor Motor { get; set; }

        public static int nrMasini = 0;

        public Vehicle(string manufacturer, string model, int yearOfManufacture, int numberOfDoors)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.yearOfManufacture = yearOfManufacture;
            this.numberOfDoors = numberOfDoors;
            Vehicle.nrMasini++;
        }
        public string GetDescription()
        {
            return $"Manufacturer: {manufacturer}, Model: {model}, Year of Manufacture: {yearOfManufacture}, " +
                   $"Cylinder Capacity: {Motor.cylinderCapacity}, Fuel: {Motor.fuel}, " +
                   $"Engine Power: {Motor.enginePower}, Number of Doors: {numberOfDoors}";
        }

        //Deschide: La apelul acestei metode usa va afisa in consola “click”
        public void OpenDoor()
        {
            Console.WriteLine("click");
        }

        // Inchide: La apelul acestei metode usa va afisa in consola “clack”
        public void CloseDoor()
        {
            Console.WriteLine("clack");
        }

        // Pornirea motorului la apelul acestei functii motorul va afisa in consola “brr”
        public void StartCar()
        {
            Console.WriteLine("Masina porneste");
            Motor.EngineStart();
            OpenDoor();
        }

        // Oprire a motorului la apelul acestei functii motorul va afisa in consola “par poc pac”
        public void StopCar()
        {
            Console.WriteLine("Opreste masina");
            Motor.EngineStop();
            CloseDoor();
        }

        // Clasa autoturism va detine o metoda prin care va fi calculat numarul total de autoturisme create
        public static int GetNumarMasini()
        {
            return Vehicle.nrMasini;
        }
    }
}

