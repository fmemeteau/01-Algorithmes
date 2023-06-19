using System.Security.Cryptography.X509Certificates;

namespace Exe_6_1_Les_Fruits_et_Légumes
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            string entry, fruit;
            double price;
            bool stop = false;
            string [] entrySplitted;
            
            var shop = new List<KeyValuePair<string, double>>();
            

            do
            {
                Console.WriteLine("Saisissez un fruit ou un légume ainsi que son prix au kilo (e.g. carottes 2,99).\nPour afficher les différents fruits et légumes ainsi que leur prix, taper 'go'.");
                entry = Console.ReadLine();


                if (entry.Equals("go"))
                {
                    stop = true;
                }

                else
                {
                    entrySplitted = entry.Split(" ");

                    fruit = entrySplitted[0];
                    price = double.Parse(entrySplitted[1]);
                   
                    shop.Add(new KeyValuePair<string, double>(fruit, price));
                }
                
            }
            while (stop == false);

            Console.WriteLine("Prix des fruits et légumes au kilo :\n");

            foreach (var items in shop)
            {
                Console.WriteLine(items);
            }
          
        }
    }
}