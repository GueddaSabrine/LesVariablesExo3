using System;

namespace LesVariablesExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un premier nombre : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez un second nombre  : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            number2++;
            float sum = number1 + 33;
            float division;
            division = sum/number2;

            Console.WriteLine($"Aprés ajout +33 le nombre est {sum}");
            Console.WriteLine($"Aprés incrémentation le nombre est {number2}");
            Console.WriteLine("Le resultat de la division avec les 2premiers nombres est " + division);

            //Créer deux variables de type entier. Via la console, demander à l’utilisateur de renseigner ces nombres à l’aide 
            //de 2 phrases distinctes. Rajouter 33 au premier nombre, 
            //et incrémenter de 1 le deuxième nombre. Effectuer la division du premier nombre par le deuxième nombre. Afficher le résultat dans la console, dans une phrase.

        }
    }
}
