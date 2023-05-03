namespace Exe_3_1_Contrôler_la_Saisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string question = "Bonjour, quel est votre prénom ?";

            do
            {
                Console.WriteLine(question);
                firstName = Console.ReadLine();
            }

            while (firstName.Length < 2);
            
            Console.WriteLine("Bonjour, " + firstName + " !"); 
        }

        
    }
}