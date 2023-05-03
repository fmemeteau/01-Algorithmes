namespace Exe_1_6_Inversion_de_2_Valeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;

            int B;

            int C;
            
            Console.WriteLine("Veuillez donner la valeur de l'entier A :");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez donner la valeur de l'entier B :");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("La valeur de A est " + A + " et celle de B est " + B + ".");

            C = A;

            A = B;

            B = C;

            Console.WriteLine("Après inversion des valeurs, celle de A est " + A + " et celle de B est " + B + ".");

            Console.ReadLine();         
            

        }
    }
}