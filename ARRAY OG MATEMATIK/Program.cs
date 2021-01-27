using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_OG_MATEMATIK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listeB = new List<int>();

            


            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    listeB.Add(i);
                    
                }
            }


            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    listeB.Remove(i);

                }
            }


            List<int> listeC = new List<int>(listeB);

            listeC.Reverse();



            foreach (int number in listeB)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("den omvendte liste");

            foreach (int number in listeC)
            {
                Console.WriteLine(number);
            }



            Console.ReadKey();
        }
    }
}
