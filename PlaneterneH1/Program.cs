using System;
using System.Collections.Generic;

namespace PlaneterneH1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2 - Opret en liste og tilføj planeter
            List<Planet> planets = new List<Planet>();
            //tilføjer og instantierer planeterne
            planets.Add(new Planet("Merkur", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "No"));
            planets.Add(new Planet("Jorden", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, "No"));
            planets.Add(new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, "No"));
            planets.Add(new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, "No"));
            planets.Add(new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, "No"));
            planets.Add(new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, "Yes"));
            planets.Add(new Planet("Neptun", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, "Yes"));
            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, "No"));

            //Opgave 3 - Udskriv listen vhja Foreach løkken

            UdskrivAll(planets);//Metodekald


            Console.WriteLine();

            //Opgave 4 - Tilføj Venus efter Merkur og inden Jorden

            planets.Insert(1, (new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, "No")));

            //Opgave 5 - Udskriv listen og tjek at Venus ligger det rigtige sted

            UdskrivAll(planets);//Metodekald


            Console.WriteLine();

            //Opgave 6 - Slet Pluto

            int length = planets.Count; //tæller hvor mange elementer der er i listen, så man ved hvor mange gange forløkken skal køre
            int pladsNummer = 0; //Erklærer en variabel der skal bruges til at finde indexnummeret
            // Opretter for løkke til at køre listen igennem 
            for (int i = 0; i < length; i++)
            {

                if (planets[i].Name == "Pluto") //Laver en betingelse
                {
                    pladsNummer = i;
                }

            }
            planets.RemoveAt(pladsNummer); //sletter elementet på det index plads fundet i løkken
            Console.WriteLine();

            //Opgave 7 - Udskriv listen og tjek at Pluto er slettet
            Console.ForegroundColor = ConsoleColor.Green;//Ændre farve på teksten
            Console.WriteLine("Uden Pluto:");
            Console.ForegroundColor = ConsoleColor.White;

            Udskriv(planets);//Metodekald

            Console.WriteLine();

            //Opgave 8 - Indsæt Pluto igen
            //Behøver ikke definere en indexplads da Pluto er den sidste planet i rækkefølgen

            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, "No"));
            Console.ForegroundColor = ConsoleColor.Green;//Ændre farve på teksten
            Console.WriteLine("Pluto tilbage:");
            Console.ForegroundColor = ConsoleColor.White;
            Udskriv(planets);//Metodekald for at tjekke


            Console.WriteLine();

            //Opgave 9 - Tæl antallet af elemeter i listen
            Console.ForegroundColor = ConsoleColor.Green;//Ændre farve på teksten
            Console.WriteLine("Antal af elementer i listen:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(planets.Count); //tæller og udskriver hvor mange elementer der er i listen

            Console.WriteLine();

            //Opgave 10 - opret ny liste med planeter med mean temp under 0 og udskriv listen

            List<Planet> tempMinus = new List<Planet>();//opretter listen

            //Laver en forløkke til at køre listen med alle planeterne igennem og finde dem der opfylder betingelsen
            for (int i = 0; i < length; i++)
            {

                if (planets[i].MeanTemp < 0) //Her opstilles betingelsen
                {
                    tempMinus.Add(planets[i]);//Når betingelsen er opfyldt skal elemente´t tilføjes den nye liste
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;//Ændre farve på teksten
            Console.WriteLine("Planeter med en mean temperature under 0 grader:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Planet planet in tempMinus)
            {
                Console.WriteLine($"{planet.Name,8}: Mean Temperature (c) {planet.MeanTemp,3}");// udskriver listen for at tjekke- dog kun navnet
            }

            Console.WriteLine();

            //Opgave 11 - opret en ny liste og tilføj de planeter med en diameter over 10000 men under 50000 km

            List<Planet> diameterBig = new List<Planet>(); //Opretter en ny liste

            //Bruger en forløkke til at køre listen igennem og finde dem der opfylder betingelsen
            for (int i = 0; i < length; i++)
            {
                /*tjekker diameteren på planeterne i listen med alle planeterne, hvis diameteren opfylder betingelsen 
                 * skal den pågældende planet sættes ind i den nye liste.                                                                                               * skal den pågældende planet sættes ind i den nye liste*/
                if (planets[i].Diameter > 10000 && planets[i].Diameter < 50000)
                {
                    diameterBig.Add(planets[i]);//tilføjer elementet til den nye liste
                }
            }
            //Udskriver for at tjekke
            Console.ForegroundColor = ConsoleColor.Green;//Ændre farve på teksten
            Console.WriteLine("Planeter med en diameter (km) over 10000 km men under 50000 km:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Planet planet in diameterBig)
            {
                Console.WriteLine($"{planet.Name,8}: Diameter (km) {planet.Diameter,3}");// udskriver listen for at tjekke- dog kun navnet
            }

            //Opgave 12 - Fjern alle planeterne

            planets.Clear();//Sletter alle planeter fra listen "planets"
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;//Ændre farve på teksten
            Console.WriteLine("Planeterne slettes fra listen:");
            Console.ForegroundColor = ConsoleColor.White;
            Udskriv(planets);

            Console.ReadKey();
        }
        //Opretter medtode til at udskrive en liste til konsollen
        public static void UdskrivAll(List<Planet> navn)
        {
            string elementListe = "  Name       Mass    Diam      Dens     Grav   Rot.Per  L.O.Day   Dist   Orb.Per  Orb.Vel  MeanTemp NumMoon  Ring Sys";
            Console.ForegroundColor = ConsoleColor.Green;//Ændre farve på teksten
            Console.WriteLine(elementListe);
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Planet planet in navn)// udskriver listen
            {


                Console.WriteLine($"{planet.Name,8} {planet.Mass,8} {planet.Diameter,8} {planet.Density,8} {planet.Gravity,8} " +
                    $"{planet.RotationPeriod,8} {planet.LengthOfDay,8} {planet.DistanceFromSun,8} {planet.OrbitalPeriod,8} {planet.OrbitalVelocity,8} " +
                    $"{planet.MeanTemp,8} {planet.RingSystem,8} {planet.NumberOfMoons,8}");
            }
        }
        public static void Udskriv(List<Planet> navn)
        {
            foreach (Planet planet in navn)
            {
                Console.WriteLine(planet.Name);// udskriver listen for at tjekke- dog kun navnet
            }
        }
    }
}