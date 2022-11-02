using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ÖvningQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient Arne = new Patient("Arne", 72, 'M', 1001, "2022-11-02");
            Patient Eva = new Patient("Eva", 64, 'F', 1002, "2022-10-08");
            Patient Håkan = new Patient("Håkan", 25, 'M', 1003, "2022-11-01");
            Håkan.HasCovid = true;

            Läkare mugg = new Läkare("Jane", 25, 'M',2001, 6500, 8);


            Queue<Patient> patientlist = new Queue<Patient>();
            patientlist.Enqueue(Arne);
            patientlist.Enqueue(Eva);
            patientlist.Enqueue(Håkan);
            Console.WriteLine($"Personer i kö just nu: {patientlist.Count}\n");
            foreach (Patient person in patientlist)
            {
                Console.WriteLine($"Name: {person.Name} Age: {person.Age} Id: {person.Id} Checkin Time: {person.CheckInTime} Has Covid: {person.HasCovid}");
            }
            foreach (Patient patient in patientlist)
            {
                if (patient.HasCovid)
                {
                    Console.WriteLine("Patienten kan inte vaccineras på grunv av pågående infektion");
                    Console.WriteLine("Personen har lämnat kön.\n");
                    patientlist.Dequeue();
                }
                else
                {
                    Console.WriteLine($"{patient.Name} är nu vaccinerad och har lämnat kön.");
                    patientlist.Dequeue();
                }

                Console.ReadKey();
            }
        }
    }
}
