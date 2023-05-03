namespace Exe_3_6_2_Jeu_de_la_Fourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = rnd.Next(0, 100);
            int number;
            int counter = 0;
            int start = 0;
            int end = 100;

            do
            {
                Console.WriteLine("Proposez un nombre entier entre " + start + " et " + end + ".");
                number = int.Parse(Console.ReadLine());
                counter++;

                //Console.WriteLine(N);

                if(number < N)
                {
                    start = number;

                }
                else
                {
                    end = number;
                }


            }
            while (number != N);

            Console.WriteLine("Bravo, vous avez trouvé en " + counter + " essais!");
        }
    }
}