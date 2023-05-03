namespace Exe_2_5_Ma_Bicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string beauTemps;
            string bicycletteFonctionnelle;
            string bicycletteReparable;
            string balade = "J'irai me balader en bicyclette !";
            string gotMaison;
            string gotBibliotheque; 

            Console.WriteLine("Fera-t-il beau demain ?");
            beauTemps = Console.ReadLine();

            if(beauTemps == "oui")
            {
                Console.WriteLine("La bicyclette fonctionne-t-elle ?");
                bicycletteFonctionnelle = Console.ReadLine();

                if(bicycletteFonctionnelle == "oui")
                {
                    //Console.WriteLine("J'irai me balader en bicyclette !");
                    Console.WriteLine(balade);

                }
                else
                {
                    Console.WriteLine("Je dois l'emmener chez le garagiste. La réparation sera-t-elle immédiate ?");
                    bicycletteReparable = Console.ReadLine();

                    if(bicycletteReparable == "oui")
                    {
                        //Console.WriteLine("J'irai me balader en bicyclette !");
                        Console.WriteLine(balade);
                    }
                    else
                    {
                        Console.WriteLine("J'irai tout de même me balader à pied !");
                    }

                }

            }
            else
            {
                Console.WriteLine("Je vais rester chez moi lire. Le livre Game of Thrones se trouve-t-il dans ma bibliothèque ?");
                gotMaison = Console.ReadLine();
                
                if(gotMaison == "oui")
                {
                    Console.WriteLine("Je vais lire GoT dans un fauteuil !");
                }
                else
                {
                    Console.WriteLine("Je vais aller emprunter GoT à la bibliothèque. Est-il disponible ?");
                    gotBibliotheque = Console.ReadLine();

                    if(gotBibliotheque == "oui")
                    {
                        Console.WriteLine("J'emprunte GoT et je rentre chez moi le lire dans un fauteuil !");
                    }
                    else
                    {
                        Console.WriteLine("Alors j'emprunte un roman policier et je rentre chez moi le lire dans un fauteuil !");
                    }
                
                
                }

                

            }
            
            
            
        }
    }
}