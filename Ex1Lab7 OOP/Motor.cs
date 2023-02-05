using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab7
{
    public class Motor
    {
        //          • Motorul
        //              este caracterizat de
        //              Capacitate cilindrica
        //              Putere
        //              Tipul combustibilului
        public double cylinderCapacity { get; set; }
        public string fuel { get; set; }
        public int enginePower { get; set; }

        // Porneste masina Va afisa textul “masina porneste” , va inchide usile si va porni motorul
        public void EngineStart()
        {
            Console.WriteLine("brr");
        }

        // Opreste masina Va afisa textul “masina se opreste”, va opri motorul si va inchide usile
        public void EngineStop()
        {
            Console.WriteLine("par poc pac");
        }
    }
}