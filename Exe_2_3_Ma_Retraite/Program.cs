namespace Exe_2_3_Ma_Retraite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;

            int Retraite = 60;

            Console.WriteLine("Bonjour, quel âge avez-vous ?");
            A = int.Parse(Console.ReadLine());


            if (A >= 0)
            {
                if (A > Retraite)
                {
                    Console.WriteLine("Vous êtes à la retraite depuis " + (A - Retraite) + " ans !");
                }
                else if (A < Retraite)
                {
                    Console.WriteLine("Il vous reste " + (Retraite - A) + " ans avant la retraite !");
                }
                else
                {
                    Console.WriteLine("C'est le moment de prendre votre retraite !");
                }
            }

            else
            {
                Console.WriteLine("La valeur fournie n'est pas un âge valide !");
            }
            
        }
    }
}