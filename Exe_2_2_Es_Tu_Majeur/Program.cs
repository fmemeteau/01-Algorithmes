namespace Exe_2_2_Es_Tu_Majeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;

            Console.WriteLine("Bonjour, quel âge avez-vous ?");
            A = int.Parse(Console.ReadLine());

            if (A >= 0)
            {
                if(A >= 18)
                {
                    Console.WriteLine("Vous êtes majeur !");
                }
                else
                {
                    Console.WriteLine("Vous êtes mineur !");
                }

            }
            else
            {
                Console.WriteLine("Vous n'êtes pas encore né !");
            }
        }
    }
}