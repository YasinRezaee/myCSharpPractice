List<string> studentList = new List<string>();
string studentName;

do
{
    Console.Write("Add a student name to add to class:");
    studentName = Console.ReadLine();
    if (studentName.ToLower() == "exit") return;
    if (string.IsNullOrWhiteSpace(studentName))
    {
        Console.WriteLine("Name cannot be empty. Try again.");
        continue;  // Goes back to the top of the loop
    }

    studentList.Add(studentName);
    if (studentList.Count < 10)
    {
        Console.WriteLine($"You added {studentName} to the class." +
            $" you can add {10 - studentList.Count} more. to finish type (exit).");
    }
}
while (studentList.Count < 10);
Console.WriteLine($"You added {studentList.Count} students to the roster class");

Console.ReadKey();