using System.Globalization;

namespace Exe_4_5_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text, textToTest;
            
            do
            {
                Console.WriteLine("Saisissez un palindrome et finissez par un point.");
                text = Console.ReadLine();
            }
            while (text.Length == 0 || text.Length < 2 && text.EndsWith('.') || text.Last() != '.');

           
            textToTest = text.Remove(text.Length - 1);
            textToTest = textToTest.ToLower();
            textToTest = textToTest.Replace(" ", "");
            Console.WriteLine(textToTest);
            //Console.WriteLine("Votre texte sans le . final : {0}", text);
            bool palindrome = true;
            int i = 0, j = textToTest.Length -1;

            while(palindrome && i < textToTest.Length/2)
            {
                if (textToTest[i] != textToTest[j])
                {
                    palindrome = false;
                }
                i++;
                j--;
            }
            
            
            if (palindrome)
               {
                   Console.WriteLine("le texte '{0}' est un palindrome !", text);
               }
               else
               {
                   Console.WriteLine("Le texte '{0}' n'est pas un palindrome.", text);
               }
        }

    }
    
}