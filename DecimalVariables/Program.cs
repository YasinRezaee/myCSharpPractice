//===================================decimal==========================================

double num = 1.3 / 3; 
 Console.WriteLine(num);// the result with double will be :0.43333333333333335 which it rouns the last one afer 15 !
//Int32 - 00000000 00000000 00000000 00000001 => iy alocate this much memory for int32 even if the value is just 1.
// decimal takes much larger memory
// use decimal only when you are dealin money
// we can not 
decimal backAcc = 1.3M;//it gets (M) suffix representing money. othervise it is considered as a double and conversion is not allowed in this case.
Console.WriteLine(backAcc /3);// the result will be 0.4333333333333333333333333333
//از اونجایی که وقتی با عدد پول سرکار داریم بیشتر یا جمع و یا کسر است دسیمال انتخاب خوبیه. غیر ازین بیشتر دابل پیشنهاد میشه

//=======================================bool======================================
bool isComplete; // true or false

Console.WriteLine(isComplete = true); // use ! to flip the value of a boolean

//======================================= null variables ======================================
//null = it is the lack of value
int? age = null;
bool? isHappening = null;
double? oldValue = null;
string firstName = null;
// null value for other types except sting coms with a ? mark.
//but not using a ? with string means it is a required value and must have a value, so better use ? 
age = 0; 
Console.WriteLine(age); 
//we can use ? for null vale 
Console.ReadKey();