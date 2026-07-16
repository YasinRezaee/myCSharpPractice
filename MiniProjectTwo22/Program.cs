//guest book
// ask users for their names and how many are in their party.
//it keeps asking as long as people come to the party 
// finally print out the guist list and totall number of guests
//-----------------------------------------------------------
using MiniProjectTwo22;

GuestIList.GreetingGuests();
List<(List<string> lastName, List<int> guests)> guestList = new();
bool isExit = false;

do
{
    string lastName = GuestIList.GetGuestsNames();
    int guests = GuestIList.GetNumberOfGuests();
    var incomingList = GuestIList.GetListOfGuests(lastName, guests);
    guestList.Add(incomingList);
    isExit = GuestIList.IsExit();
} while (!isExit);

foreach (var item in guestList)
{
    for (int i = 0; i < item.lastName.Count; i++)
    {
        Console.WriteLine($"Name: {item.lastName[i]}, Guests: {item.guests[i]}");
    }

}

int totalGuests = 0;
foreach (var item in guestList)
{
    totalGuests += item.guests[0];
}
Console.WriteLine($"Total Number of Guests: {totalGuests}");


Console.ReadLine();