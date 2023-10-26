using ChallangeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Michał", "Żółkiewicz", 32);
var supervisor = new Supervisor("Michał", "Żółkiewicz", 32);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

//while (true)
//{
//    Console.WriteLine("Podaj ocenę pracownika");
//    var input = Console.ReadLine();
//    if(input == "q")
//    {
//        break;
//    }

//    try
//    {
//        supervisor.AddGrade(input);
//    }
//    catch(Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }

//}