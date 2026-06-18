using System.Globalization;
Console.WriteLine("****************session 1 ***********************");

DateTime today = DateTime.Now;

Console.WriteLine(today);
//because of the time zone there is always a complixity with date time.
// DateTime object restores a full date and time: 6/18/2026 5:24:00 PM
Console.WriteLine(today.ToString(format:"d")); // short date: 6/18/2026
Console.WriteLine(today.ToString(format:"D")); // Thursday, June 18, 2026
Console.WriteLine(today.ToString(format:"F")); // Thursday, June 18, 2026 5:28:32 PM
Console.WriteLine(today.ToString(format:"M")); // June 18
 
// there is a long list each of which prints out a different format of time
DateTime birthDay = DateTime.Parse("5/26/1987");// outcome: 5/26/1987 12:00:00 AM
//DateTime birthDayyy = DateTime.Parse("25/6/1987");//System.FormatException: 'String '25/6/1987' was not recognized as a valid DateTime.'
//date time only recognizes US format and if changes it creates bug or even not copmiled by IDE.
Console.WriteLine(DateTime.ParseExact("6/11/1987", "d/M/yyyy", CultureInfo.InvariantCulture));
//we can use this to tell different date and time format from other cultures
Console.WriteLine(today.ToString("MMMM"));//4 M prints full month :June
Console.WriteLine(today.ToString("MMM dd hh"));//3 M prints abb month :Jun 
// d dd ddd dddd shows differnt formats of day
// this is true for h hh hhh D DD DD H  and many mor that is built in DateTime format
Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));// June 18, 2026 06:02 PM +03:30
DateTime newDay = DateTime.UtcNow;
Console.WriteLine(newDay); // 6 / 18 / 2026 2:38:31 PM
Console.WriteLine("****************session 2************************");
DateOnly myBirthDay = DateOnly.Parse("6/11/1987");
Console.WriteLine(myBirthDay.ToString("MM/dd/yy"));// 06/11/87
Console.WriteLine(myBirthDay.ToString("M/d/y"));// 6/11/87
Console.WriteLine(myBirthDay.ToString("MMMM/dd/yy"));// June/11/87
Console.WriteLine(myBirthDay.ToString("MMMM/dd/yyyy"));// June/11/1987
Console.WriteLine(myBirthDay.ToString("MMMM/dddd/yyyy"));// June/Thursday/1987
 

Console.ReadKey(); 