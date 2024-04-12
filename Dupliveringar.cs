using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_alg
{
    internal class Dupliveringar
    {
        /*  
                  Pseudokod:

       FUNCTION InnehallerDupliveringar(nums)
           CREATE a HashSet named list

           FOR EACH num IN nums
               IF num is NOT ADDED to list
                   RETURN true // Duplicering hittad
               END IF
       END FOR EACH

           RETURN false // Inga dupliceringar hittades
       END FUNCTION

        Implementering och Tidskomplexitet:

        HashSet Operationer: 
        Varje insättning och kontroll i HashSetet är i genomsnitt O(1). 
        Loop genom alla n element resulterar i en total tidskomplexitet på O(n),
        där n är antalet element i inputarrayen.


        // O(n) linjär tidskomplexitet        */
        //uppgift 3 test
        public static bool InnehallerDupliveringar(int[] nums)
        {
            HashSet<int> list = new HashSet<int>();  

            foreach (int num in nums)    
            {
                if (!list.Add(num))   
                {
                    // Om elementet redan finns, returnera true (duplicering hittad)
                    return true; 
                }
            }
            // Om vi når hit betyder det att inga dupliceringar hittades
            return false;   


        }
    }
}
