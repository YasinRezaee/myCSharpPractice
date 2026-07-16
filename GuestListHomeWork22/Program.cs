using GuestListHomeWork23;
GuestsLogic.WelcomeMessage();
var (guests, total) = GuestsLogic.GetAllGuests();
GuestsLogic.DisplayGuestList(guests);
GuestsLogic.DisplayGuestsCount(total);
Console.ReadLine(); 