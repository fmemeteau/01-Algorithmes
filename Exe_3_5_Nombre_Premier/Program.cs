namespace Exe_3_5_Nombre_Premier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToTest, division, i = 2;

            Console.WriteLine("Saisissez un nombre à vérifier :");
            numberToTest = int.Parse(Console.ReadLine());

            do
            {
                division = numberToTest%i;
                i++;
            }
            while (division != 0 && i < numberToTest);

            Console.WriteLine("Le premier diviseur est " + i);

            if(numberToTest != i)
            {
                Console.WriteLine("{0} n'est pas un Nombre Premier !", numberToTest);
            }
            else
            {
                Console.WriteLine("{0} est Nombre Premier !", numberToTest);
            }



        }
    }
}