using System;
using System.Collections.Generic;
namespace Uppgift7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> countries = new Dictionary<string,int>();
            countries["sverige"] = 450;
            countries["norge"] = 385;
            countries["danmark"] = 43;
            countries["finland"] = 338;

            Console.WriteLine("Skriv in ett land:");
            string userCountry = Console.ReadLine();

            if (countries.ContainsKey(userCountry.ToLower())) 
            {
                Console.WriteLine($"Landet {userCountry.ToLower()} har en area på {countries[userCountry.ToLower()]}00000 km^2.");
            }
            else
            {
                Console.WriteLine("Det finns ingen information på det landet.");
            }
        }
    }
}
/*Tabellen nedan visar storleken av fyra länder mätt i enheten hundratusentals
kvadratkilometer.

Land Area (10^5
km^2)

Sverige 450

Norge 385
Danmark 43

Finland 338

Skapa ett program där användaren får skriva ett av dessa länders namn. Programmet
ska med hjälp av en Dictionary ange storleken på landet.*/