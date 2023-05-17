using System.Globalization;
using System.Linq;
using System.Net.Security;

namespace Exe_4_4_Tri_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[7] { 128, 64, 8, 512, 16, 32, 256 };

            /* int iMin = 0, permut;

             for(int i = 0; i < (table.Length); i++)
             {
                 for(int j = 0; j < i;j++)
                 {
                     if (table[i] < table[j])
                     {
                         permut = table[i];
                         table[i] = table[j];
                         table[j] = permut;

                     }
                 }
             }
             foreach(int value in table)
             {
                 Console.WriteLine(value);
             }*/




            /*
            //recherche du plus petit
            int iMin = 0;

            for (int j = 0; j < table.Length; j++)
            {
                if (table[j] < table[iMin])
                {
                    iMin = j;
                }

            } */
            //permutation
            int permut;

            

            for(int i = 0; i < table.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (table[i] < table[j])
                    {
                        permut = table[i];
                        table[i] = table[j];
                        table[j] = permut;
                    }

                }
            }
            
            foreach(int value in table)
            {
                Console.WriteLine(value);
            }

        }
    }
}