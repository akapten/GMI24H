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
    FUNCTION KombineraOchSorteraArrayer(arr1, arr2)
        SET totalLängd TO arr1.LENGTH + arr2.LENGTH
        CREATE an array kombineradArray OF LENGTH totalLängd

        COPY elements of arr1 to kombineradArray
        COPY elements of arr2 to kombineradArray starting at position arr1.LENGTH

        CALL Insättningssortering(kombineradArray)

        RETURN kombineradArray
      END FUNCTION

    FUNCTION Insättningssortering(array)
        FOR i FROM 1 TO array.LENGTH - 1
            SET current TO array[i]
            SET j TO i - 1

        WHILE j >= 0 AND array[j] > current
            SET array[j + 1] TO array[j]
            DECREMENT j
        END WHILE

        SET array[j + 1] TO current
      END FOR
    END FUNCTION


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
            Insättningssortering(kombineradArray);   // O(n log n)
            return kombineradArray;
            
        }
        private static void Insättningssortering(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i - 1;

                // Flytta element som är större än current till en position upp i arrayen
                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
        }
    }
}
