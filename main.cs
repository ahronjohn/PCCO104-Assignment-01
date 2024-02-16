using System;

namespace BankNoteScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the denomination (e.g., 1, 5, 10, 100, etc.): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double denomination))
            {
                string personality = GetPersonality(denomination);
                if (personality != null)
                {
                    Console.WriteLine($"Personality associated with {denomination:C}: {personality}");
                }
                else
                {
                    Console.WriteLine($"Invalid Denomination: {denomination:C}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric denomination.");
            }
        }

        static string GetPersonality(double denomination)
        {
            switch (denomination)
            {
                case 1:
                    return "Jose Rizal";
                case 5:
                    return "Emilio Aguinaldo";
                case 10:
                    return "Andres Bonifacio, Apolinario Mabini";
                case 20:
                    return "Manuel L. Quezon";
                case 50:
                    return "Sergio Osmena";
                case 100:
                    return "Manuel Roxas";
                case 200:
                    return "Diosdado Macapagal";
                case 500:
                    return "Benigno Sr. and Corazon Aquino";
                case 1000:
                    return "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";
                default:
                    return null;
            }
        }
    }
}
