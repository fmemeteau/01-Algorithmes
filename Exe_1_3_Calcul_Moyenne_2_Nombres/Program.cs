namespace Exe_1_3_Calcul_Moyenne_2_Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre1;

            int nombre2;

            double moyenne;

            Console.WriteLine("Bonjour, veuillez saisir un premier nombre :");
            nombre1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Bonjour, veuillez saisir un second nombre :");
            nombre2 = int.Parse(Console.ReadLine());

            moyenne = (nombre1 + nombre2) / 2d;

            Console.WriteLine("La moyenne de " + nombre1 + " et " + nombre2 + " est " + moyenne + ".");
            Console.ReadLine();

        }
    }
}