string Name = "Yasin";
bool isAlive = false;
long PhoneNumber = 9190953665;
string? livingState = null;
livingState = isAlive ? "alive" : "not alive";
bool isAvailbale = false;



Console.WriteLine(@$"this is {Name} and he is {livingState} and his phone number is +98{PhoneNumber} ");

Console.ReadKey();
