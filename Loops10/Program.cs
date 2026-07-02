// a set is a grop of something- such as arrays and dictionaries and lists
//it is basiclly housing more than one variable at the same time
//loops= how to go over arrays many times 
//-------------------------------do and while loop-------------------------
//it is like if statement where everything inside the praentheses has to evaluate true or false  a boolean.
//what is ganna happen is whith both of (do...while) and (while) we're going to run a code inside the curly braces until they become false:

//Console.WriteLine("what is your age?");
//string ageText = Console.ReadLine();
//bool validAge = int.TryParse(ageText, out int age);
//if (validAge == false)
//{
//    Console.WriteLine("invalid age");

//}
// now if user enter invalid age like an sting we can not return and let use add another value, so we need a loop:
//---------------------ex----------------
//bool validAge;
//do
//{
//    Console.WriteLine("what is your age?");
//    string ageText = Console.ReadLine();
//      validAge = int.TryParse(ageText, out int age);
//    if (validAge == false)
//    {
//        Console.WriteLine("invalid age");

//    }
//} while (validAge == false) ;
//---------------------ex----------------
//bool firstName;
//do
//{
//    Console.Write("what is your name?");
//    string properName = Console.ReadLine();
//    firstName = properName.ToLower() == "yasin";
//    if (!firstName)
//    {
//        Console.WriteLine("User name is not okay!!");
//    }
//    else
//    {
//        Console.WriteLine("Welcome Yasin");
//    }
//}
//while (!firstName);
//what do loop is doning, is that it runs the code inside do braces untill it is finally true, otherwise it goes back and run it again.
//---------------------ex----------------
//int passCode;
//bool validPassCode;

//do
//{
//    Console.Write("Enter Your passCode: ");
//    string code = Console.ReadLine();
//    validPassCode = int.TryParse(code, out passCode);
//    if(!validPassCode && passCode != 36985)
//    {
//        Console.WriteLine("Wrong pass code, try again");
//    }
//}
//while (!validPassCode && passCode != 36985);
//Console.WriteLine("Welcome Dear user");
// as you see the loop will continus till the opposite of while (!validPassCode && passCode != 36985) will accor,
// then if so, it move to next line of code:
//Enter Your passCode: dvds
//Wrong pass code, try again
//Enter Your passCode: dv
//Wrong pass code, try again
//Enter Your passCode: v
//Wrong pass code, try again
//Enter Your passCode: v
//Wrong pass code, try again
//==> Enter Your passCode: 36985
//Welcome Dear user
//---------------------ex----------------
//int countNum = 0;

//do
//{
//    Console.WriteLine(countNum);
//    countNum += 2;
//}
//while (countNum <= 15);
//this will end up into an infinite loop: while (countNum != 15);
//(countNum <= 15) => will continue till the value is less or equall 15 : => 0
//2
//4
//6
//8
//10
//12
//14
//stops here

//=========================================while loop==========================
// it is the same as do...while loop
//while (true)
//{
    
//}
// why do we have two of them?
// the first one runs the codw (at least once), but while runs the code (0 or more times).
// int count = 0;
//while (count <= 10)
//{
//    Console.WriteLine($"count is: {count}");
//    count++;
//}

Console.ReadKey();