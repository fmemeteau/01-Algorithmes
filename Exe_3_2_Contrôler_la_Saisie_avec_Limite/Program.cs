using Microsoft.VisualBasic;

namespace Exe_3_2_Contrôler_la_Saisie_avec_Limite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            int i = 0;

            do
            {
                i++;

                Console.WriteLine("Veuillez saisir votre mot de passe");
                password = Console.ReadLine();

            }
            while(i < 3 && password != "formation");

            if(i == 3)
            {
                Console.WriteLine("Votre compte est bloqué");
            }
            else
            {
                Console.WriteLine("Bravo, vous êtes connecté !");
            }
            
        }
    }
}