using System.Runtime.Intrinsics.X86;

namespace Exe_5_2_1_Conversion_Kilometres_Miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometers, miles,distance ;
            string entry;
            bool numericOk, testSortie = false, distanceChoice = false;


            do
            {
                Console.WriteLine("Saisissez une valeur de distance entre 0,01 et 1 000 000.\nPour mettre fin au programme, saisissez q");
                entry = Console.ReadLine();

                numericOk = double.TryParse(entry, out distance);

                if (numericOk == true)
                {
                    if (distance >= 0.01 && distance <= 1000000)
                    {
                        do
                        {
                            string choice;
                            Console.WriteLine("Souhaitez-vous une valeur finale en kilomètres (saisir 'km') ou en miles (saisir 'mi') :");
                            choice = Console.ReadLine();

                            if (choice == "km")
                            {
                                kilometers = distance * 1.609;
                                Console.WriteLine("Cela fait {0:###.##} kilomètres", kilometers);
                                distanceChoice = true;
                                testSortie = true;
                        }
                            else if (choice == "mi")
                            {
                                miles = distance / 1.609;
                                Console.WriteLine("Cela fait {0:###.##} miles", miles);
                                distanceChoice = true;
                                testSortie = true;
                            }
                            else
                            {
                                Console.WriteLine("'km' ou 'mi' s'il-vous-plaît !\n");
                            }
                        }
                        while (distanceChoice == false);

                                            }
                    else
                    {
                        Console.WriteLine("Valeur hors limite.\n");
                    }
                }
                else
                {
                    if (entry.Length == 1 && entry[0].Equals('q'))
                    {


                        testSortie = true;
                    }
                    else
                    {
                        Console.WriteLine("Saisissez un nombre !\n");
                    }
                }
            }
            while (testSortie == false);
        }
    }
}