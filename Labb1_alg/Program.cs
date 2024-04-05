using System;

namespace Labb1_alg
{
    internal class Program
    {
        /*  Först, låt oss kort introducera de två algoritmerna vi kommer att gå igenom.
        KombineraArrayer: Denna metod tar två heltalsarrayer som input, kombinerar dem till en array, och returnerar sedan denna sorterade kombinerade array.
        InnehallerDupliveringar: Den här metoden tar en array som input och returnerar true om arrayen innehåller några dubbletter, annars false.
        */

        /*
        Genom att följa de regler som presenteras för Stora Ordo-notation, har vi beräknat att KombineraArrayer har en tidskomplexitet på O(n log n) 
        och InnehallerDupliveringar har en tidskomplexitet på O(n). 
        Detta demonstrerar hur olika operationer och datastrukturer påverkar den totala beräkningskostnaden för algoritmer.
        */
        static void Main(string[] args)
        {

            //uppgift 3 test

            
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Innehåller dupliceringar (Första listan): {Dupliveringar.InnehallerDupliveringar(nums)} (false innebär inga dupliceringar)");
            
            Console.WriteLine();
            int[] talMedDupliceringar = { 1, 2, 3, 4, 4 };
            Console.WriteLine($"Innehåller dupliceringar (Andra listan): {Dupliveringar.InnehallerDupliveringar(talMedDupliceringar)} (true innebär att dupliceringar finns)");


            //Uppgift 1
            Console.WriteLine();
            Console.WriteLine();
            int[] arr1 = { 10,1, 3, 5,0 };
            int[] arr2 = { 2, 4, 6,0,4 };

            int[] kombineradArray = Kombinera.KombineraArrayer(arr1, arr2);
            Console.WriteLine("Kombinerad array: " + String.Join(", ", kombineradArray));
            
        }
    }
}