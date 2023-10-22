using ChallangeApp;

Employee employee = new Employee("Michal", "Zolkiewicz", 32);

int gradeInt = 1;
double gradeDouble = 2.5;

employee.AddGrade("Michał");
employee.AddGrade("101");
employee.AddGrade('5');
employee.AddGrade('k');
employee.AddGrade(gradeInt);
employee.AddGrade(gradeDouble);
employee.AddGrade(5f);
employee.AddGrade(5);

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");