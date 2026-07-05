//for (int i = 0; i < length; i++)
//{

//}
//it loops through a set number of times.
//there are three section in for loops:
//1-> int i = 0; ==> it sets up our variable for counting.
//this variale will only last for the duration of this for loop, then it is gone.
// and this i is for counting. it is initial start of counting.
//2-> i < length; this is the evaluation portion. so basiclly as long as i is less then a portion the code inside barcket is run.
//3-> i++ : which mean add one 
// for example:
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"the code ran {i} times.");
}
//the result will be:
//the code ran 0 times.//the code ran 1 times.//the code ran 2 times.//the code ran 3 times.
//the code ran 4 times.//the code ran 5 times.//the code ran 6 times.//the code ran 7 times.
//the code ran 8 times.//the code ran 9 times.
// so the next time is 10 and since 10is not less rhan 10, the loop will stops and code moves to next line after the loop.
//------------------------ex-----------------------
string data = "Sue, Jane, Mark, David";
List<string> dataList = data.Split(',').ToList();

for (int i = 0; i < dataList.Count; i++)
{
    Console.WriteLine($"the person is {dataList[i]}");
    //the result will be : 
    //the person is Sue
    //the person is Jane
    //the person is Mark
    //the person is David
}
//------------------------ex-----------------------
List<decimal> charges = new ();
charges.Add(23.25M);
charges.Add(25.28M);
charges.Add(93.85M);

decimal total= 0;
for (int i = 0; i < charges.Count; i++)
{
   var res = total += charges[i];
}
    Console.WriteLine($"total is {total}");
//------------------------ex-----------------------
List<string> troopsName = new();
troopsName.Add("Travis");
troopsName.Add("Jakel");
troopsName.Add("Bastered");
troopsName.Add("OneEyeEvel");
 

for (int i = 0; i < troopsName.Count; i++)
{
    Console.WriteLine($"You are {troopsName[i]}");
    //You are Travis
    //You are Jakel
    //You are Bastered
    //You are OneEyeEvel
}
Console.ReadKey();