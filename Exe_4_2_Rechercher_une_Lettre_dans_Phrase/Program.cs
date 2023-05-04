namespace Exe_4_2_Rechercher_une_Lettre_dans_Phrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence, sentenceLowered;
            char letterToSearch;
            int letterOccurrences = 0;

            Console.WriteLine("Saisissez une phrase se terminant par un '.'");
            sentence = Console.ReadLine();

            if (sentence.EndsWith("."))
            {
                sentenceLowered = sentence.ToLower();

                if (sentence.Length == 0 || (sentence.Length == 1 && sentence.Contains(".")))
                {
                    Console.WriteLine("LA CHAINE EST VIDE");
                }
                else
                {
                    Console.WriteLine("Saisissez une lettre à rechercher :");
                    letterToSearch = char.Parse(Console.ReadLine());


                    if (sentenceLowered.Contains(letterToSearch))
                    {
                        foreach (char letter in sentenceLowered)
                        {
                            if (letter == letterToSearch)
                            {
                                letterOccurrences++;
                            }
                        }
                        Console.WriteLine("La phrase '{0}' contient {1} fois la lettre {2}", sentence, letterOccurrences, letterToSearch);
                    }
                    else
                    {
                        Console.WriteLine("La lettre {0} n'est pas présente !", letterToSearch);
                    }
                }
            }
            else
            {
                Console.WriteLine("Votre phrase ne finit pas par un '.'");
            }


        }
    }
}