using System;

namespace LesConditionsExo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //À l’aide de la console, inviter l’utilisateur à renseigner un mois parmi les 12 mois de disponibles.
            //Dans la console, selon le mois renseigné, afficher un des messages suivants :
            //« La saison du mois saisi est le PRINTEMPS. »
            //« La saison du mois saisi est l'ÉTÉ. »
            //« La saison du mois saisi est l'AUTOMNE. »
            //« La saison du mois saisi est l'HIVER. »

            //int month = 1;
            Console.WriteLine("Entrez le numéro du mois : ");
            int month =Convert.ToInt32(Console.ReadLine());
            //string month = Console.ReadLine(); (with letter)

            switch (month)
            {
                case 1:
                    Console.WriteLine("La saison du mois saisi est l'HIVER.");
                    break;
                case 2:
                    Console.WriteLine("La saison du mois saisi est l'HIVER.");
                    break;
                case 3:
                    Console.WriteLine("La saison du mois saisi est l'HIVER.");
                    break;
                case 4:
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                    break;
                case 5:
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                    break;
                case 6:
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                    break;
                case 7:
                    Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
                    break;
                case 8:
                    Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
                    break;
                case 9:
                    Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
                    break;
                case 10:
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                    break;
                case 11:
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                    break;
                case 12:
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                    break;
                default:
                    Console.WriteLine("Ce mois n'existe pas.");
                    break;

            }
                
        }
    }
}
