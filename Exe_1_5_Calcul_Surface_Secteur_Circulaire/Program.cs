namespace Exe_1_5_Calcul_Surface_Secteur_Circulaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon;

            double angle;

            //double aire;

            Console.Write("Veuillez donner le rayon du cercle.");
            rayon = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez donner l'angle à l'intérieur du cercle");
            angle = double.Parse(Console.ReadLine());

            //aire = (Math.PI * Math.Pow(rayon, 2) * angle) / 360d;

            //Console.WriteLine("La valeur de l'aire est de " + aire + " cm³.");
            Console.WriteLine("La valeur de l'aire est de " + (Math.PI * Math.Pow(rayon, 2) * angle) / 360d + " cm³.");

            Console.ReadLine();
        }
    }
}