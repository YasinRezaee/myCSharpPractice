
namespace GuestListHomeWork23
{
    public static class GuestsLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome To The Guest Book App");
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }
        public static string GetPartyName()
        {
            Console.Write("What Is Your Party/Group Name:");
            string partyName = Console.ReadLine();
            return partyName;
        }
        public static int GetPartySize()
        {
            bool isValid;
            int partySize;
            {
                Console.Write("How Many People Are In Your Party");
                string partySizeText = Console.ReadLine();
                isValid = int.TryParse(partySizeText, out partySize);
            } while (isValid == false) ;
            return partySize;

        }
        public static bool AskToContinue()
        {
            Console.WriteLine("Are There More Guests Coming? (Yes/No)");
            string continueLooping = Console.ReadLine();
            bool output = (continueLooping.ToLower() == "yes");
            return output;

        }
        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuests = 0;
            List<string> guests = new List<string>();
            do
            {
                guests.Add(GetPartyName());
                totalGuests += GetPartySize();

            } while (AskToContinue());
            return (guests, totalGuests);
        }
        public static void DisplayGuestList(List<string> guests)
        {
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
        public static void DisplayGuestsCount(int total)
        {
            Console.WriteLine("Thanks For Everyone Who Attended.");
            Console.WriteLine($"Total guest count for this evening is {total}");
        }
    }
}
