namespace Exe_3_3_Intervalle_Entre_2_Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;

            Console.WriteLine("Nous allons afficher l'intervalle entre deux nombres.");
            Console.WriteLine("Veuillez rentrer l'entier A");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez rentrer l'entier B");
            B = int.Parse(Console.ReadLine());

            if (A < B) 
            {
                while (A != B-1)
                {
                    A++;
                    Console.WriteLine(A);
                   

                }
            }
            else if (A > B)
            {
                while (A != B + 1)
                {
                    A--;
                    Console.WriteLine(A);
                }
            }
            else
            {
                Console.WriteLine("A (" + A + ") est égal à B (" + B + ") !");

            }
        }
    }
}