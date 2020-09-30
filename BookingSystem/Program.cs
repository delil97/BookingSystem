using System;

namespace BookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO, menu där användaren kan boka med full CRUD, ha clean code

            bool quitProgram = false;

            while (!quitProgram)
            {
                quitProgram = ShowMenu();
            }

        }

        private static bool ShowMenu()
        {
            string userInput = Console.ReadLine();
            int parsedInput;
            bool isInt = int.TryParse(userInput, out parsedInput);

            while (!isInt)
            {
                Console.WriteLine("Try again");
                userInput = Console.ReadLine();
                isInt = int.TryParse(userInput, out parsedInput);
            }
     
            switch (parsedInput)
            {
                case 1:
                    MakeBooking();
                    break;
                case 2:
                    CancelBooking();
                    break;
                case 3:
                    ChangeBooking();
                    break;

                default:
                    Console.WriteLine("Choose again");
                    break;
            }

            return false;
        }

        private static void ChangeBooking()
        {
            Console.WriteLine("Make booking");
        }

        private static void CancelBooking()
        {
            Console.WriteLine("Cancel booking");
        }

        private static void MakeBooking()
        {
            Console.WriteLine("Change booking");
        }
    }
}
