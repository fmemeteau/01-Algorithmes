using System.Runtime.Intrinsics.X86;

namespace Exe_5_2_1_Conversion_Kilometres_Miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometers, miles;
            string entry;
            bool numericOk, testSortie = false;


            do
            {
                Console.WriteLine("Saisissez une valeur en kilomètres entre 0,01 et 1 000 000, elle sera convertie en miles.\nPour mettre fin au programme, saisissez q");
                entry = Console.ReadLine();

                numericOk = double.TryParse(entry, out kilometers);

                if (numericOk == true)
                {
                    if (kilometers >= 0.01 && kilometers <= 1000000)
                    {

                        miles = kilometers / 1.609;
                        Console.WriteLine("Cela fait {0:###,#.##} miles", miles);
                        testSortie = true;
                    }
                    else
                    {
                        Console.WriteLine("Valeur hors limite.");
                    }
                  

                   
                }
                else
                {
                    if (entry.Length == 1 && entry[0].Equals('q') )
                    { 


                        testSortie = true; 
                    }
                    else
                    {
                        Console.WriteLine("Saisissez un nombre !");
                    }


                }
            }
            while (testSortie == false );

               //&& kilometers >= 0.01 && kilometers <= 1000000

                //kilometers = float.Parse(entry);

            // (stopInput = false || kilometers < 0.01 || kilometers > 1000000);

            Console.WriteLine("Sortie de boucle");
           
            
        }
    }
}