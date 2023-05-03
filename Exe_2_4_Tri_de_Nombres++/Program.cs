namespace Exe_2_4_Tri_de_Nombres__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;

            int B;

            int C;

            Console.WriteLine("Bonjour, veuillez donner la valeur de A :");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Bonjour, veuillez donner la valeur de B :");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Bonjour, veuillez donner la valeur de C :");
            C = int.Parse(Console.ReadLine());

            if(A < B & A < C)
            {
                if(B < C)
                {
                    Console.WriteLine(A + " < " + B + " < " + C);
                }
                
                else
                {
                    Console.WriteLine(A + " < " + C + " < " + B);
                }

            }
            
            else if(B < A & B <C)
            {
                if(A < C)
                {
                    Console.WriteLine(B + " < " + A + " < " + C);
                }
                else
                {
                    Console.WriteLine(B + " < " + C + " < " + A);
                }

            }

            else  // C < A & C < B
            {
                if(A < B)
                {
                    Console.WriteLine(C + " < " + A + " < " + B);
                }
                else
                {
                    Console.WriteLine(C + " < " + B + " < " + A);
                }

            }

        
        }
    }
}