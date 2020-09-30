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
            ShowMenuOptions();

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
                case 4:
                    DeleteBooking();
                    break;
                default:
                    return false;
                    break;
            }

            return false;
        }

        private static void DeleteBooking()
        {
            Console.WriteLine("Delete booking");
        }

        private static void ShowMenuOptions()
        {
            Console.WriteLine("1. Make booking");
            Console.WriteLine("2. Cancel booking");
            Console.WriteLine("3. Change Booking");
            Console.WriteLine("4. Delete Booking");
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
