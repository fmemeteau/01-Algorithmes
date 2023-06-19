using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Exe_Jeu_du_Pendu
{
    internal class Program
    {

        public static char[] CreateHiddenWord(string _WordToFind)
        {
            char[] hiddenWord = _WordToFind.ToCharArray();

            for (int i = 1; i < _WordToFind.Length - 1; i++)
            {
                hiddenWord[i] = '-';
            }

            return hiddenWord;
        }


        static void Main(string[] args)
        {
            string word;
            char[] hiddenWord;
            char letter;
            do
            {
                Console.Write("Saisissez un mot d'au moins 5 lettres\n");
                word = Console.ReadLine(); 
            }
            while (word.Length < 5);
            Console.Clear();
            word = word.ToLower();
            // Création du mot Caché : Premier for pour intégrer les -, Second for pour insérer word[0] et word[word.length-1]
            //  hiddenWord = new char[word.Length]; 
            /*for (int i = 1; i < word.Length - 1; i++)
            {
                hiddenWord[i] = '-';
            }

            hiddenWord[0] = word[0];
            hiddenWord[word.Length - 1] = word[word.Length - 1];*/
            hiddenWord = CreateHiddenWord(word);

           

            Console.WriteLine("Vous disposez de 6 essais pour trouver le mot en minuscules.");
            Console.WriteLine("Voici le mot à trouver :");
            /*foreach (char element in hiddenWord)
            {
                Console.Write(element + " ");
            }*/

            

            for (int tries = 5; tries > 0;tries--)
            {
                Console.WriteLine(hiddenWord);
                Console.WriteLine("Quelle lettre proposez-vous ?");
                letter = char.Parse(Console.ReadLine());

                for(int j = 0; j < hiddenWord.Length;j++)
                {
                    if (letter.Equals(word[j]))
                    {
                        hiddenWord[j] = letter;                        
                    }
                }

                Console.WriteLine("Il vous reste {0} essais", tries);
                
               
                                
            }

          

        
        }
        
    }
}