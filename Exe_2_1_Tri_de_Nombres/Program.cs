namespace Exe_2_1_Tri_de_Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;

            int B;

            Console.WriteLine("Veuillez donner la valeur de l'entier A :");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez donner la valeur de l'entier B :");
            B = int.Parse(Console.ReadLine());


          
            if (A < B)
            {
                Console.WriteLine("A (" + A + ") < B (" + B + ").");
            }
            else if (A > B)
            {
               Console.WriteLine("B (" + B + ") < A (" + A + ").");
            }

            else 
            {
               Console.WriteLine("B (" + B + ") = A (" + A + ").");

            } 
        }
    }
}