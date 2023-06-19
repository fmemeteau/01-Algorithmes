namespace Exe_5_3_Conversion_Fahrenheit_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string entry, unit;
            double temperature;
            bool numericOK = false;

            string [] tab;

            
                do
                {
                    Console.WriteLine("Nous allons convertir des températures de Celsius à Fahrenheit et inversement.");
                    Console.WriteLine("Entrez une valeur entre -459,67 et 5 000 000 ainsi que l'initiale de l'unité en majuscule allant avec, séparée par un espace (e.g. 37 C)");
                    entry = Console.ReadLine();

                    tab = entry.Split(' ');

                
                   numericOK = double.TryParse(tab[0], out temperature);
                              
                 }
                while (numericOK == false || temperature < -459.67 || temperature > 5000000) ;

                
                unit = tab[1];
                
                
                


                if (unit.Equals("C"))
                {
                    
                    Console.WriteLine("La température donnée en Celsius équivaut  à " + ((temperature * 9/5) + 32) + " Fahrenheit.");
                }
                else if (unit.Equals("F"))
                {
                    Console.WriteLine("La température donnée en Fahrenheit équivaut à " + ((temperature - 32) * 5 / 9) + " Celsius.");
                }
                else
                {
                    Console.WriteLine("C pour Celius ou F pour Fahrenheit s'il-vous-plaît !");
                }
          
                

            
            /* string answer;
            bool celsius = false, fahrenheit = false;

            Console.WriteLine("Saisissez une température suivie par l'initiale de l'unité choisie (ex : 37 C pour 37 degrés Celsius");
            answer = Console.ReadLine();

            if (answer[0] = "C")
            {

            }*/

        }
    }
}