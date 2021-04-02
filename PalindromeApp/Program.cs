using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromeApp
{
    public class Palindrome
    {
        private String chaineNormale;
        private String chaineOriginale;
        private String chaineInversee;
        /*
        public Palindrome(String Z) {
            this.chaineOriginale = Z;
        }
        */
        public Boolean verifierPalindrome(String chaine) {
            //Lower the string
            chaine = chaine.ToLower();

            //Removing special char from the string
            chaine = Regex.Replace(chaine, @"[^\w\.@-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));

            //Removing diacritics from the string
            chaine = Program.convertirChaineSansAccent(chaine);

            //Check if the string contains digits
            bool isDigitPresent = chaine.Any(c => char.IsDigit(c));
            if (isDigitPresent) return false;

            //String to array
            char[] charArray = chaine.ToCharArray();

            //Reverse the array
            Array.Reverse(charArray);

            return new string(charArray) == chaine;
        }
    }
    static class Program
    {
        // Exécution du Programme
        static void Main(string[] args) {
            String laChaine = "";
            Console.WriteLine("Saisissez une phrase :");
            laChaine = Console.ReadLine();
            Palindrome monPal = new Palindrome();
            if (monPal.verifierPalindrome(laChaine)) {
                Console.WriteLine("c'est un palindrome");
            } else {
                Console.WriteLine("ce n'est pas un palindrome");
            }
            Console.ReadKey();
        }

        static public string convertirChaineSansAccent(string chaine) {
            // Déclaration de variables
            string accent = "ÀÁÂÃÄÅàáâãäåÒÓÔÕÖØòóôõöøÈÉÊËèéêëÌÍÎÏìíîïÙÚÛÜùúûüÿÑñÇç";
            string sansAccent = "AAAAAAaaaaaaOOOOOOooooooEEEEeeeeIIIIiiiiUUUUuuuuyNnCc";

            // Conversion des chaines en tableaux de caractères
            char[] tableauSansAccent = sansAccent.ToCharArray();
            char[] tableauAccent = accent.ToCharArray();

            // Pour chaque accent
            for (int i = 0; i < accent.Length; i++) {
                // Remplacement de l'accent par son équivalent sans accent dans la chaîne de caractères
                chaine = chaine.Replace(tableauAccent[i].ToString(), tableauSansAccent[i].ToString());
            }

            // Retour du résultat
            return chaine;
        }
    }
}