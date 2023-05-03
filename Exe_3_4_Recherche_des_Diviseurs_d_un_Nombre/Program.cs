namespace Exe_3_4_Recherche_des_Diviseurs_d_un_Nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i;
            

            Console.WriteLine("Nous allons afficher l'ensemble des diviseurs d'un nombre entier autres que 1 et lui-même");
            Console.WriteLine("Veuillez rentrer un nombre entier");
            N = int.Parse(Console.ReadLine());

            for (i = 1; i < N; i++)
            {
                
                if(N % i == 0 && i !=1)
                {
                    Console.WriteLine(i);

                }

            } 

            
        }
    }
}