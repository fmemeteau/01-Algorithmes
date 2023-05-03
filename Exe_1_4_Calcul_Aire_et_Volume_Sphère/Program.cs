namespace Exe_1_4_Calcul_Aire_et_Volume_Sphère
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon;
            
            double aire;

            double volume;

            Console.WriteLine("Veuillez donner le rayon de la sphère en cm");
            rayon = double.Parse(Console.ReadLine());

            aire = 4 * Math.PI * Math.Pow(rayon, 2);
            volume = 4 / 3d * Math.PI * Math.Pow(rayon, 3);
            
            Console.WriteLine("L'aire de la sphère est " + aire + "cm² et son volume est " + volume + " cm³.");

            Console.ReadLine();

        }
    }
}