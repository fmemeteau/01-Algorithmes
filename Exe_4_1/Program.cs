namespace Exe_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int N, i;
           // var value;

            Random rnd = new Random();

            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100);
            int c = rnd.Next(0, 100);
            int d = rnd.Next(0, 100);
            int e = rnd.Next(0, 100);
            int f = rnd.Next(0, 100);
            int g = rnd.Next(0, 100);
            int h = rnd.Next(0, 100);
            int j = rnd.Next(0, 100);
            int k = rnd.Next(0, 100);

            array = new int[]{a, b, c, d, e, f, g, h, j, k};
           

            foreach(var value in array)
            {
                Console.WriteLine(value);
            }

            // Afficher les valeurs du tableau en vue de tests
            Console.WriteLine("Saisissez un nombre entier entre 0 et 100:");
            N = int.Parse(Console.ReadLine());

            // Recherche de l'input de l'utilisateur dans le tableau
            if(N <= 100)
            {

                if (array.Contains(N))
                {
                    Console.WriteLine("{0} se trouve dans le tableau !", N);
                }
                else
                {
                    Console.WriteLine("{0} ne se trouve pas dans le tableau !", N);
                }
            }
            else
            {
                Console.WriteLine("Valeur entre 0 et 100 !");
            }


        
        }
    }
}