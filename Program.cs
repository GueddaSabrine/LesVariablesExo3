using System;

namespace LesVariablesExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            Console.WriteLine("Le nombre 1 est " + number1);
            int number2 = 5;
            Console.WriteLine("Le nombre 2 est " + number2);

            Console.WriteLine("Avec ajout du nombre 33 au nombre 1, le résultat est " + (33 + number1));

            Console.WriteLine("Avec incrémentation pour le nombre 2 le résultat est : " + ++number2);

            Console.WriteLine("Le resultat de la division avec les 2premiers nombres est " + (number1 / number2));


        }
    }
}
