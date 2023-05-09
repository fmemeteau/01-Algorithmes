using System.Diagnostics;

namespace Exe_4_3_Dénombrer_les_Lettres_de_l_ALphabet_dans_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "The C sharp programming language was designed by Anders Hejlsberg from Microsoft and was later approved as an international standard by ECMA."; 
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
          
       

            //Console.WriteLine(text.Length);
            text = text.ToLower();
        
           for(int i = 0; i < alphabet.Length; i++)
            {
                int occurrences = 0;
                //foreach (char letter in text)
                for (int j = 0; j < text.Length;j++)
                {
                    if (alphabet[i] == text[j])
                    {
                        occurrences++;
                    }
                }

                Console.WriteLine("La lettre {0} apparaît {1} fois dans le texte.", alphabet[i], occurrences);
            }


        }
    }
}