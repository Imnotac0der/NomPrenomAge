using System;

namespace NomPrenomAge
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclarations des variables
            string name = "silia";
            string firstname = "zeraoui";
            int age = 20;

            // affichage personnalisé
            Console.WriteLine("Bonjour " + name + " " + firstname + ", vous avez " + age + "ans. ");

            Console.ReadLine();

            // saisie du nom
            Console.Write("Entrez votre nom");
            name = string(Console.ReadLine());
        }
    }
}
