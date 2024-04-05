using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_alg
{
        // Uppgift 1
    internal class Kombinera
    /*       
        Pseudokod:
    1,Initiera total längd som summan av längderna på de två inputarrayer.
    2,Skapa en ny array med denna totala längd.
    3,Kopiera över element från den första och den andra arrayen till den nya arrayen.
    4,Sortera den nya arrayen.
    5,Returnera den sorterade arrayen.
    */
    {       // O(n) linjär tidskomplexitet
        public static int[] KombineraArrayer(int[] arr1, int[] arr2)
        {
            
            int totalLängd = arr1.Length + arr2.Length;  

            // Skapande av en ny array är O(n) där n är summan av längderna på arr1 och arr2.
            int[] kombineradArray = new int[totalLängd];  // O(n) linjär tidskomplexitet

            // Kopiera arr1 till kombineradArray är O(n) där m är längden på arr1.
            Array.Copy(arr1, kombineradArray, arr1.Length);// O(n) linjär tidskomplexitet

            // Kopiera arr2 till kombineradArray, startar från slutet av arr1, är O(n) där k är längden på arr2.
            Array.Copy(arr2, 0, kombineradArray, arr1.Length, arr2.Length);// O(n) linjär tidskomplexitet

            // Sortering av den kombinerade arrayen är O(n log n) där n är totala antalet element i kombineradArray.
            Array.Sort(kombineradArray);   // O(n log n)
            return kombineradArray;
        }
    }
}
