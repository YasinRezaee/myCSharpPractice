//doubles can have a decimal point = 45.23, 4.05, 59 
double avarageAge;
avarageAge = 10 / 3;
Console.WriteLine(avarageAge);// what is returend here is a rounded number=3
//what it meas is we can use duobles for decimal number like 80.2 
double newHoures = 70.5;
Console.WriteLine(newHoures /2);
// so the result will be 35.25
//as long as one of the number is decimal is good to go; 
double newCosts = (42.6 +20.1 + 6) / 2;
Console.WriteLine(newCosts); //the result will be 34.35 which is okay and no value is lost
// it is the most used when it comes to math. it is used everywhere
//as we said wit integers when it comes to dividing number(/), i truncates values-it meand some decimal points can get lost
//but with doubles is all good to go.
// there is a built in math library in dotnet:
Math.Round(newHoures, 2);
Math.Round(newCosts, 2);
Console.WriteLine(Math.Round(newHoures, 0));
Console.WriteLine(Math.Round(newCosts, 0));
//Math. ..... there are more to it...
// ***the problem with double is that when we are dealing with money numbers. beacuse it needs to be precise
Console.ReadKey();
